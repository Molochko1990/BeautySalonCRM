using System.Windows.Forms;

namespace Mariya
{
    partial class Master
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            masterBindingSource = new BindingSource(components);
            button1 = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, firstDateDataGridViewTextBoxColumn, expirDataGridViewTextBoxColumn });
            dataGridView1.DataSource = masterBindingSource;
            dataGridView1.Location = new Point(11, 11);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(735, 311);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // masterBindingSource
            // 
            masterBindingSource.DataSource = typeof(Data.Master);
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(665, 326);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(81, 30);
            button1.TabIndex = 1;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Код мастера";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            surnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstDateDataGridViewTextBoxColumn
            // 
            firstDateDataGridViewTextBoxColumn.DataPropertyName = "FirstDate";
            firstDateDataGridViewTextBoxColumn.HeaderText = "Дата начала работы";
            firstDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            firstDateDataGridViewTextBoxColumn.Name = "firstDateDataGridViewTextBoxColumn";
            firstDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // expirDataGridViewTextBoxColumn
            // 
            expirDataGridViewTextBoxColumn.DataPropertyName = "Expir";
            expirDataGridViewTextBoxColumn.HeaderText = "Опыт";
            expirDataGridViewTextBoxColumn.MinimumWidth = 8;
            expirDataGridViewTextBoxColumn.Name = "expirDataGridViewTextBoxColumn";
            expirDataGridViewTextBoxColumn.Width = 150;
            // 
            // Master
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 367);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Master";
            Text = "Master";
            Load += Master_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource masterBindingSource;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirDataGridViewTextBoxColumn;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
    }
}