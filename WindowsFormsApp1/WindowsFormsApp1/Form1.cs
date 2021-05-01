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
    public partial class frmCredit : Form
    {
        public frmCredit()
        {
            InitializeComponent();
        }


        private void creditDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.creditDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.creditDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'creditDataSet.CreditData' table. You can move, or remove it, as needed.
            this.creditDataTableAdapter.Fill(this.creditDataSet.CreditData);

        }

        private void secondToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeadline formDeadline = new frmDeadline();
            formDeadline.MdiParent = this;
            formDeadline.Show();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCredit formCredit = new frmCredit();
            formCredit.MdiParent = this;
            formCredit.Show();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrower formBorrower = new frmBorrower();
            formBorrower.MdiParent = this;
            formBorrower.Show();
        }

        private void guarantorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGuarantor formGuarantor = new frmGuarantor();
            formGuarantor.MdiParent = this;
            formGuarantor.Show();
        }

        private void deadlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeadline formDeadline = new frmDeadline();
            formDeadline.MdiParent = this;
            formDeadline.Show();
        }
    }
}
