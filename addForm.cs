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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
            var dataForComboBox = new List<string>
            {
                "Годная",
                "Брак"
            };
            using (ApplicationContext db = new ApplicationContext())
            {
                var dataForSteelBox = db.Steel.ToList();
                comboBoxSteel.DataSource = dataForSteelBox;
                comboBoxSteel.DisplayMember = "SteelGrade";
                comboBoxSteel.ValueMember = "Id";
            }
            comboBoxQuality.DataSource = dataForComboBox;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var pipe = new PipesModel();
            try
            {
                pipe.PipeNumber = Convert.ToInt32(textBoxNumber.Text);
                if (comboBoxQuality.Text == "Годная")
                    pipe.Quality = true;
                else if (comboBoxQuality.Text == "Брак")
                    pipe.Quality = false;
                else
                    throw new Exception();
                Steel steel1 = (Steel)comboBoxSteel.SelectedItem;
                pipe.SteelId = steel1.Id;
                pipe.Size = textBoxSize.Text;
                pipe.Weight = Convert.ToInt32(textBoxWeight.Text);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Неверный формат данных");
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Pipes.Add(pipe);
                db.SaveChanges();

            }
            this.Close();
        }



        private void comboBoxQuality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
