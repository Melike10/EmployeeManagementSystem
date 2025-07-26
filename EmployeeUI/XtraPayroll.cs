using Business.Abstract;
using DevExpress.XtraEditors;
using Entities.Dtos;
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
    public partial class XtraPayroll : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPayrollService _payrollService;
        public XtraPayroll(IPayrollService payrollService)
        {
            InitializeComponent();
            _payrollService = payrollService;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            _payrollService.Add(Convert.ToInt16(cmbMonth.Text), Convert.ToInt16(cmbYear.Text));
        }

        private void XtraPayroll_Load(object sender, EventArgs e)
        {
            var res = _payrollService.GetPayrollList();
            gcSummaryList.DataSource = res;

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            var selectedRow = (gridView1.GetFocusedRow() as PayrollListDto);
            var res = _payrollService.GetPayrollsOfEmployee().Where(p=>p.Mounth == selectedRow.Month && p.Year == selectedRow.Year);
            gcPayrollDetail.DataSource = res;
        }
    }
}