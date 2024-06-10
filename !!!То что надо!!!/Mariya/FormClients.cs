using Mariya.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mariya
{
    public partial class FormClients : Form
    {
        SalonContext context;
        public FormClients()
        {
            context = new SalonContext();
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Clients_Load(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("111", "222");

            context.Clients.Load();
            clientBindingSource.DataSource = context.Clients.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = textBox1.Text;

            clientBindingSource.DataSource = context.Clients.Where(x => x.Surname.Contains(query)).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
