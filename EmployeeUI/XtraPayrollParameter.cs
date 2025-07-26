using Business.Abstract;
using DevExpress.XtraEditors;
using Entities.Concrete;
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
    public partial class XtraPayrollParameter : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPayrollParameterService _payrollParameterService;
        public XtraPayrollParameter(IPayrollParameterService payrollParameterService)
        {
            InitializeComponent();
            _payrollParameterService = payrollParameterService;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void XtraPayrollParameter_Load(object sender, EventArgs e)
        {
            var res = _payrollParameterService.Get();
            if (res != null)
            {
                txtNetMinWage.Text = res.NetMinimumWage.ToString();
                txtBrutMinWage.Text = res.BrutMinimumWage.ToString();
                txtParameter1.Text = res.Parameter1.ToString();
                txtParameter2.Text = res.Parameter2.ToString();
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var res = _payrollParameterService.Get();
            if (res != null)
            {
                res.NetMinimumWage = Convert.ToDecimal(txtNetMinWage.Text);
                res.BrutMinimumWage = Convert.ToDecimal(txtBrutMinWage.Text);
                res.Parameter1 = Convert.ToDecimal(txtParameter1.Text);
                res.Parameter2 = Convert.ToDecimal(txtParameter2.Text);
                _payrollParameterService.Update(res);
            }
            else
            {
                PayrollParameter payrollParameter = new PayrollParameter() 
                {
                    NetMinimumWage = Convert.ToDecimal(txtNetMinWage.Text),
                    BrutMinimumWage = Convert.ToDecimal(txtBrutMinWage.Text),
                   Parameter1 = Convert.ToDecimal(txtParameter1.Text),
                    Parameter2 = Convert.ToDecimal(txtParameter2.Text)
                    
                };
                _payrollParameterService.Update(payrollParameter);
            }

        }
    }
}