using BeautySalonCRM;
using Mariya.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Mariya
{
    public partial class FormVisit : Form
    {
        SalonContext context;
        public FormVisit()
        {
            context = new SalonContext();
            InitializeComponent();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������: ���-133901 ; ���: ���������� ����� ���������");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddVisit();
            var dialogResult = form.ShowDialog();
            UpdateVisitBindingSource();
        }

        private void Visit_Load(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add("����������", "���������", "��������", "�������", "19:30", "19.20.2002");
            //dataGridView1.Rows.Add("��������", "���������", "�����", "����������� ������", "16:30", "19.20.2002");
            //dataGridView1.Rows.Add("������", "���������", "���", "�������", "12:30", "19.20.2002");

            context.Visits.Load();
            visitBindingSource.DataSource = context.Visits.Local.ToBindingList();

            context.Masters.Load();
            masterBindingSource.DataSource = context.Masters.Local.ToBindingList();

            context.Clients.Load();
            clientBindingSource.DataSource = context.Clients.Local.ToBindingList();

            context.Services.Load();
            serviceBindingSource.DataSource = context.Services.Local.ToBindingList();

            UpdateVisitBindingSource();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void UpdateVisitBindingSource()
        {
            var filteredVisits = context.Visits
            .Join(context.Masters,
           visit => visit.MasterId,
           master => master.Id,
           (visit, master) => new { visit, master })
            .Join(context.Clients,
           vm => vm.visit.ClientId,
           client => client.Id,
           (vm, client) => new { vm.visit, vm.master, client })
            .Join(context.Services,
           vmc => vmc.visit.ServiceId,
           service => service.Id,
           (vmc, service) => new
           {
               vmc.visit.Id,
               MasterSurname = vmc.master.Surname,
               ClientSurname = vmc.client.Surname,
               ServiceName = service.Name,
               vmc.visit.Time,
               vmc.visit.Status
           })
     .Where(v => (string.IsNullOrEmpty(textBoxMaster.Text) ||
                  v.MasterSurname.ToLower().Contains(textBoxMaster.Text) ||
                  v.ClientSurname.ToLower().Contains(textBoxMaster.Text) ||
                  v.ServiceName.ToLower().Contains(textBoxMaster.Text)))
     .ToList();

            foreach (var visit in filteredVisits)
            {
                Debug.WriteLine($"Visit ID: {visit.Id}, Master: {visit.MasterSurname}, Client: {visit.ClientSurname}, Service: {visit.ServiceName}");
            }

            string message = "Filtered Visits:\n";
            foreach (var visit in filteredVisits)
            {
                message += $"Visit ID: {visit.Id}, Master: {visit.MasterSurname}, Client: {visit.ClientSurname}, Service: {visit.ServiceName}\n";
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "��� ���������",
                DataPropertyName = "Id",
                Name = "Id"
            });

            var masterSurnameColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "������� �������",
                DataPropertyName = "MasterSurname",
                Name = "MasterSurname",
                DataSource = context.Masters.Select(m => m.Surname).ToList() // ��������� ��������
            };
            dataGridView1.Columns.Add(masterSurnameColumn);

            var clientSurnameColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "������� �������",
                DataPropertyName = "ClientSurname",
                Name = "ClientSurname",
                DataSource = context.Clients.Select(c => c.Surname).ToList() // ��������� ��������
            };
            dataGridView1.Columns.Add(clientSurnameColumn);

            var serviceNameColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "�������� ������",
                DataPropertyName = "ServiceName",
                Name = "ServiceName",
                DataSource = context.Services.Select(s => s.Name).ToList() // ��������� ��������
            };
            dataGridView1.Columns.Add(serviceNameColumn);

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "�����",
                DataPropertyName = "Time",
                Name = "Time"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "������",
                DataPropertyName = "Status",
                Name = "Status"
            });

            visitBindingSource.DataSource = filteredVisits;
            dataGridView1.DataSource = visitBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateVisitBindingSource();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Service();
            form.Show();

        }
        private void buttonMasterTable_Click(object sender, EventArgs e)
        {
            var form = new Master();
            form.Show();

        }
        private void buttonClientsTable_Click(object sender, EventArgs e)
        {
            var form = new FormClients();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormChart();
            form.Show();
        }
    }
}