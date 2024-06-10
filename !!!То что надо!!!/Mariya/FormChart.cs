using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mariya.Data;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace BeautySalonCRM
{
    public partial class FormChart : Form
    {
        SalonContext context;
        public FormChart()
        {
            context = new SalonContext();
            InitializeComponent();
        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {

            var clients = context.Clients.ToList();
            var clientsSurname = clients.Select(X => X.Surname).ToList();

            cartesianChart1.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = clientsSurname
                }
            };

            var values = new double[clientsSurname.Count];
            for (int i = 0; i < clientsSurname.Count; i++)
            {

                var count = context.Visits.Count(x => x.ClientId == clients[i].Id);

                values[i] = count;
            }


            cartesianChart1.Series = new ISeries[]
           {

                    new ColumnSeries<double>
                {
                    Values = values
                }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
