namespace EmployeeUI
{
    partial class XtraHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraHome));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnPersonel = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            btnDepartment = new DevExpress.XtraBars.BarButtonItem();
            btnAddEmployee = new DevExpress.XtraBars.BarButtonItem();
            btnEmployeeOffDay = new DevExpress.XtraBars.BarButtonItem();
            btnOffDayList = new DevExpress.XtraBars.BarButtonItem();
            btnPayrollParameter = new DevExpress.XtraBars.BarButtonItem();
            PersonelTakip = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            btnPayrollList = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, btnPersonel, btnClose, btnDepartment, btnAddEmployee, btnEmployeeOffDay, btnOffDayList, btnPayrollParameter, btnPayrollList });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 9;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { PersonelTakip });
            ribbonControl1.Size = new Size(893, 183);
            // 
            // btnPersonel
            // 
            btnPersonel.Caption = "Personel Listesi";
            btnPersonel.Id = 1;
            btnPersonel.ImageOptions.Image = (Image)resources.GetObject("btnPersonel.ImageOptions.Image");
            btnPersonel.ImageOptions.LargeImage = (Image)resources.GetObject("btnPersonel.ImageOptions.LargeImage");
            btnPersonel.Name = "btnPersonel";
            btnPersonel.ItemClick += btnPersonel_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Kapat";
            btnClose.Id = 2;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.LargeImage = (Image)resources.GetObject("btnClose.ImageOptions.LargeImage");
            btnClose.Name = "btnClose";
            btnClose.ItemClick += barButtonItem2_ItemClick;
            // 
            // btnDepartment
            // 
            btnDepartment.Caption = "Personel Bölüm Listesi";
            btnDepartment.Id = 3;
            btnDepartment.ImageOptions.Image = (Image)resources.GetObject("btnDepartment.ImageOptions.Image");
            btnDepartment.ImageOptions.LargeImage = (Image)resources.GetObject("btnDepartment.ImageOptions.LargeImage");
            btnDepartment.Name = "btnDepartment";
            btnDepartment.ItemClick += btnDepartment_ItemClick;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Caption = "Personel Ekle";
            btnAddEmployee.Id = 4;
            btnAddEmployee.ImageOptions.Image = (Image)resources.GetObject("btnAddEmployee.ImageOptions.Image");
            btnAddEmployee.ImageOptions.LargeImage = (Image)resources.GetObject("btnAddEmployee.ImageOptions.LargeImage");
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.ItemClick += btnAddEmployee_ItemClick;
            // 
            // btnEmployeeOffDay
            // 
            btnEmployeeOffDay.Caption = "Personel İzin Girişi";
            btnEmployeeOffDay.Id = 5;
            btnEmployeeOffDay.ImageOptions.Image = (Image)resources.GetObject("btnEmployeeOffDay.ImageOptions.Image");
            btnEmployeeOffDay.ImageOptions.LargeImage = (Image)resources.GetObject("btnEmployeeOffDay.ImageOptions.LargeImage");
            btnEmployeeOffDay.Name = "btnEmployeeOffDay";
            btnEmployeeOffDay.ItemClick += barButtonItem1_ItemClick;
            // 
            // btnOffDayList
            // 
            btnOffDayList.Caption = "Personel İzin Listesi";
            btnOffDayList.Id = 6;
            btnOffDayList.ImageOptions.Image = (Image)resources.GetObject("btnOffDayList.ImageOptions.Image");
            btnOffDayList.ImageOptions.LargeImage = (Image)resources.GetObject("btnOffDayList.ImageOptions.LargeImage");
            btnOffDayList.Name = "btnOffDayList";
            btnOffDayList.ItemClick += btnOffDayList_ItemClick;
            // 
            // btnPayrollParameter
            // 
            btnPayrollParameter.Caption = "Bordro Parametreleri";
            btnPayrollParameter.Id = 7;
            btnPayrollParameter.ImageOptions.Image = (Image)resources.GetObject("btnPayrollParameter.ImageOptions.Image");
            btnPayrollParameter.ImageOptions.LargeImage = (Image)resources.GetObject("btnPayrollParameter.ImageOptions.LargeImage");
            btnPayrollParameter.Name = "btnPayrollParameter";
            btnPayrollParameter.ItemClick += btnPayrollParameter_ItemClick;
            // 
            // PersonelTakip
            // 
            PersonelTakip.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup1, ribbonPageGroup4, ribbonPageGroup2 });
            PersonelTakip.Name = "PersonelTakip";
            PersonelTakip.Text = "Personel Takip";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(btnPersonel);
            ribbonPageGroup3.ItemLinks.Add(btnDepartment);
            ribbonPageGroup3.ItemLinks.Add(btnOffDayList);
            ribbonPageGroup3.ItemLinks.Add(btnPayrollList);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Listeler";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnAddEmployee);
            ribbonPageGroup1.ItemLinks.Add(btnEmployeeOffDay);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Kayıt";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(btnPayrollParameter);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "Parametreler";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(btnClose);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Kapat";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // btnPayrollList
            // 
            btnPayrollList.Caption = "Bordro";
            btnPayrollList.Id = 8;
            btnPayrollList.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            btnPayrollList.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            btnPayrollList.Name = "btnPayrollList";
            btnPayrollList.ItemClick += btnPayrollList_ItemClick;
            // 
            // XtraHome
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 575);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Name = "XtraHome";
            Text = "XtraHome";
            Load += XtraHome_Load;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnPersonel;
        private DevExpress.XtraBars.Ribbon.RibbonPage PersonelTakip;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDepartment;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnAddEmployee;
        private DevExpress.XtraBars.BarButtonItem btnEmployeeOffDay;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnOffDayList;
        private DevExpress.XtraBars.BarButtonItem btnPayrollParameter;
        private DevExpress.XtraBars.BarButtonItem btnPayrollList;
    }
}