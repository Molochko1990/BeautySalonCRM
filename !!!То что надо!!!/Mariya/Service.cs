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
    public partial class Service : Form
    {
        SalonContext context;
        public Service()
        {
            context = new SalonContext();
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Service_Load(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("111", "222");

            context.Services.Load();
            serviceBindingSource.DataSource = context.Services.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = textBox1.Text;

            serviceBindingSource.DataSource = context.Services.Where(x => x.Name.Contains(query)).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
