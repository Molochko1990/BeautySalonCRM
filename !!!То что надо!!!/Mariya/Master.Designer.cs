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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            masterBindingSource = new BindingSource(components);
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
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
            dataGridView1.Location = new Point(11, 52);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(735, 332);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // masterBindingSource
            // 
            masterBindingSource.DataSource = typeof(Data.Master);
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(651, 388);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(81, 30);
            button1.TabIndex = 1;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(491, 388);
            button3.Name = "button3";
            button3.Size = new Size(155, 29);
            button3.TabIndex = 2;
            button3.Text = "Сохранить изменения";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(513, 22);
            label2.Name = "label2";
            label2.Size = new Size(233, 21);
            label2.TabIndex = 3;
            label2.Text = "Информация о мастерах слона";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 4;
            label1.Text = "Поиск по фамилии";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(274, 20);
            button2.Name = "button2";
            button2.Size = new Size(66, 23);
            button2.TabIndex = 6;
            button2.Text = "Найти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Master
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 430);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Master";
            Text = "Master";
            Load += Master_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button3;
        private Label label2;
    }
}