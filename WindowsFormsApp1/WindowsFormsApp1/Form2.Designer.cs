namespace WindowsFormsApp1
{
    partial class frmBorrower
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrower));
            System.Windows.Forms.Label eGNLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label mNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label homeAddressLabel;
            System.Windows.Forms.Label workAddressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label monthIncomeLabel;
            this.creditDataSet = new WindowsFormsApp1.CreditDataSet();
            this.borrowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowerTableAdapter = new WindowsFormsApp1.CreditDataSetTableAdapters.BorrowerTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.CreditDataSetTableAdapters.TableAdapterManager();
            this.borrowerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.borrowerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eGNTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.workAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.monthIncomeTextBox = new System.Windows.Forms.TextBox();
            eGNLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            mNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            homeAddressLabel = new System.Windows.Forms.Label();
            workAddressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            monthIncomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creditDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingNavigator)).BeginInit();
            this.borrowerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // creditDataSet
            // 
            this.creditDataSet.DataSetName = "CreditDataSet";
            this.creditDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowerBindingSource
            // 
            this.borrowerBindingSource.DataMember = "Borrower";
            this.borrowerBindingSource.DataSource = this.creditDataSet;
            // 
            // borrowerTableAdapter
            // 
            this.borrowerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BorrowerTableAdapter = this.borrowerTableAdapter;
            this.tableAdapterManager.CreditDataTableAdapter = null;
            this.tableAdapterManager.DeadLineTableAdapter = null;
            this.tableAdapterManager.GuarantorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.CreditDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // borrowerBindingNavigator
            // 
            this.borrowerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.borrowerBindingNavigator.BindingSource = this.borrowerBindingSource;
            this.borrowerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.borrowerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.borrowerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.borrowerBindingNavigatorSaveItem});
            this.borrowerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.borrowerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.borrowerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.borrowerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.borrowerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.borrowerBindingNavigator.Name = "borrowerBindingNavigator";
            this.borrowerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.borrowerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.borrowerBindingNavigator.TabIndex = 0;
            this.borrowerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // borrowerBindingNavigatorSaveItem
            // 
            this.borrowerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.borrowerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("borrowerBindingNavigatorSaveItem.Image")));
            this.borrowerBindingNavigatorSaveItem.Name = "borrowerBindingNavigatorSaveItem";
            this.borrowerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.borrowerBindingNavigatorSaveItem.Text = "Save Data";
            this.borrowerBindingNavigatorSaveItem.Click += new System.EventHandler(this.borrowerBindingNavigatorSaveItem_Click);
            // 
            // eGNLabel
            // 
            eGNLabel.AutoSize = true;
            eGNLabel.Location = new System.Drawing.Point(38, 75);
            eGNLabel.Name = "eGNLabel";
            eGNLabel.Size = new System.Drawing.Size(33, 13);
            eGNLabel.TabIndex = 1;
            eGNLabel.Text = "EGN:";
            // 
            // eGNTextBox
            // 
            this.eGNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "EGN", true));
            this.eGNTextBox.Location = new System.Drawing.Point(123, 72);
            this.eGNTextBox.Name = "eGNTextBox";
            this.eGNTextBox.Size = new System.Drawing.Size(100, 20);
            this.eGNTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(38, 101);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(123, 98);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // mNameLabel
            // 
            mNameLabel.AutoSize = true;
            mNameLabel.Location = new System.Drawing.Point(38, 127);
            mNameLabel.Name = "mNameLabel";
            mNameLabel.Size = new System.Drawing.Size(47, 13);
            mNameLabel.TabIndex = 5;
            mNameLabel.Text = "MName:";
            // 
            // mNameTextBox
            // 
            this.mNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "MName", true));
            this.mNameTextBox.Location = new System.Drawing.Point(123, 124);
            this.mNameTextBox.Name = "mNameTextBox";
            this.mNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.mNameTextBox.TabIndex = 6;
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(38, 153);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(44, 13);
            lNameLabel.TabIndex = 7;
            lNameLabel.Text = "LName:";
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "LName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(123, 150);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lNameTextBox.TabIndex = 8;
            // 
            // homeAddressLabel
            // 
            homeAddressLabel.AutoSize = true;
            homeAddressLabel.Location = new System.Drawing.Point(38, 179);
            homeAddressLabel.Name = "homeAddressLabel";
            homeAddressLabel.Size = new System.Drawing.Size(79, 13);
            homeAddressLabel.TabIndex = 9;
            homeAddressLabel.Text = "Home Address:";
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "HomeAddress", true));
            this.homeAddressTextBox.Location = new System.Drawing.Point(123, 176);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeAddressTextBox.TabIndex = 10;
            // 
            // workAddressLabel
            // 
            workAddressLabel.AutoSize = true;
            workAddressLabel.Location = new System.Drawing.Point(38, 205);
            workAddressLabel.Name = "workAddressLabel";
            workAddressLabel.Size = new System.Drawing.Size(77, 13);
            workAddressLabel.TabIndex = 11;
            workAddressLabel.Text = "Work Address:";
            // 
            // workAddressTextBox
            // 
            this.workAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "WorkAddress", true));
            this.workAddressTextBox.Location = new System.Drawing.Point(123, 202);
            this.workAddressTextBox.Name = "workAddressTextBox";
            this.workAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.workAddressTextBox.TabIndex = 12;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(38, 231);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(123, 228);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 14;
            // 
            // monthIncomeLabel
            // 
            monthIncomeLabel.AutoSize = true;
            monthIncomeLabel.Location = new System.Drawing.Point(38, 257);
            monthIncomeLabel.Name = "monthIncomeLabel";
            monthIncomeLabel.Size = new System.Drawing.Size(78, 13);
            monthIncomeLabel.TabIndex = 15;
            monthIncomeLabel.Text = "Month Income:";
            // 
            // monthIncomeTextBox
            // 
            this.monthIncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "MonthIncome", true));
            this.monthIncomeTextBox.Location = new System.Drawing.Point(123, 254);
            this.monthIncomeTextBox.Name = "monthIncomeTextBox";
            this.monthIncomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthIncomeTextBox.TabIndex = 16;
            // 
            // frmBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(eGNLabel);
            this.Controls.Add(this.eGNTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(mNameLabel);
            this.Controls.Add(this.mNameTextBox);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(homeAddressLabel);
            this.Controls.Add(this.homeAddressTextBox);
            this.Controls.Add(workAddressLabel);
            this.Controls.Add(this.workAddressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(monthIncomeLabel);
            this.Controls.Add(this.monthIncomeTextBox);
            this.Controls.Add(this.borrowerBindingNavigator);
            this.Name = "frmBorrower";
            this.Text = "frmBorrower";
            this.Load += new System.EventHandler(this.frmBorrowe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingNavigator)).EndInit();
            this.borrowerBindingNavigator.ResumeLayout(false);
            this.borrowerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CreditDataSet creditDataSet;
        private System.Windows.Forms.BindingSource borrowerBindingSource;
        private CreditDataSetTableAdapters.BorrowerTableAdapter borrowerTableAdapter;
        private CreditDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator borrowerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton borrowerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox eGNTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox mNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox workAddressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox monthIncomeTextBox;
    }
}