using Banking.Controller;
using Banking.Model;
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
    public partial class Create_Customer : UserControl, IView
    {
        CustomerController controller = new CustomerController();

        public Create_Customer()
        {
            InitializeComponent();
            LoadDataGrid();
            dataGridViewcus.CellClick += DataGridViewcus_CellClick;

            this.Resize += (s, e) =>
            {
                // Căn giữa Panel trong Form
                panel1.Location = new Point((this.ClientSize.Width - panel1.Width) / 2,
                                                (this.ClientSize.Height - panel1.Height) / 2);
            };
        }

        public void GetDataFromText()
        {
            CustomerModel customer = new CustomerModel
            {
                id = textcusid.Text,
                name = textcustenkh.Text,
                phone = textcussdt.Text,
                email = textcusemail.Text,
                house_no = textcusdc.Text,
                city = textcustp.Text,
                pin = textcuspass.Text
            };

            controller.Add(customer); // Thêm khách hàng mới vào database
            controller.Update(customer); // Cập nhật thông tin khách hàng (nếu cần)
        }
        public void SetDataToText(object item)
        {
            if (item is CustomerModel customer)
            {
                textcusid.Text = customer.id;
                textcustenkh.Text = customer.name;
                textcussdt.Text = customer.phone;
                textcusemail.Text = customer.email;
                textcusdc.Text = customer.house_no;
                textcustp.Text = customer.city;
                textcuspass.Text = customer.pin;
            }
            else
            {
                throw new ArgumentException("Item must be of type CustomerModel");
            }
        }
        public void ClearFields()
        {
            textcusid.Clear();
            textcustenkh.Clear();
            textcussdt.Clear();
            textcusemail.Clear();
            textcusdc.Clear();
            textcustp.Clear();
            textcuspass.Clear();
        }



        private void LoadDataGrid()
            {
                if (controller.Load())
                {
                    List<IModel > item = controller.Items;
                dataGridViewcus.DataSource = item.Cast<CustomerModel> ().ToList();

                    //if (list.Count > 0)
                    //{
                    //    dataGridViewcus.DataSource = list;
                    //    dataGridViewcus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("No customer data found.");
                    //}
                }
                else
                {
                    MessageBox.Show("Failed to load customer data.");
                }
            }

            private void DataGridViewcus_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewcus.Rows[e.RowIndex];
                    textcustenkh.Text = row.Cells["id"].Value?.ToString();
                    textcusemail.Text = row.Cells["name"].Value?.ToString();
                    textcusdc.Text = row.Cells["phone"].Value?.ToString();
                    textcustp.Text = row.Cells["email"].Value?.ToString();
                    textcussdt.Text = row.Cells["house_no"].Value?.ToString();
                    textcuspass.Text = row.Cells["city"].Value?.ToString();
                }
            }

            private void Save_Click(object sender, EventArgs e)
            {
                CustomerModel customer = new CustomerModel
                {
                    id = textcustenkh.Text,
                    name = textcusemail.Text,
                    phone = textcusdc.Text,
                    email = textcustp.Text,
                    house_no = textcussdt.Text,
                    city = textcuspass.Text,
                    pin = "1234"  // Set a default or retrieved value for PIN
                };

                if (controller.IsExist(customer.id))
                {
                    controller.Update(customer);
                    MessageBox.Show("Customer updated successfully.");
                }
                else
                {
                    controller.Add(customer);
                    MessageBox.Show("New customer added successfully.");
                }

                LoadDataGrid();
            }

            private void Delete_Click(object sender, EventArgs e)
            {
                string id = textcustenkh.Text;
                if (controller.IsExist(id))
                {
                    controller.Delete(id);
                    MessageBox.Show("Customer deleted successfully.");
                    LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }

        private void close_Click(object sender, EventArgs e)
        {
            
                Trangchu mainForm = (Trangchu)this.ParentForm;
                mainForm.Show();
                this.Dispose();
           
        }

        private void save_Click_1(object sender, EventArgs e)
        {
            Save_Click(sender, e);
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            Delete_Click(sender, e);
        }
    }
    }


