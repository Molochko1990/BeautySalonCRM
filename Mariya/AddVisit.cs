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

        private void button1_Click(object sender, EventArgs e)
        {
            var masterId = textBoxMasterId.Text;
            var clientId = textBoxClientId.Text;
            var serviceId =textBoxServiceId.Text;
            var status = textBoxStatus.Text;
            var time = dateTimePicker1.Text;
            MessageBox.Show("Данные успешно добавлены");

            //var visit = new Visit
            //{
            //     MasterId = masterId,
            //    ClientId = clientId,
            //    ServiceId = serviceId,
            //    Time = time,
            //    Status = status

            //};
            //context.Visits.Add(visit);
            //context.SaveChanges();


        }

        private void AddVisit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
