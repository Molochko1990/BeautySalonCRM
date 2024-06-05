namespace Mariya
{
    partial class Service
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
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = Color.Silver;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, costDataGridViewTextBoxColumn });
            dataGridView2.DataSource = serviceBindingSource;
            dataGridView2.Location = new Point(12, 54);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(512, 319);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Код услуги";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn
            // 
            costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            costDataGridViewTextBoxColumn.MinimumWidth = 8;
            costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            costDataGridViewTextBoxColumn.Width = 150;
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Data.Service);
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(449, 379);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 1;
            button1.Text = "Закрыть вкладку";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(243, 25);
            button2.Name = "button2";
            button2.Size = new Size(79, 24);
            button2.TabIndex = 2;
            button2.Text = "Найти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 4;
            label1.Text = "Поиск по названию ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 30);
            label2.Name = "label2";
            label2.Size = new Size(238, 15);
            label2.TabIndex = 5;
            label2.Text = "Информация о предоставляемых услугах";
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(296, 379);
            button3.Name = "button3";
            button3.Size = new Size(147, 26);
            button3.TabIndex = 6;
            button3.Text = "Сохранить изменения";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 431);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Name = "Service";
            Text = "Service";
            Load += Service_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private Button button1;
        private BindingSource serviceBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}