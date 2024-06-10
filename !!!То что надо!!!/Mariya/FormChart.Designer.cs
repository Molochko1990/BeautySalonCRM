namespace BeautySalonCRM
{
    partial class FormChart
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
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label1 = new Label();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(36, 67);
            cartesianChart1.Margin = new Padding(4, 5, 4, 5);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1070, 608);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(330, 32);
            label1.Name = "label1";
            label1.Size = new Size(492, 30);
            label1.TabIndex = 1;
            label1.Text = "Частота посещения клиентами салона красоты";
            label1.Click += label1_Click_1;
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label1);
            Controls.Add(cartesianChart1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormChart";
            Text = "FormChart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label1;
    }
}