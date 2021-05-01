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
    public partial class frmDeadLineList : Form
    {
        public frmDeadLineList()
        {
            InitializeComponent();
        }

        private void deadLineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deadLineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.creditDataSet);

        }

        private void frmDeadLineList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'creditDataSet.DeadLine' table. You can move, or remove it, as needed.
            this.deadLineTableAdapter.Fill(this.creditDataSet.DeadLine);

        }

        private void deadLineDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex <= 0 && e.ColumnIndex == deadLineDataGridView.Columns["Delete"].Index)
            {
                this.deadLineTableAdapter.DeleteQuery(Convert.ToInt32(deadLineDataGridView.Rows[e.RowIndex].Cells[0].Value));
                this.deadLineTableAdapter.Fill(this.creditDataSet.DeadLine);
            }
        }
    }
}
