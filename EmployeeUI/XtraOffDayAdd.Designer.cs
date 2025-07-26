namespace EmployeeUI
{
    partial class XtraOffDayAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraOffDayAdd));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            searchEmployeeList = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtEndDate = new DevExpress.XtraEditors.TextEdit();
            txtStartDate = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            txtEmployeList = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchEmployeeList.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEndDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(searchEmployeeList);
            layoutControl1.Controls.Add(btnClose);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(txtEndDate);
            layoutControl1.Controls.Add(txtStartDate);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(612, 210);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // searchEmployeeList
            // 
            searchEmployeeList.Location = new Point(138, 12);
            searchEmployeeList.Name = "searchEmployeeList";
            searchEmployeeList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            searchEmployeeList.Properties.PopupView = searchLookUpEdit1View;
            searchEmployeeList.Size = new Size(462, 22);
            searchEmployeeList.StyleController = layoutControl1;
            searchEmployeeList.TabIndex = 8;
            searchEmployeeList.EditValueChanged += searchEmployeeList_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnClose
            // 
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new Point(12, 104);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(588, 36);
            btnClose.StyleController = layoutControl1;
            btnClose.TabIndex = 7;
            btnClose.Text = "Kapat";
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.Location = new Point(12, 64);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(588, 36);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.Click += btnSave_Click;
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new Point(447, 38);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(153, 22);
            txtEndDate.StyleController = layoutControl1;
            txtEndDate.TabIndex = 5;
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(138, 38);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(179, 22);
            txtStartDate.StyleController = layoutControl1;
            txtStartDate.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem3, layoutControlItem4, txtEmployeList, layoutControlItem2 });
            Root.Name = "Root";
            Root.Size = new Size(612, 210);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtStartDate;
            layoutControlItem1.Location = new Point(0, 26);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(309, 26);
            layoutControlItem1.Text = "İzin Başlangıç Tarihi";
            layoutControlItem1.TextSize = new Size(114, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new Point(0, 132);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(592, 58);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnSave;
            layoutControlItem3.Location = new Point(0, 52);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(592, 40);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnClose;
            layoutControlItem4.Location = new Point(0, 92);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(592, 40);
            layoutControlItem4.TextVisible = false;
            // 
            // txtEmployeList
            // 
            txtEmployeList.Control = searchEmployeeList;
            txtEmployeList.Location = new Point(0, 0);
            txtEmployeList.Name = "txtEmployeList";
            txtEmployeList.Size = new Size(592, 26);
            txtEmployeList.Text = "Personel";
            txtEmployeList.TextSize = new Size(114, 16);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtEndDate;
            layoutControlItem2.Location = new Point(309, 26);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(283, 26);
            layoutControlItem2.Text = "İzin Bitiş Tarihi";
            layoutControlItem2.TextSize = new Size(114, 16);
            // 
            // XtraOffDayAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 210);
            Controls.Add(layoutControl1);
            Name = "XtraOffDayAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel İzinleri Kayıt Formu";
            Load += XtraOffDayAdd_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)searchEmployeeList.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEndDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmployeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtEndDate;
        private DevExpress.XtraEditors.TextEdit txtStartDate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SearchLookUpEdit searchEmployeeList;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem txtEmployeList;
    }
}