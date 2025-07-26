namespace EmployeeUI
{
    partial class XtraEmployeeAdd
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraEmployeeAdd));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnAddEmployee = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtIdentityNum = new DevExpress.XtraEditors.TextEdit();
            txtDept = new DevExpress.XtraEditors.ComboBoxEdit();
            txtStartingDate = new DevExpress.XtraEditors.DateEdit();
            txtSalary = new DevExpress.XtraEditors.TextEdit();
            txtBirthDate = new DevExpress.XtraEditors.DateEdit();
            txtLastName = new DevExpress.XtraEditors.TextEdit();
            txtName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            txtIdentityNumber = new DevExpress.XtraLayout.LayoutControlItem();
            bar3 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtIdentityNum.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDept.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIdentityNumber).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnClose, barButtonItem1, btnAddEmployee });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAddEmployee), new DevExpress.XtraBars.LinkPersistInfo(btnClose) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Caption = "Personel Ekle";
            btnAddEmployee.Id = 2;
            btnAddEmployee.ImageOptions.Image = (Image)resources.GetObject("btnAddEmployee.ImageOptions.Image");
            btnAddEmployee.ImageOptions.LargeImage = (Image)resources.GetObject("btnAddEmployee.ImageOptions.LargeImage");
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnAddEmployee.ItemClick += btnAddEmployee_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Kapat";
            btnClose.Id = 0;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.LargeImage = (Image)resources.GetObject("btnClose.ImageOptions.LargeImage");
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnClose.ItemClick += btnClose_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(672, 30);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 254);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(672, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 30);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 224);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(672, 30);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 224);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 1;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtIdentityNum);
            layoutControl1.Controls.Add(txtDept);
            layoutControl1.Controls.Add(txtStartingDate);
            layoutControl1.Controls.Add(txtSalary);
            layoutControl1.Controls.Add(txtBirthDate);
            layoutControl1.Controls.Add(txtLastName);
            layoutControl1.Controls.Add(txtName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 30);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(672, 224);
            layoutControl1.TabIndex = 4;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtIdentityNum
            // 
            txtIdentityNum.Location = new Point(130, 168);
            txtIdentityNum.MenuManager = barManager1;
            txtIdentityNum.Name = "txtIdentityNum";
            txtIdentityNum.Properties.MaxLength = 11;
            txtIdentityNum.Size = new Size(530, 22);
            txtIdentityNum.StyleController = layoutControl1;
            txtIdentityNum.TabIndex = 10;
            txtIdentityNum.EditValueChanged += txtIdentityNum_EditValueChanged;
            // 
            // txtDept
            // 
            txtDept.Location = new Point(130, 142);
            txtDept.MenuManager = barManager1;
            txtDept.Name = "txtDept";
            txtDept.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDept.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            txtDept.Size = new Size(530, 22);
            txtDept.StyleController = layoutControl1;
            txtDept.TabIndex = 9;
            txtDept.SelectedIndexChanged += txtDept_SelectedIndexChanged;
            // 
            // txtStartingDate
            // 
            txtStartingDate.EditValue = null;
            txtStartingDate.Location = new Point(130, 116);
            txtStartingDate.MenuManager = barManager1;
            txtStartingDate.Name = "txtStartingDate";
            txtStartingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtStartingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtStartingDate.Size = new Size(530, 22);
            txtStartingDate.StyleController = layoutControl1;
            txtStartingDate.TabIndex = 8;
            // 
            // txtSalary
            // 
            txtSalary.EditValue = "0";
            txtSalary.Location = new Point(130, 90);
            txtSalary.MenuManager = barManager1;
            txtSalary.Name = "txtSalary";
            txtSalary.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtSalary.Properties.MaskSettings.Set("mask", "c");
            txtSalary.Properties.UseMaskAsDisplayFormat = true;
            txtSalary.Size = new Size(530, 22);
            txtSalary.StyleController = layoutControl1;
            txtSalary.TabIndex = 7;
            txtSalary.Enter += txtSalary_Enter;
            // 
            // txtBirthDate
            // 
            txtBirthDate.EditValue = null;
            txtBirthDate.Location = new Point(130, 64);
            txtBirthDate.MenuManager = barManager1;
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirthDate.Size = new Size(530, 22);
            txtBirthDate.StyleController = layoutControl1;
            txtBirthDate.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(130, 38);
            txtLastName.MenuManager = barManager1;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(530, 22);
            txtLastName.StyleController = layoutControl1;
            txtLastName.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 12);
            txtName.MenuManager = barManager1;
            txtName.Name = "txtName";
            txtName.Size = new Size(530, 22);
            txtName.StyleController = layoutControl1;
            txtName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, txtIdentityNumber });
            Root.Name = "Root";
            Root.Size = new Size(672, 224);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtName;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(652, 26);
            layoutControlItem1.Text = "Personel Adı";
            layoutControlItem1.TextSize = new Size(106, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new Point(0, 182);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(652, 22);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtLastName;
            layoutControlItem2.Location = new Point(0, 26);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(652, 26);
            layoutControlItem2.Text = "Personel Soyadı";
            layoutControlItem2.TextSize = new Size(106, 16);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtBirthDate;
            layoutControlItem3.Location = new Point(0, 52);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(652, 26);
            layoutControlItem3.Text = "Doğum Tarihi";
            layoutControlItem3.TextSize = new Size(106, 16);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtSalary;
            layoutControlItem4.Location = new Point(0, 78);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(652, 26);
            layoutControlItem4.Text = "Maaş";
            layoutControlItem4.TextSize = new Size(106, 16);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = txtStartingDate;
            layoutControlItem5.Location = new Point(0, 104);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(652, 26);
            layoutControlItem5.Text = "İşe Başlama Tarihi";
            layoutControlItem5.TextSize = new Size(106, 16);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = txtDept;
            layoutControlItem6.Location = new Point(0, 130);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(652, 26);
            layoutControlItem6.Text = "Bölümü";
            layoutControlItem6.TextSize = new Size(106, 16);
            // 
            // txtIdentityNumber
            // 
            txtIdentityNumber.Control = txtIdentityNum;
            txtIdentityNumber.Location = new Point(0, 156);
            txtIdentityNumber.Name = "txtIdentityNumber";
            txtIdentityNumber.Size = new Size(652, 26);
            txtIdentityNumber.Text = "T.C.";
            txtIdentityNumber.TextSize = new Size(106, 16);
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // XtraEmployee
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 254);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "XtraEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Ekleme Formu";
            Load += XtraEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtIdentityNum.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDept.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStartingDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBirthDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIdentityNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtDept;
        private DevExpress.XtraEditors.DateEdit txtStartingDate;
        private DevExpress.XtraEditors.TextEdit txtSalary;
        private DevExpress.XtraEditors.DateEdit txtBirthDate;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnAddEmployee;
        private DevExpress.XtraEditors.TextEdit txtIdentityNum;
        private DevExpress.XtraLayout.LayoutControlItem txtIdentityNumber;
    }
}