namespace EmployeeUI
{
    partial class XtraDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraDepartment));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            colStatusChange = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonStatusChange = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtDepartmentName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            txtDeptName = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonStatusChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDepartmentName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDeptName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gridControl1);
            layoutControl1.Controls.Add(btnClose);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(txtDepartmentName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Margin = new Padding(4, 3, 4, 3);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(974, 513);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            gridControl1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gridControl1.Location = new Point(12, 122);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryBtnDelete, repositoryBtnEdit, repositoryButtonStatusChange });
            gridControl1.Size = new Size(950, 368);
            gridControl1.TabIndex = 7;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colStatus, colStatusChange, colEdit, colDelete });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colId
            // 
            colId.Caption = "#";
            colId.FieldName = "Id";
            colId.MinWidth = 25;
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.OptionsColumn.ReadOnly = true;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            colId.Width = 94;
            // 
            // colName
            // 
            colName.Caption = "Bölüm Adı";
            colName.FieldName = "Name";
            colName.MinWidth = 25;
            colName.Name = "colName";
            colName.OptionsColumn.AllowEdit = false;
            colName.OptionsColumn.ReadOnly = true;
            colName.Visible = true;
            colName.VisibleIndex = 1;
            colName.Width = 94;
            // 
            // colStatus
            // 
            colStatus.Caption = "Durum";
            colStatus.FieldName = "Status";
            colStatus.MinWidth = 25;
            colStatus.Name = "colStatus";
            colStatus.OptionsColumn.AllowEdit = false;
            colStatus.OptionsColumn.ReadOnly = true;
            colStatus.Visible = true;
            colStatus.VisibleIndex = 2;
            colStatus.Width = 94;
            // 
            // colEdit
            // 
            colEdit.Caption = "Güncelle";
            colEdit.ColumnEdit = repositoryBtnEdit;
            colEdit.MinWidth = 25;
            colEdit.Name = "colEdit";
            colEdit.Visible = true;
            colEdit.VisibleIndex = 4;
            colEdit.Width = 94;
            // 
            // repositoryBtnEdit
            // 
            repositoryBtnEdit.AutoHeight = false;
            repositoryBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo) });
            repositoryBtnEdit.Name = "repositoryBtnEdit";
            repositoryBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnEdit.Click += repositoryBtnEdit_Click;
            // 
            // colDelete
            // 
            colDelete.Caption = "Sil";
            colDelete.ColumnEdit = repositoryBtnDelete;
            colDelete.MinWidth = 25;
            colDelete.Name = "colDelete";
            colDelete.Visible = true;
            colDelete.VisibleIndex = 5;
            colDelete.Width = 94;
            // 
            // repositoryBtnDelete
            // 
            repositoryBtnDelete.AutoHeight = false;
            repositoryBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            repositoryBtnDelete.Name = "repositoryBtnDelete";
            repositoryBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnDelete.Click += repositoryBtnDelete_Click;
            // 
            // colStatusChange
            // 
            colStatusChange.Caption = "Durumu Değiştir";
            colStatusChange.ColumnEdit = repositoryButtonStatusChange;
            colStatusChange.MinWidth = 25;
            colStatusChange.Name = "colStatusChange";
            colStatusChange.Visible = true;
            colStatusChange.VisibleIndex = 3;
            colStatusChange.Width = 94;
            // 
            // repositoryButtonStatusChange
            // 
            repositoryButtonStatusChange.AutoHeight = false;
            repositoryButtonStatusChange.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK) });
            repositoryButtonStatusChange.Name = "repositoryButtonStatusChange";
            repositoryButtonStatusChange.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryButtonStatusChange.ButtonClick += repositoryButtonStatusChange_ButtonClick;
            // 
            // btnClose
            // 
            btnClose.Appearance.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnClose.Appearance.Options.UseFont = true;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new Point(12, 82);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(950, 36);
            btnClose.StyleController = layoutControl1;
            btnClose.TabIndex = 6;
            btnClose.Text = "Kapat";
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.Location = new Point(12, 42);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(950, 36);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 5;
            btnSave.Text = "Kaydet";
            btnSave.Click += btnSave_Click;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(98, 12);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Properties.Appearance.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDepartmentName.Properties.Appearance.Options.UseFont = true;
            txtDepartmentName.Size = new Size(864, 26);
            txtDepartmentName.StyleController = layoutControl1;
            txtDepartmentName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { txtDeptName, emptySpaceItem1, layoutControlItem1, layoutControlItem2, layoutControlItem3 });
            Root.Name = "Root";
            Root.Size = new Size(974, 513);
            Root.TextVisible = false;
            // 
            // txtDeptName
            // 
            txtDeptName.AppearanceItemCaption.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDeptName.AppearanceItemCaption.Options.UseFont = true;
            txtDeptName.Control = txtDepartmentName;
            txtDeptName.Location = new Point(0, 0);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(954, 30);
            txtDeptName.Text = "Bölüm Adı";
            txtDeptName.TextSize = new Size(74, 19);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new Point(0, 482);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(954, 11);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = btnSave;
            layoutControlItem1.Location = new Point(0, 30);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(954, 40);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnClose;
            layoutControlItem2.Location = new Point(0, 70);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(954, 40);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = gridControl1;
            layoutControlItem3.Location = new Point(0, 110);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(954, 372);
            layoutControlItem3.TextVisible = false;
            // 
            // XtraDepartment
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 513);
            Controls.Add(layoutControl1);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            IconOptions.LargeImage = (Image)resources.GetObject("XtraDepartment.IconOptions.LargeImage");
            Margin = new Padding(4, 3, 4, 3);
            Name = "XtraDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bölümler";
            Load += XtraDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonStatusChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDepartmentName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDeptName).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtDepartmentName;
        private DevExpress.XtraLayout.LayoutControlItem txtDeptName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusChange;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonStatusChange;
    }
}