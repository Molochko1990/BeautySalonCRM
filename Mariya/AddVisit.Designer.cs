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
            SuspendLayout();
            // 
            // textBoxMasterId
            // 
            textBoxMasterId.BackColor = Color.LavenderBlush;
            textBoxMasterId.ForeColor = SystemColors.Info;
            textBoxMasterId.Location = new Point(146, 19);
            textBoxMasterId.Margin = new Padding(3, 2, 3, 2);
            textBoxMasterId.Name = "textBoxMasterId";
            textBoxMasterId.Size = new Size(176, 23);
            textBoxMasterId.TabIndex = 3;
            textBoxMasterId.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 21);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Код Мастера";
            label2.Click += label2_Click;
            // 
            // textBoxServiceId
            // 
            textBoxServiceId.BackColor = Color.LavenderBlush;
            textBoxServiceId.ForeColor = SystemColors.Info;
            textBoxServiceId.Location = new Point(146, 91);
            textBoxServiceId.Margin = new Padding(3, 2, 3, 2);
            textBoxServiceId.Name = "textBoxServiceId";
            textBoxServiceId.Size = new Size(176, 23);
            textBoxServiceId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 91);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Код Услуги";
            // 
            // textBoxClientId
            // 
            textBoxClientId.BackColor = Color.LavenderBlush;
            textBoxClientId.ForeColor = SystemColors.Info;
            textBoxClientId.Location = new Point(146, 55);
            textBoxClientId.Margin = new Padding(3, 2, 3, 2);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(176, 23);
            textBoxClientId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 57);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 4;
            label4.Text = "Код Клиента";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 125);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 8;
            label1.Text = "Статус услуги";
            label1.Click += label1_Click;
            // 
            // textBoxStatus
            // 
            textBoxStatus.BackColor = Color.LavenderBlush;
            textBoxStatus.ForeColor = SystemColors.Info;
            textBoxStatus.Location = new Point(146, 123);
            textBoxStatus.Margin = new Padding(3, 2, 3, 2);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(176, 23);
            textBoxStatus.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(224, 212);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 28);
            button1.TabIndex = 12;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.LightCoral;
            dateTimePicker1.CalendarMonthBackground = Color.LightCoral;
            dateTimePicker1.Location = new Point(146, 161);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(176, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 169);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 9;
            label5.Text = "Дата";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(25, 212);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(94, 28);
            button2.TabIndex = 14;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 259);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(textBoxStatus);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBoxServiceId);
            Controls.Add(label3);
            Controls.Add(textBoxClientId);
            Controls.Add(label4);
            Controls.Add(textBoxMasterId);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddVisit";
            Text = "AddVisit";
            Load += AddVisit_Load;
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
    }
}