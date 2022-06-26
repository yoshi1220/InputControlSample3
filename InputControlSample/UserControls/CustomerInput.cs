using InputControlSample.Repositories;
using InputControlSample.Services;
using System;
using System.Windows.Forms;

namespace InputControlSample.UserControls
{
    public partial class CustomerInput : UserControl
    {


        public CustomerInput()
        {
            InitializeComponent();

        }

        private void CustomerSearchButton_Click(object sender, EventArgs e)
        {
            var customerSearchForm = new CustomerSearchForm();
            customerSearchForm.ShowDialog();

            this.CustomerIdText.Text = customerSearchForm.CustomerId;
            this.CustomerNameLabel.Text = customerSearchForm.CustomerName;
        }



        private void CustomerIdText_Validated(object sender, EventArgs e)
        {
            //データを検索して、該当すれば名称を表示する
            var customerService = new CustomerService(new CustomerRepositoryDapper());
            var customer = customerService.Get(this.CustomerIdText.Text);

            if (customer != null)
            {
                this.CustomerNameLabel.Text = customer.CompanyName;
            }
        }
    }
}
