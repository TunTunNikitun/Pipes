using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskForTMK.Models;

namespace TestTaskForTMK
{
    public partial class AddPackageForm : Form
    {
        public AddPackageForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var pipesNumbers = (from p in db.Pipes select p.PipeNumber).ToList();
                DataTable table = new DataTable();
                table.Columns.Add("Номер трубы");
                foreach (var item in pipesNumbers)
                {
                    table.Rows.Add(item);
                }
                dataGridView1.DataSource = table;

                dataGridView2.Columns.Add("PipeNumber", "Номер трубы");

            }
        }

        private void AddPackageForm_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ind = e.RowIndex;
            dataGridView2.Rows.Add(dataGridView1.Rows[ind].Cells[0].Value);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var packageDate = textBoxPackageDate.Text;
                var packegeNumber = Convert.ToInt32(textBoxPackageNumber.Text);
                var package = new Packages();
                package.PackageNumber = packegeNumber;
                package.PackageDate = packageDate;
                db.Packages.Add(package);
                db.SaveChanges();

                List<PackageStructure> packageStructures = new List<PackageStructure>();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        var pipe = (Convert.ToInt32(row.Cells[0].Value));
                        PackageStructure ps = new PackageStructure();
                        ps.PackageId = db.Packages.FirstOrDefault(p => p.PackageNumber == packegeNumber).Id;
                        ps.PipeId = db.Pipes.FirstOrDefault(p => p.PipeNumber == pipe).Id;
                        packageStructures.Add(ps);
                    }
                }
                db.PackageStructure.AddRange(packageStructures);
                db.SaveChanges();
            }
        }

        private void AddPackageForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
