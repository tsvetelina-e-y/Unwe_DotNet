namespace WindowsFormsApp1
{
    partial class frmDeadline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeadline));
            System.Windows.Forms.Label deadLineNameLabel;
            System.Windows.Forms.Label valueLabel;
            this.creditDataSet = new WindowsFormsApp1.CreditDataSet();
            this.deadLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deadLineTableAdapter = new WindowsFormsApp1.CreditDataSetTableAdapters.DeadLineTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.CreditDataSetTableAdapters.TableAdapterManager();
            this.deadLineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.deadLineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.deadLineNameTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            deadLineNameLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creditDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadLineBindingNavigator)).BeginInit();
            this.deadLineBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // creditDataSet
            // 
            this.creditDataSet.DataSetName = "CreditDataSet";
            this.creditDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deadLineBindingSource
            // 
            this.deadLineBindingSource.DataMember = "DeadLine";
            this.deadLineBindingSource.DataSource = this.creditDataSet;
            // 
            // deadLineTableAdapter
            // 
            this.deadLineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.CreditDataTableAdapter = null;
            this.tableAdapterManager.DeadLineTableAdapter = this.deadLineTableAdapter;
            this.tableAdapterManager.GuarantorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.CreditDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deadLineBindingNavigator
            // 
            this.deadLineBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.deadLineBindingNavigator.BindingSource = this.deadLineBindingSource;
            this.deadLineBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.deadLineBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.deadLineBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.deadLineBindingNavigatorSaveItem});
            this.deadLineBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.deadLineBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.deadLineBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.deadLineBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.deadLineBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.deadLineBindingNavigator.Name = "deadLineBindingNavigator";
            this.deadLineBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.deadLineBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.deadLineBindingNavigator.TabIndex = 0;
            this.deadLineBindingNavigator.Text = "bindingNavigator1";
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
            // deadLineBindingNavigatorSaveItem
            // 
            this.deadLineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deadLineBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("deadLineBindingNavigatorSaveItem.Image")));
            this.deadLineBindingNavigatorSaveItem.Name = "deadLineBindingNavigatorSaveItem";
            this.deadLineBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.deadLineBindingNavigatorSaveItem.Text = "Save Data";
            this.deadLineBindingNavigatorSaveItem.Click += new System.EventHandler(this.deadLineBindingNavigatorSaveItem_Click);
            // 
            // deadLineNameLabel
            // 
            deadLineNameLabel.AutoSize = true;
            deadLineNameLabel.Location = new System.Drawing.Point(46, 65);
            deadLineNameLabel.Name = "deadLineNameLabel";
            deadLineNameLabel.Size = new System.Drawing.Size(90, 13);
            deadLineNameLabel.TabIndex = 1;
            deadLineNameLabel.Text = "Dead Line Name:";
            // 
            // deadLineNameTextBox
            // 
            this.deadLineNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deadLineBindingSource, "DeadLineName", true));
            this.deadLineNameTextBox.Location = new System.Drawing.Point(142, 62);
            this.deadLineNameTextBox.Name = "deadLineNameTextBox";
            this.deadLineNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.deadLineNameTextBox.TabIndex = 2;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(46, 91);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(37, 13);
            valueLabel.TabIndex = 3;
            valueLabel.Text = "Value:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deadLineBindingSource, "Value", true));
            this.valueTextBox.Location = new System.Drawing.Point(142, 88);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 4;
            // 
            // frmDeadline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(deadLineNameLabel);
            this.Controls.Add(this.deadLineNameTextBox);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.deadLineBindingNavigator);
            this.Name = "frmDeadline";
            this.Text = "frmDeadline";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadLineBindingNavigator)).EndInit();
            this.deadLineBindingNavigator.ResumeLayout(false);
            this.deadLineBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CreditDataSet creditDataSet;
        private System.Windows.Forms.BindingSource deadLineBindingSource;
        private CreditDataSetTableAdapters.DeadLineTableAdapter deadLineTableAdapter;
        private CreditDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator deadLineBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton deadLineBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox deadLineNameTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
    }
}