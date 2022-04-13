namespace TestTaskForTMK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PipeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Steel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddPackage = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PackageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pipes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PipeNumber,
            this.Quality,
            this.Steel,
            this.Weight,
            this.Size});
            this.dataGridView1.Location = new System.Drawing.Point(51, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(680, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // PipeNumber
            // 
            this.PipeNumber.HeaderText = "Номер трубы";
            this.PipeNumber.MinimumWidth = 6;
            this.PipeNumber.Name = "PipeNumber";
            this.PipeNumber.ReadOnly = true;
            this.PipeNumber.Width = 125;
            // 
            // Quality
            // 
            this.Quality.HeaderText = "Качество";
            this.Quality.MinimumWidth = 6;
            this.Quality.Name = "Quality";
            this.Quality.ReadOnly = true;
            this.Quality.Width = 125;
            // 
            // Steel
            // 
            this.Steel.HeaderText = "Сталь";
            this.Steel.MinimumWidth = 6;
            this.Steel.Name = "Steel";
            this.Steel.ReadOnly = true;
            this.Steel.Width = 125;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Вес";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 125;
            // 
            // Size
            // 
            this.Size.HeaderText = "Размер";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 125;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(70, 272);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(125, 29);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить строку";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(381, 272);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(94, 29);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Изменить строку";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 454);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.ChangeButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(216, 272);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(136, 29);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить строку";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddPackage);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddPackage
            // 
            this.AddPackage.Location = new System.Drawing.Point(27, 230);
            this.AddPackage.Name = "AddPackage";
            this.AddPackage.Size = new System.Drawing.Size(125, 29);
            this.AddPackage.TabIndex = 2;
            this.AddPackage.Text = "Добавить пакет";
            this.AddPackage.UseVisualStyleBackColor = true;
            this.AddPackage.Click += new System.EventHandler(this.AddPackage_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageNumber,
            this.PackageDate,
            this.Pipes});
            this.dataGridView2.Location = new System.Drawing.Point(27, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(664, 188);
            this.dataGridView2.TabIndex = 0;
            // 
            // PackageNumber
            // 
            this.PackageNumber.HeaderText = "Номер пакета";
            this.PackageNumber.MinimumWidth = 6;
            this.PackageNumber.Name = "PackageNumber";
            this.PackageNumber.ReadOnly = true;
            this.PackageNumber.Width = 125;
            // 
            // PackageDate
            // 
            this.PackageDate.HeaderText = "Дата";
            this.PackageDate.MinimumWidth = 6;
            this.PackageDate.Name = "PackageDate";
            this.PackageDate.ReadOnly = true;
            this.PackageDate.Width = 125;
            // 
            // Pipes
            // 
            this.Pipes.HeaderText = "Трубы";
            this.Pipes.MinimumWidth = 6;
            this.Pipes.Name = "Pipes";
            this.Pipes.ReadOnly = true;
            this.Pipes.Width = 125;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button DeleteButton;
        private DataGridViewTextBoxColumn PipeNumber;
        private DataGridViewTextBoxColumn Quality;
        private DataGridViewTextBoxColumn Steel;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Size;
        private Button ChangeButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn PackageNumber;
        private DataGridViewTextBoxColumn PackageDate;
        private DataGridViewTextBoxColumn Pipes;
        private Button AddButton;
        private Button AddPackage;
    }
}