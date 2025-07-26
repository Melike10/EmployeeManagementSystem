using Business.Abstract;
using DevExpress.XtraEditors;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class XtraEmployeeQuit : DevExpress.XtraEditors.XtraForm
    {
        public XtraEmployeeList employeeList;
        private readonly IEmployeeService _employeeService;
        private int _employeeId;


        public XtraEmployeeQuit(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;

        }

        private void XtraEmployeeQuit_Load(object sender, EventArgs e)
        {

        }

        public void FillTxtBox(int id)
        {
            _employeeId = id;
            var res = _employeeService.Get(_employeeId);
            txtName.Text = res.Name + " " + res.LastName;
            txtEndingDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtEndingDate.Focus();
            txtEndingDate.SelectAll();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnEmployeeQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var checkOffDay = _employeeService.GetOffDayByEmployee(_employeeId, Convert.ToDateTime(txtEndingDate.Text));

            if (checkOffDay != null)
            {
                MessageBox.Show("Personel izin gününde işinden çıkartılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show(txtName.Text + " kişisini işten çıkarmak istediğinizden emin misiniz?", "İşten Çıkar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               var res = _employeeService.Get(_employeeId);
                res.EndingDate= Convert.ToDateTime(txtEndingDate.Text);
                res.ReasonOfLeaving = cmbReasonLeaving.Text;
                res.Status = "İşten Ayrıldı";
                _employeeService.QuitJob(res);
                employeeList.GetList();
                this.Close();
               
            }

        }
    }
}