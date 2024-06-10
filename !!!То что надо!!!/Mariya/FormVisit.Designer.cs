namespace Mariya
{
    partial class FormVisit
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            masterIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Master = new DataGridViewComboBoxColumn();
            masterBindingSource = new BindingSource(components);
            client = new DataGridViewComboBoxColumn();
            clientBindingSource = new BindingSource(components);
            service = new DataGridViewComboBoxColumn();
            serviceBindingSource = new BindingSource(components);
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitBindingSource = new BindingSource(components);
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            графикиToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBoxMaster = new TextBox();
            button2 = new Button();
            button3 = new Button();
            buttonClientsTable = new Button();
            buttonMasterTable = new Button();
            label2 = new Label();
            button4 = new Button();
            textBoxClient = new TextBox();
            textBoxService = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, masterIdDataGridViewTextBoxColumn, Master, client, service, timeDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = visitBindingSource;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(32, 76);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(903, 363);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Код посещения";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // masterIdDataGridViewTextBoxColumn
            // 
            masterIdDataGridViewTextBoxColumn.DataPropertyName = "MasterId";
            masterIdDataGridViewTextBoxColumn.HeaderText = "Код мастера";
            masterIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            masterIdDataGridViewTextBoxColumn.Name = "masterIdDataGridViewTextBoxColumn";
            masterIdDataGridViewTextBoxColumn.Visible = false;
            masterIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // Master
            // 
            Master.DataPropertyName = "MasterId";
            Master.DataSource = masterBindingSource;
            Master.DisplayMember = "Surname";
            Master.HeaderText = "Фамилия мастера";
            Master.Name = "Master";
            Master.ValueMember = "Id";
            // 
            // masterBindingSource
            // 
            masterBindingSource.DataSource = typeof(Data.Master);
            // 
            // client
            // 
            client.DataPropertyName = "ClientId";
            client.DataSource = clientBindingSource;
            client.DisplayMember = "Surname";
            client.HeaderText = "Фамилия клиента";
            client.MinimumWidth = 8;
            client.Name = "client";
            client.Resizable = DataGridViewTriState.True;
            client.SortMode = DataGridViewColumnSortMode.Automatic;
            client.ValueMember = "Id";
            client.Width = 150;
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Data.Client);
            // 
            // service
            // 
            service.DataPropertyName = "ServiceId";
            service.DataSource = serviceBindingSource;
            service.DisplayMember = "Name";
            service.HeaderText = "Название услуги";
            service.MinimumWidth = 8;
            service.Name = "service";
            service.Resizable = DataGridViewTriState.True;
            service.SortMode = DataGridViewColumnSortMode.Automatic;
            service.ValueMember = "Id";
            service.Width = 150;
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Data.Service);
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Время и Дата";
            timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Статус услуги";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // visitBindingSource
            // 
            visitBindingSource.DataSource = typeof(Data.Visit);
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(843, 444);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(92, 37);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem, toolStripMenuItem1, графикиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(967, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.BackColor = Color.PaleVioletRed;
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            файлToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.BackColor = Color.LavenderBlush;
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(109, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.BackColor = Color.PaleVioletRed;
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.BackColor = Color.LavenderBlush;
            оПрограммеToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // графикиToolStripMenuItem
            // 
            графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            графикиToolStripMenuItem.Size = new Size(67, 20);
            графикиToolStripMenuItem.Text = "Графики";
            графикиToolStripMenuItem.Click += графикиToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 52);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Поиск";
            label1.Click += label1_Click;
            // 
            // textBoxMaster
            // 
            textBoxMaster.BackColor = Color.LavenderBlush;
            textBoxMaster.ForeColor = SystemColors.InactiveCaptionText;
            textBoxMaster.Location = new Point(80, 49);
            textBoxMaster.Margin = new Padding(3, 2, 3, 2);
            textBoxMaster.Name = "textBoxMaster";
            textBoxMaster.Size = new Size(182, 23);
            textBoxMaster.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(268, 49);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(67, 25);
            button2.TabIndex = 5;
            button2.Text = "Найти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LavenderBlush;
            button3.Location = new Point(32, 492);
            button3.Name = "button3";
            button3.Size = new Size(141, 37);
            button3.TabIndex = 6;
            button3.Text = "Услуги";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonClientsTable
            // 
            buttonClientsTable.BackColor = Color.LavenderBlush;
            buttonClientsTable.Location = new Point(194, 492);
            buttonClientsTable.Name = "buttonClientsTable";
            buttonClientsTable.Size = new Size(141, 37);
            buttonClientsTable.TabIndex = 6;
            buttonClientsTable.Text = "Клиенты";
            buttonClientsTable.UseVisualStyleBackColor = false;
            buttonClientsTable.Click += buttonClientsTable_Click;
            // 
            // buttonMasterTable
            // 
            buttonMasterTable.BackColor = Color.LavenderBlush;
            buttonMasterTable.Location = new Point(353, 492);
            buttonMasterTable.Name = "buttonMasterTable";
            buttonMasterTable.Size = new Size(141, 37);
            buttonMasterTable.TabIndex = 7;
            buttonMasterTable.Text = "Мастера";
            buttonMasterTable.UseVisualStyleBackColor = false;
            buttonMasterTable.Click += buttonMasterTable_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(660, 45);
            label2.Name = "label2";
            label2.Size = new Size(275, 21);
            label2.TabIndex = 8;
            label2.Text = "Информация о посещениях в салоне";
            // 
            // button4
            // 
            button4.BackColor = Color.PaleVioletRed;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(722, 444);
            button4.Name = "button4";
            button4.Size = new Size(108, 38);
            button4.TabIndex = 9;
            button4.Text = "Сохранить изменения";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBoxClient
            // 
            textBoxClient.Location = new Point(756, 382);
            textBoxClient.Name = "textBoxClient";
            textBoxClient.Size = new Size(14, 23);
            textBoxClient.TabIndex = 10;
            textBoxClient.Visible = false;
            // 
            // textBoxService
            // 
            textBoxService.Location = new Point(815, 193);
            textBoxService.Name = "textBoxService";
            textBoxService.Size = new Size(15, 23);
            textBoxService.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(32, 454);
            label3.Name = "label3";
            label3.Size = new Size(210, 17);
            label3.TabIndex = 12;
            label3.Text = "Открыть следущую информацию:";
            // 
            // FormVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(967, 623);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(buttonMasterTable);
            Controls.Add(buttonClientsTable);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBoxMaster);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(textBoxClient);
            Controls.Add(textBoxService);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVisit";
            Text = "Visit";
            Load += Visit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label label1;
        private TextBox textBoxMaster;
        private Button button2;
        private Button button3;
        private Button buttonClientsTable;
        private BindingSource visitBindingSource;
        private Button buttonMasterTable;
        private Label label2;
        private Button button4;
        private BindingSource masterBindingSource;
        private BindingSource clientBindingSource;
        private BindingSource serviceBindingSource;
        private TextBox textBoxClient;
        private TextBox textBoxService;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem графикиToolStripMenuItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn masterIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Master;
        private DataGridViewComboBoxColumn client;
        private DataGridViewComboBoxColumn service;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Label label3;
    }
}