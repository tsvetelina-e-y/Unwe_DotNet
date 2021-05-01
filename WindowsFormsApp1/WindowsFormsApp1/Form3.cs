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
    public partial class frmGuarantor : Form
    {
        public frmGuarantor()
        {
            InitializeComponent();
        }

        private void guarantorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.guarantorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.creditDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'creditDataSet.Guarantor' table. You can move, or remove it, as needed.
            this.guarantorTableAdapter.Fill(this.creditDataSet.Guarantor);

        }
    }
}
