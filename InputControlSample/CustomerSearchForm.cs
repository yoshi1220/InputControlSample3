using InputControlSample.Repositories;
using InputControlSample.Services;
using System;
using System.Windows.Forms;

namespace InputControlSample
{
    public partial class CustomerSearchForm : Form
    {

        private ICustomerService _customerService;

        public string CustomerId { get; private set; }
        public string CustomerName { get; private set; }


        public CustomerSearchForm()
        {
            InitializeComponent();

            _customerService = new CustomerService(new CustomerRepositoryDapper());
        }


        private void CustomerSearchForm_Load(object sender, EventArgs e)
        {
            this.customerListGrid.DataSource = _customerService.GetAll();
        }

        /// <summary>
        /// Gridの初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerListGrid_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;    // セルクリックで行を選択する
        }

        /// <summary>
        /// ダブルクリックで選択されたデータをプロパティに設定し、画面を閉じる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerListGrid_DoubleClickCell(object sender, Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs e)
        {
            //外枠などのクリックが検知された場合は、処理を中断する
            if (e.Cell.Row.Index < 0)
            {
                return;
            }


            CustomerId = this.customerListGrid.Rows[e.Cell.Row.Index].Cells[0].Value.ToString();
            CustomerName = this.customerListGrid.Rows[e.Cell.Row.Index].Cells[1].Value.ToString();

            if (!string.IsNullOrWhiteSpace(CustomerId))
            {
                this.Close();
            }

        }
    }
}
