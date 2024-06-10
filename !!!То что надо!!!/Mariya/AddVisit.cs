using Mariya.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mariya
{
    public partial class AddVisit : Form
    {
        SalonContext context;
        public AddVisit()
        {
            context = new SalonContext();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddVisit_Load(object sender, EventArgs e)
        {
            // Загрузка данных из базы данных в BindingSource
            masterBindingSource.DataSource = context.Masters.ToList();
            clientBindingSource.DataSource = context.Clients.ToList();
            serviceBindingSource.DataSource = context.Services.ToList();
        }
        private void SetupBindings(object sender, EventArgs e)
        {
            // Настройка привязки данных для ComboBox
            comboBoxMaster.DataSource = masterBindingSource;
            comboBoxMaster.DisplayMember = "Surname";
            comboBoxMaster.ValueMember = "MasterId";

            comboBoxClient.DataSource = clientBindingSource;
            comboBoxClient.DisplayMember = "Surname";
            comboBoxClient.ValueMember = "ClientId";

            comboBoxService.DataSource = serviceBindingSource;
            comboBoxService.DisplayMember = "Name";
            comboBoxService.ValueMember = "ServiceId";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var masterId = Convert.ToInt32(comboBoxMaster.SelectedValue);
            var clientId = Convert.ToInt32(comboBoxClient.SelectedValue);
            var serviceId = Convert.ToInt32(comboBoxService.SelectedValue);
            var status = textBoxStatus.Text;
            var time = dateTimePicker1.Value;
            MessageBox.Show("Данные успешно добавлены");

            var visit = new Visit
            {
                MasterId = masterId,
                ClientId = clientId,
                ServiceId = serviceId,
                Time = time,
                Status = status

            };
            context.Visits.Add(visit);
            context.SaveChanges();

            //visitBindingSource.DataSource = context.Visits.ToList();





        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
