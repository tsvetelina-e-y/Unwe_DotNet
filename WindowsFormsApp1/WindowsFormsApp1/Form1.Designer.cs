namespace WindowsFormsApp1
{
    partial class frmCredit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guarantorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(696, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowerToolStripMenuItem,
            this.guarantorToolStripMenuItem,
            this.deadlineToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "menu";
            // 
            // borrowerToolStripMenuItem
            // 
            this.borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrowerToolStripMenuItem.Text = "borrower";
            this.borrowerToolStripMenuItem.Click += new System.EventHandler(this.borrowerToolStripMenuItem_Click);
            // 
            // guarantorToolStripMenuItem
            // 
            this.guarantorToolStripMenuItem.Name = "guarantorToolStripMenuItem";
            this.guarantorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guarantorToolStripMenuItem.Text = "guarantor";
            this.guarantorToolStripMenuItem.Click += new System.EventHandler(this.guarantorToolStripMenuItem_Click);
            // 
            // deadlineToolStripMenuItem
            // 
            this.deadlineToolStripMenuItem.Name = "deadlineToolStripMenuItem";
            this.deadlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deadlineToolStripMenuItem.Text = "deadline";
            this.deadlineToolStripMenuItem.Click += new System.EventHandler(this.deadlineToolStripMenuItem_Click);
            // 
            // frmCredit
            // 
            this.ClientSize = new System.Drawing.Size(696, 317);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "frmCredit";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private CreditDataSet creditDataSet;
        private System.Windows.Forms.BindingSource creditDataBindingSource;
        private CreditDataSetTableAdapters.CreditDataTableAdapter creditDataTableAdapter;
        private CreditDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator creditDataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton creditDataBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox borrowerIDTextBox;
        private System.Windows.Forms.TextBox guarantorIDTextBox;
        private System.Windows.Forms.TextBox deadLineTextBox;
        private System.Windows.Forms.TextBox monthlyInterestTextBox;
        private System.Windows.Forms.TextBox costOfCreditTextBox;
        private System.Windows.Forms.TextBox currencyTextBox;
        private System.Windows.Forms.TextBox monthlyTaxesTextBox;
        private System.Windows.Forms.TextBox defaultInterestTextBox;
        private System.Windows.Forms.TextBox annualPersentageRateTextBox;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guarantorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadlineToolStripMenuItem;
    }
}

