namespace Mariya
{
    partial class AddVisit
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
            textBoxMasterId = new TextBox();
            label2 = new Label();
            textBoxServiceId = new TextBox();
            label3 = new Label();
            textBoxClientId = new TextBox();
            label4 = new Label();
            label1 = new Label();
            textBoxStatus = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            button2 = new Button();
            comboBoxMaster = new ComboBox();
            masterBindingSource = new BindingSource(components);
            masterBindingSource1 = new BindingSource(components);
            comboBoxClient = new ComboBox();
            clientBindingSource = new BindingSource(components);
            comboBoxService = new ComboBox();
            serviceBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            masterIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitBindingSource = new BindingSource(components);
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxMasterId
            // 
            textBoxMasterId.BackColor = Color.LavenderBlush;
            textBoxMasterId.ForeColor = SystemColors.Info;
            textBoxMasterId.Location = new Point(253, 360);
            textBoxMasterId.Margin = new Padding(4, 3, 4, 3);
            textBoxMasterId.Name = "textBoxMasterId";
            textBoxMasterId.Size = new Size(13, 31);
            textBoxMasterId.TabIndex = 3;
            textBoxMasterId.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 2;
            label2.Text = "Фамилия мастера";
            label2.Click += label2_Click;
            // 
            // textBoxServiceId
            // 
            textBoxServiceId.BackColor = Color.LavenderBlush;
            textBoxServiceId.ForeColor = SystemColors.Info;
            textBoxServiceId.Location = new Point(313, 298);
            textBoxServiceId.Margin = new Padding(4, 3, 4, 3);
            textBoxServiceId.Name = "textBoxServiceId";
            textBoxServiceId.Size = new Size(13, 31);
            textBoxServiceId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 235);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 6;
            label3.Text = "Название услуги";
            // 
            // textBoxClientId
            // 
            textBoxClientId.BackColor = Color.LavenderBlush;
            textBoxClientId.ForeColor = SystemColors.Info;
            textBoxClientId.Location = new Point(336, 298);
            textBoxClientId.Margin = new Padding(4, 3, 4, 3);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(13, 31);
            textBoxClientId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 163);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 4;
            label4.Text = "Фамилия клиента";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 303);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 8;
            label1.Text = "Статус услуги";
            label1.Click += label1_Click;
            // 
            // textBoxStatus
            // 
            textBoxStatus.BackColor = Color.White;
            textBoxStatus.ForeColor = SystemColors.ControlText;
            textBoxStatus.Location = new Point(177, 298);
            textBoxStatus.Margin = new Padding(4, 3, 4, 3);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(215, 31);
            textBoxStatus.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(254, 460);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(140, 47);
            button1.TabIndex = 12;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.LightCoral;
            dateTimePicker1.CalendarMonthBackground = Color.LightCoral;
            dateTimePicker1.Location = new Point(177, 360);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 31);
            dateTimePicker1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 365);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 9;
            label5.Text = "Дата";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(19, 460);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(134, 47);
            button2.TabIndex = 14;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBoxMaster
            // 
            comboBoxMaster.Cursor = Cursors.No;
            comboBoxMaster.DataSource = masterBindingSource;
            comboBoxMaster.DisplayMember = "Surname";
            comboBoxMaster.FormattingEnabled = true;
            comboBoxMaster.Location = new Point(177, 93);
            comboBoxMaster.Margin = new Padding(4, 5, 4, 5);
            comboBoxMaster.Name = "comboBoxMaster";
            comboBoxMaster.Size = new Size(215, 33);
            comboBoxMaster.TabIndex = 15;
            comboBoxMaster.ValueMember = "Id";
            comboBoxMaster.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // masterBindingSource
            // 
            masterBindingSource.DataSource = typeof(Data.Master);
            // 
            // masterBindingSource1
            // 
            masterBindingSource1.DataSource = typeof(Data.Master);
            // 
            // comboBoxClient
            // 
            comboBoxClient.DataSource = clientBindingSource;
            comboBoxClient.DisplayMember = "Surname";
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(177, 158);
            comboBoxClient.Margin = new Padding(4, 5, 4, 5);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(215, 33);
            comboBoxClient.TabIndex = 16;
            comboBoxClient.ValueMember = "Id";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Data.Client);
            // 
            // comboBoxService
            // 
            comboBoxService.DataSource = serviceBindingSource;
            comboBoxService.DisplayMember = "Name";
            comboBoxService.FormattingEnabled = true;
            comboBoxService.Location = new Point(177, 230);
            comboBoxService.Margin = new Padding(4, 5, 4, 5);
            comboBoxService.Name = "comboBoxService";
            comboBoxService.Size = new Size(215, 33);
            comboBoxService.TabIndex = 17;
            comboBoxService.ValueMember = "Id";
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Data.Service);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, masterIdDataGridViewTextBoxColumn, clientIdDataGridViewTextBoxColumn, serviceIdDataGridViewTextBoxColumn, timeDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = visitBindingSource;
            dataGridView1.Location = new Point(313, 243);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(14, 17);
            dataGridView1.TabIndex = 18;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // masterIdDataGridViewTextBoxColumn
            // 
            masterIdDataGridViewTextBoxColumn.DataPropertyName = "MasterId";
            masterIdDataGridViewTextBoxColumn.HeaderText = "MasterId";
            masterIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            masterIdDataGridViewTextBoxColumn.Name = "masterIdDataGridViewTextBoxColumn";
            masterIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            clientIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            serviceIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            serviceIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // visitBindingSource
            // 
            visitBindingSource.DataSource = typeof(Data.Visit);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(17, 32);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(440, 40);
            label6.TabIndex = 19;
            label6.Text = "Добавление нового посещения";
            label6.Click += label6_Click;
            // 
            // AddVisit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 525);
            Controls.Add(label6);
            Controls.Add(comboBoxService);
            Controls.Add(comboBoxClient);
            Controls.Add(comboBoxMaster);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(textBoxStatus);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBoxServiceId);
            Controls.Add(textBoxClientId);
            Controls.Add(textBoxMasterId);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddVisit";
            Text = "AddVisit";
            Load += AddVisit_Load;
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxMasterId;
        private Label label2;
        private TextBox textBoxServiceId;
        private Label label3;
        private TextBox textBoxClientId;
        private Label label4;
        private Label label1;
        private TextBox textBoxStatus;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button2;
        private ComboBox comboBoxMaster;
        private BindingSource masterBindingSource;
        private BindingSource masterBindingSource1;
        private ComboBox comboBoxClient;
        private ComboBox comboBoxService;
        private BindingSource clientBindingSource;
        private BindingSource serviceBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn masterIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource visitBindingSource;
        private Label label6;
    }
}