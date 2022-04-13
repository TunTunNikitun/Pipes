using Microsoft.EntityFrameworkCore;
using TestTaskForTMK.Models;

namespace TestTaskForTMK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckData();
            ChangeColumn();
            LoadData();
        }

        private void ChangeColumn()
        {
            dataGridView1.Columns.RemoveAt(1);
            var column = new DataGridViewComboBoxColumn();
            column.Name = "Quility";
            column.HeaderText = "Качество";
            var a = new List<string> { "Годная", "Брак" };
            column.DataSource = a;
            dataGridView1.Columns.Insert(1, column);
        }
        private void LoadPipes()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var pipes = db.Pipes.Include(s => s.Steel).ToList();
                foreach (var pipe in pipes)
                {
                    dataGridView1.Rows.Add(pipe.PipeNumber, pipe.Quality ? "Годная" : "Брак", pipe.Steel.SteelGrade, pipe.Weight, pipe.Size);

                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    ColorChange(i);
                }
            }
        }
        private void LoadData()
        {

            LoadPipes();
            LoadPackages();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedCells[0].RowIndex;
            PipesModel pipe = GetPipeFromRow(row);


            using (ApplicationContext db = new ApplicationContext())
            {
                db.Pipes.Remove(db.Pipes.FirstOrDefault(p => p.PipeNumber == pipe.PipeNumber));
                db.SaveChanges();
                dataGridView1.Rows.RemoveAt(row);
            }
        }
        private PipesModel GetPipeFromRow(int rowIndex)
        {
            var row = dataGridView1.SelectedCells[0].RowIndex;
            PipesModel pipe = new PipesModel();
            pipe.PipeNumber = pipe.PipeNumber = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
            if (dataGridView1.Rows[row].Cells[1].Value.ToString() == "Годная")
                pipe.Quality = true;
            else if (dataGridView1.Rows[row].Cells[1].Value.ToString() == "Брак")
                pipe.Quality = false;
            else
                throw new Exception();
            pipe.SteelId = FindSteel(dataGridView1.Rows[row].Cells[2].Value.ToString());

            pipe.Weight = Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            pipe.Size = dataGridView1.Rows[row].Cells[4].Value.ToString();
            return pipe;
        }

        private int FindSteel(string data)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var st = db.Steel.ToList();
                foreach (var s in st)
                {
                    if (s.SteelGrade == data)
                        return s.Id;
                }
                return -1;
            }
        }
        private void CheckData()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var steel = db.Steel.ToList();
                if (steel.Count == 0)
                {

                    Steel steel1 = new Steel { SteelGrade = "12Х1МФ" };
                    Steel steel2 = new Steel { SteelGrade = "ст10-45" };
                    Steel steel3 = new Steel { SteelGrade = "09Г2С" };
                    Steel steel4 = new Steel { SteelGrade = "10Г2" };
                    Steel steel5 = new Steel { SteelGrade = "15Х" };
                    var steels = new Steel[] { steel1, steel2, steel3, steel4, steel5 };

                    db.Steel.AddRange(steels);
                    db.SaveChanges();


                }
                var pipes = db.Pipes.ToList();
                if (pipes.Count == 0)
                {
                    PipesModel pipe1 = new PipesModel { PipeNumber = 1, Quality = true, SteelId = 1, Size = "20x30", Weight = 200 };
                    PipesModel pipe2 = new PipesModel { PipeNumber = 2, Quality = false, SteelId = 2, Size = "90x60", Weight = 800 };
                    PipesModel pipe3 = new PipesModel { PipeNumber = 3, Quality = true, SteelId = 3, Size = "70x5", Weight = 50 };
                    var pipes1 = new PipesModel[] { pipe1, pipe2, pipe3 };
                    db.Pipes.AddRange(pipes1);
                    db.SaveChanges();

                }
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedCells[0].RowIndex;
            var pipe = GetPipeFromRow(row);
            GreegPipe.Pipe = pipe;
            var c = new ChangeForm(pipe);
            c.FormClosed += new FormClosedEventHandler(ChangeForm_FormClosed);
            c.ShowDialog();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (e.ColumnIndex == 1)
                {
                    ColorChange(i);
                }
            }
        }
        private void ColorChange(int i)
        {
            if (dataGridView1[1, i].Value.ToString() == "Брак")
            {
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    cell.Style.BackColor = Color.Red;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            var f = new addForm();
            f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            f.ShowDialog();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                ColorChange(i);
            }
        }


        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadPipes();
        }
        void ChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadPipes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddPackage_Click(object sender, EventArgs e)
        {
            var addPackage = new AddPackageForm();
            addPackage.FormClosed += new FormClosedEventHandler(AddPackage_FormClosed);
            addPackage.ShowDialog();
        }
        void AddPackage_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView2.Rows.Clear();
            LoadPackages();
        }
        private void LoadPackages()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var data = from ps in db.PackageStructure
                           join pipe in db.Pipes on ps.PipeId equals pipe.Id
                           join package in db.Packages on ps.PackageId equals package.Id
                           select new

                           {
                               PipeNumber = pipe.PipeNumber,
                               PackageNumber = package.PackageNumber,
                               PackageDate = package.PackageDate
                           };
                var packagesData = new List<packageToDataGrid>();
                var packageNumbers = data.Select(pn => pn.PackageNumber).Distinct().ToList();
                foreach (var pn in packageNumbers)
                {
                    var packData = new packageToDataGrid();
                    packData.PackageNumber = pn;
                    var pipeN = data.Where(x => x.PackageNumber == pn).Select(x => x.PipeNumber).ToList();
                    packData.PipesNumber = pipeN;
                    packData.PackageDate = data.Where(x => x.PackageNumber == pn).Select(x => x.PackageDate).ToList()[0];
                    packagesData.Add(packData);
                }
                foreach (var d in packagesData)
                {
                    dataGridView2.Rows.Add(d.PackageNumber, d.PackageDate, string.Join(",", d.PipesNumber));
                }
            }
        }
    }
    static class GreegPipe
    {
        public static PipesModel Pipe { get; set; }

    }
}
