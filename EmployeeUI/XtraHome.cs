using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout;
using Business.Abstract;
using DataAccess.Abstract;
using Entitities.Concrete;

namespace EmployeeUI
{
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        private readonly IOffDayService _offDayService;
        private readonly IPayrollParameterService _payrollParameterService;
        private readonly IPayrollService _payroll;
        public XtraEmployeeList employeeList;
        public XtraHome(IDepartmentService departmentService, IEmployeeService employeeService, IOffDayService offDayService, IPayrollParameterService payrollParameterService, IPayrollService payroll)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _employeeService = employeeService;
            _offDayService = offDayService;
            _payrollParameterService = payrollParameterService;
            _payroll = payroll;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraDepartment department;
            department = new XtraDepartment(_departmentService);
            // bu sayede yeni bir sayfada değil ana sayfa için tabın altında çağırıyor
            //department.MdiParent = this;
            department.Show();
        }



        private void btnAddEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraEmployeeAdd employee;
            employee = new XtraEmployeeAdd(_departmentService, _employeeService);
            employee.employeeList = employeeList;
            //employee.MdiParent = this;
            employee.Show();
        }

        private void XtraHome_Load(object sender, EventArgs e)
        {
            GetEmployeeListForm();
        }

        void GetEmployeeListForm()
        {
            // bu if bloğu sayesinde butona bastığında tekrar tekrar liste açmasını önledik
            if (employeeList == null || employeeList.IsDisposed)
            {
                employeeList = new XtraEmployeeList(_employeeService, _departmentService, _offDayService);
                employeeList.MdiParent = this;
                employeeList.Show();
            }
            else
            {
                employeeList.Focus();
            }
        }

        private void btnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetEmployeeListForm();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraOffDayAdd offDayAdd;
            offDayAdd = new XtraOffDayAdd(_employeeService, _offDayService);
            offDayAdd.employeeList = employeeList;
            offDayAdd.Show();

        }

        private void btnOffDayList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraOffDayList offDayList;
            offDayList = new XtraOffDayList(_offDayService);
            offDayList.employeeList = employeeList;
            offDayList.Show();
        }

        private void btnPayrollParameter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraPayrollParameter payrollParameter;
            payrollParameter = new XtraPayrollParameter(_payrollParameterService);
            payrollParameter.Show();
        }

        private void btnPayrollList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraPayroll payroll = new XtraPayroll(_payroll);
            payroll.MdiParent = this;
            payroll.Show();
        }
    }
}