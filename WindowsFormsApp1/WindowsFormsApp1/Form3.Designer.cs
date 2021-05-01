namespace WindowsFormsApp1
{
    partial class frmGuarantor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuarantor));
            System.Windows.Forms.Label eGNLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label mNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label homeAddressLabel;
            System.Windows.Forms.Label workAddressLabel;
            System.Windows.Forms.Label phoneLabel;
            this.creditDataSet = new WindowsFormsApp1.CreditDataSet();
            this.guarantorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guarantorTableAdapter = new WindowsFormsApp1.CreditDataSetTableAdapters.GuarantorTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.CreditDataSetTableAdapters.TableAdapterManager();
            this.guarantorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.guarantorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eGNTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.workAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            eGNLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            mNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            homeAddressLabel = new System.Windows.Forms.Label();
            workAddressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creditDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guarantorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guarantorBindingNavigator)).BeginInit();
            this.guarantorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // creditDataSet
            // 
            this.creditDataSet.DataSetName = "CreditDataSet";
            this.creditDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guarantorBindingSource
            // 
            this.guarantorBindingSource.DataMember = "Guarantor";
            this.guarantorBindingSource.DataSource = this.creditDataSet;
            // 
            // guarantorTableAdapter
            // 
            this.guarantorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.CreditDataTableAdapter = null;
            this.tableAdapterManager.DeadLineTableAdapter = null;
            this.tableAdapterManager.GuarantorTableAdapter = this.guarantorTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.CreditDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // guarantorBindingNavigator
            // 
            this.guarantorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.guarantorBindingNavigator.BindingSource = this.guarantorBindingSource;
            this.guarantorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.guarantorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.guarantorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.guarantorBindingNavigatorSaveItem});
            this.guarantorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.guarantorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.guarantorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.guarantorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.guarantorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.guarantorBindingNavigator.Name = "guarantorBindingNavigator";
            this.guarantorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.guarantorBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.guarantorBindingNavigator.TabIndex = 0;
            this.guarantorBindingNavigator.Text = "bindingNavigator1";
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
            // guarantorBindingNavigatorSaveItem
            // 
            this.guarantorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guarantorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("guarantorBindingNavigatorSaveItem.Image")));
            this.guarantorBindingNavigatorSaveItem.Name = "guarantorBindingNavigatorSaveItem";
            this.guarantorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.guarantorBindingNavigatorSaveItem.Text = "Save Data";
            this.guarantorBindingNavigatorSaveItem.Click += new System.EventHandler(this.guarantorBindingNavigatorSaveItem_Click);
            // 
            // eGNLabel
            // 
            eGNLabel.AutoSize = true;
            eGNLabel.Location = new System.Drawing.Point(37, 61);
            eGNLabel.Name = "eGNLabel";
            eGNLabel.Size = new System.Drawing.Size(33, 13);
            eGNLabel.TabIndex = 1;
            eGNLabel.Text = "EGN:";
            // 
            // eGNTextBox
            // 
            this.eGNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guarantorBindingSource, "EGN", true));
            this.eGNTextBox.Location = new System.Drawing.Point(122, 58);
            this.eGNTextBox.Name = "eGNTextBox";
            this.eGNTextBox.Size = new System.Drawing.Size(100, 20);
            this.eGNTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(37, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guarantorBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(122, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // mNameLabel
            // 
            mNameLabel.AutoSize = true;
            mNameLabel.Location = new System.Drawing.Point(37, 113);
            mNameLabel.Name = "mNameLabel";
            mNameLabel.Size = new System.Drawing.Size(47, 13);
            mNameLabel.TabIndex = 5;
            mNameLabel.Text = "MName:";
            // 
            // mNameTextBox
            // 
            this.mNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guarantorBindingSource, "MName", true));
            this.mNameTextBox.Location = new System.Drawing.Point(122, 110);
            this.mNameTextBox.Name = "mNameTextBox";
            this.mNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.mNameTextBox.TabIndex = 6;
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(37, 139);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(44, 13);
            lNameLabel.TabIndex = 7;
            lNameLabel.Text = "LName:";
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guarantorBindingSource, "LName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(122, 136);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lNameTextBox.TabIndex = 8;
            // 
            // homeAddressLabel
            // 
            homeAddressLabel.AutoSize = true;
            homeAddressLabel.Location = new System.Drawing.Point(37, 165);
            homeAddressLabel.Name = "homeAddressLabel";
            homeAddressLabel.Size = new System.Drawing.Size(79, 13);
            homeAddressLabel.TabIndex = 9;
            homeAddressLabel.Text = "Home Address:";
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guarantorBindingSource, "HomeAddress", true));
            this.homeAddressTextBox.Location = new System.Drawing.Point(122, 162);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeAddressTextBox.TabIndex = 10;
            // 
            // workAddressLabel
            // 
            workAddressLabel.AutoSize = true;
            workAddressLabel.Location = new System.Drawing.Point(37, 191);
            workAddressLabel.Name = "workAddressLabel";
            workAddressLabel.Size = new System.Drawing.Size(77, 13);
            workAddressLabel.TabIndex = 11;
            workAddressLabel.Text = "Work Address:";
            // 
            // workAddressTextBox
            // 
            this.workAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guarantorBindingSource, "WorkAddress", true));
            this.workAddressTextBox.Location = new System.Drawing.Point(122, 188);
            this.workAddressTextBox.Name = "workAddressTextBox";
            this.workAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.workAddressTextBox.TabIndex = 12;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(37, 217);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guarantorBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(122, 214);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 14;
            // 
            // frmGuarantor
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
            this.Controls.Add(this.guarantorBindingNavigator);
            this.Name = "frmGuarantor";
            this.Text = "frmGuarantor";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guarantorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guarantorBindingNavigator)).EndInit();
            this.guarantorBindingNavigator.ResumeLayout(false);
            this.guarantorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CreditDataSet creditDataSet;
        private System.Windows.Forms.BindingSource guarantorBindingSource;
        private CreditDataSetTableAdapters.GuarantorTableAdapter guarantorTableAdapter;
        private CreditDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator guarantorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton guarantorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox eGNTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox mNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox workAddressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
    }
}