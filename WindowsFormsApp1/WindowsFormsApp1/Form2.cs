using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBorrower : Form
    {
        public frmBorrower()
        {
            InitializeComponent();
        }

        private void borrowerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.borrowerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.creditDataSet);

        }

        private void frmBorrowe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'creditDataSet.Borrower' table. You can move, or remove it, as needed.
            this.borrowerTableAdapter.Fill(this.creditDataSet.Borrower);

        }
    }
}
