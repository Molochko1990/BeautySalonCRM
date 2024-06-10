using Mariya.Data;
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
    public partial class Master : Form
    {
        SalonContext context;
        public Master()
        {
            context = new SalonContext();
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Master_Load(object sender, EventArgs e)
        {
            //dataGridView2.Rows.Add("111", "222");


            masterBindingSource.DataSource = context.Masters.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void masterBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = textBox1.Text;
            masterBindingSource.DataSource = context.Masters.Where(x => x.Surname.Contains(query)).ToList();
        }
    }
}

