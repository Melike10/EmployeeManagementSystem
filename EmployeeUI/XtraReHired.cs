using Business.Abstract;
using DevExpress.XtraEditors;
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
    public partial class XtraReHired : DevExpress.XtraEditors.XtraForm
    {
        public XtraEmployeeList employeeList;
        private readonly IEmployeeService _employeService;
        public int employeId;
        public XtraReHired(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeService = employeeService;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Personeli işe geri almak istiyor musunuz? ", "İşe Al?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var res = _employeService.Get(employeId);
                res.StartingDate= Convert.ToDateTime(txtStartingDate.Text);
                res.Status = "Çalışıyor";
                res.ReasonOfLeaving = null;
                res.EndingDate = null;
                _employeService.ReHired(res);

                employeeList.GetList();
                this.Close();

            }
        }

        private void XtraReHired_Load(object sender, EventArgs e)
        {
            txtStartingDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}