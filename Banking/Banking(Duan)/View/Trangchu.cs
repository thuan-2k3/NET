using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking.View
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
            this.Resize += FormChiaPanel_Resize;
        }
        private void FormChiaPanel_Resize(object sender, EventArgs e)
        {
            // Tính toán kích thước font mới dựa trên chiều rộng của form
            float newFontSize = this.Width / 50f; // Bạn có thể điều chỉnh hệ số này

            // Cập nhật kích thước của TableLayoutPanel
            tableLayoutPanel1.Size = new Size(this.ClientSize.Width, tableLayoutPanel1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            panelTC.Controls.Clear();
            employee.Dock = DockStyle.Fill;
            panelTC.Controls.Add(employee);
            employee.Show();
        }

        private void panelTC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BranchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Branch branch = new Branch();
            panelTC.Controls.Clear();
            branch.Dock = DockStyle.Fill;
            panelTC.Controls.Add(branch);
            branch.Show();

        }

        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Customer create_Customer = new Create_Customer();
            panelTC.Controls.Clear();
            create_Customer.Dock = DockStyle.Fill;
            panelTC.Controls.Add(create_Customer);
            create_Customer.Show();
        }

        private void createAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create_Account create_Account = new Create_Account();
            panelTC.Controls.Clear();
            create_Account.Dock = DockStyle.Fill;
            panelTC.Controls.Add(create_Account);
            create_Account.Show();
        }

        private void depositAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void LoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            panelTC.Controls.Clear();
            login.Dock = DockStyle.Fill;
            panelTC.Controls.Add(login);
            login.Show();
        }

        private void withDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void balanceAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transactionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            panelTC.Controls.Clear();
            login.Dock = DockStyle.Fill;
            panelTC.Controls.Add(login);
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
    
}
