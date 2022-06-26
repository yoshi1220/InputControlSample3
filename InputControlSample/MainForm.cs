using System;
using System.Windows.Forms;

namespace InputControlSample
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
