namespace EmployeeUI
{
    partial class XtraEmployeeQuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraEmployeeQuit));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            cmbReasonLeaving = new DevExpress.XtraEditors.ComboBoxEdit();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnEmployeeQuit = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            txtEndingDate = new DevExpress.XtraEditors.TextEdit();
            txtName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            txtPersonelName = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            txtQuitDate = new DevExpress.XtraLayout.LayoutControlItem();
            cmbReasonOfLeaving = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbReasonLeaving.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEndingDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPersonelName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuitDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbReasonOfLeaving).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(cmbReasonLeaving);
            layoutControl1.Controls.Add(txtEndingDate);
            layoutControl1.Controls.Add(txtName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 30);
            layoutControl1.Margin = new Padding(4);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(771, 131);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // cmbReasonLeaving
            // 
            cmbReasonLeaving.Location = new Point(95, 64);
            cmbReasonLeaving.Margin = new Padding(4);
            cmbReasonLeaving.MenuManager = barManager1;
            cmbReasonLeaving.Name = "cmbReasonLeaving";
            cmbReasonLeaving.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbReasonLeaving.Properties.DropDownRows = 40;
            cmbReasonLeaving.Properties.Items.AddRange(new object[] { "1- Deneme süreli iş sözleşmesinin işverence feshi ", "2- Deneme süreli iş sözleşmesinin işçi tarafından feshi ", "3- Belirsiz süreli iş sözleşmesinin işçi tarafından feshi (istifa) ", "4- Belirsiz süreli iş sözleşmesinin işveren tarafından haklı sebep bildirilmeden feshi ", "5- Belirli süreli iş sözleşmesinin sona ermesi ", "8- Emeklilik (yaşlılık) veya toptan ödeme nedeniyle ", "9- Malulen emeklilik nedeniyle ", "10- Ölüm ", "11- İş kazası sonucu ölüm ", "12- Askerlik ", "13- Kadın işçinin evlenmesi ", "14- Emeklilik için yaş dışında diğer şartların tamamlanması ", "15- Toplu işçi çıkarma ", "16- Sözleşme sona ermeden sigortalının aynı işverene ait diğer işyerine nakli ", "17- İşyerinin kapanması ", "18- İşin sona ermesi ", "19- Mevsim bitimi (İş akdinin askıya alınması halinde kullanılır. Tekrar başlatılmayacaksa \"4\" nolu kod kullanılır) ", "20- Kampanya bitimi (İş akdinin askıya alınması halinde kullanılır. Tekrar başlatılmayacaksa \"4\" nolu kod kullanılır) ", "21- Statü değişikliği ", "22- Diğer nedenler ", "23- İşçi tarafından zorunlu nedenle fesih ", "24- İşçi tarafından sağlık nedeniyle fesih ", "25- İşçi tarafından işverenin ahlak ve iyi niyet kurallarına aykırı davranışı nedeni ile fesih ", "26- Disiplin Kurulu kararı ile fesih ", "27- İşveren tarafından zorunlu nedenlerle ve tutukluluk nedeniyle fesih ", "28- İşveren tarafından sağlık nedeni ile fesih ", "29- İşveren tarafından işçinin ahlak ve iyi niyet kurallarına aykırı davranışı nedeni ile fesih", "​30- Vize süresinin bitimi (İş akdinin askıya alınması halinde kullanılır. Tekrar başlatılmayacaksa \"4\" nolu kod kullanılır.) ", "31- Borçlar Kanunu, Sendikalar Kanunu, Grev ve Lokavt Kanunu kapsamında kendi istek ve kusuru dışında fesih ", "32- 4046 sayılı Kanunun 21 inci maddesine göre özelleştirme nedeni ile fesih ", "33- Gazeteci tarafından sözleşmenin feshi ", "34- İşyerinin devri, işin veya işyerinin niteliğinin değişmesi nedeniyle fesih", "36- OHAL/KHK" });
            cmbReasonLeaving.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbReasonLeaving.Size = new Size(664, 22);
            cmbReasonLeaving.StyleController = layoutControl1;
            cmbReasonLeaving.TabIndex = 6;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnEmployeeQuit, btnClose });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnEmployeeQuit), new DevExpress.XtraBars.LinkPersistInfo(btnClose) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnEmployeeQuit
            // 
            btnEmployeeQuit.Caption = "Çıkış Ver";
            btnEmployeeQuit.Id = 0;
            btnEmployeeQuit.ImageOptions.Image = (Image)resources.GetObject("btnEmployeeQuit.ImageOptions.Image");
            btnEmployeeQuit.ImageOptions.LargeImage = (Image)resources.GetObject("btnEmployeeQuit.ImageOptions.LargeImage");
            btnEmployeeQuit.Name = "btnEmployeeQuit";
            btnEmployeeQuit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnEmployeeQuit.ItemClick += btnEmployeeQuit_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Kapat";
            btnClose.Id = 1;
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
            barDockControlTop.Margin = new Padding(4);
            barDockControlTop.Size = new Size(771, 30);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 161);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Margin = new Padding(4);
            barDockControlBottom.Size = new Size(771, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 30);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Margin = new Padding(4);
            barDockControlLeft.Size = new Size(0, 131);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(771, 30);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Margin = new Padding(4);
            barDockControlRight.Size = new Size(0, 131);
            // 
            // txtEndingDate
            // 
            txtEndingDate.Location = new Point(95, 38);
            txtEndingDate.Margin = new Padding(4);
            txtEndingDate.MenuManager = barManager1;
            txtEndingDate.Name = "txtEndingDate";
            txtEndingDate.Size = new Size(664, 22);
            txtEndingDate.StyleController = layoutControl1;
            txtEndingDate.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(95, 12);
            txtName.Margin = new Padding(4);
            txtName.MenuManager = barManager1;
            txtName.Name = "txtName";
            txtName.Size = new Size(664, 22);
            txtName.StyleController = layoutControl1;
            txtName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { txtPersonelName, emptySpaceItem1, txtQuitDate, cmbReasonOfLeaving });
            Root.Name = "Root";
            Root.Size = new Size(771, 131);
            Root.TextVisible = false;
            // 
            // txtPersonelName
            // 
            txtPersonelName.Control = txtName;
            txtPersonelName.Location = new Point(0, 0);
            txtPersonelName.Name = "txtPersonelName";
            txtPersonelName.Size = new Size(751, 26);
            txtPersonelName.Text = "Personel Adı";
            txtPersonelName.TextSize = new Size(71, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new Point(0, 78);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(751, 33);
            // 
            // txtQuitDate
            // 
            txtQuitDate.Control = txtEndingDate;
            txtQuitDate.Location = new Point(0, 26);
            txtQuitDate.Name = "txtQuitDate";
            txtQuitDate.Size = new Size(751, 26);
            txtQuitDate.Text = "Çıkış Tarihi";
            txtQuitDate.TextSize = new Size(71, 16);
            // 
            // cmbReasonOfLeaving
            // 
            cmbReasonOfLeaving.Control = cmbReasonLeaving;
            cmbReasonOfLeaving.Location = new Point(0, 52);
            cmbReasonOfLeaving.Name = "cmbReasonOfLeaving";
            cmbReasonOfLeaving.Size = new Size(751, 26);
            cmbReasonOfLeaving.Text = "Çıkış Sebebi";
            cmbReasonOfLeaving.TextSize = new Size(71, 16);
            // 
            // XtraEmployeeQuit
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 161);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            IconOptions.Image = (Image)resources.GetObject("XtraEmployeeQuit.IconOptions.Image");
            Margin = new Padding(4);
            Name = "XtraEmployeeQuit";
            Text = "Personel İşten Çıkış Formu";
            Load += XtraEmployeeQuit_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbReasonLeaving.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEndingDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPersonelName).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuitDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbReasonOfLeaving).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnEmployeeQuit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraEditors.TextEdit txtEndingDate;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem txtPersonelName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem txtQuitDate;
        private DevExpress.XtraEditors.ComboBoxEdit cmbReasonLeaving;
        private DevExpress.XtraLayout.LayoutControlItem cmbReasonOfLeaving;
    }
}