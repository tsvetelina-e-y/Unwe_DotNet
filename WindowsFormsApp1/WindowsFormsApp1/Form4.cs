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
    public partial class frmDeadline : Form
    {
        public frmDeadline()
        {
            InitializeComponent();
        }

        private void deadLineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deadLineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.creditDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'creditDataSet.DeadLine' table. You can move, or remove it, as needed.
            this.deadLineTableAdapter.Fill(this.creditDataSet.DeadLine);

        }
    }
}
