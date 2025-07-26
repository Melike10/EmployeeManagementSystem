using Business.Abstract;
using DevExpress.DataAccess.Native.Sql;
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
    public partial class XtraEmployeeAdd : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        public XtraEmployeeList employeeList;
        public XtraEmployeeAdd(IDepartmentService departmentService, IEmployeeService employeeService)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _employeeService = employeeService;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        int deptId = 0;
        private void XtraEmployee_Load(object sender, EventArgs e)
        {
            var depts = _departmentService.GetList().Where(x=>x.Status==true);
            foreach (var dept in depts)
            {
                txtDept.Properties.Items.Add(dept.Name);
            }
            txtStartingDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtBirthDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            txtSalary.Focus();
            txtSalary.SelectAll();

        }

        private void txtDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            deptId = _departmentService.GetDepartmentId(txtDept.Text);
        }



        private void btnAddEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Employee employee = new Employee
            {
                Name = txtName.Text.ToLower(),
                LastName = txtLastName.Text.ToLower(),
                BirthDate = Convert.ToDateTime(txtBirthDate.Text),
                StartingDate = Convert.ToDateTime(txtStartingDate.Text),
                Salary = Convert.ToDecimal(txtSalary.Text.Substring(1)),
                DepartmentId = deptId,
                IdentitiyNumber = txtIdentityNum.Text,
                Status = "Çalışıyor"

            };

            var res = _employeeService.Add(employee);
            if (res)
            {
                employeeList.GetList();
                Clear();
            }
        }
        public void Clear()
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtIdentityNum.Text = "";
            txtSalary.Text = "0";
            txtBirthDate.Text =DateTime.Now.ToString("dd.MM.yyyy");
            txtStartingDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtDept.Text = "";
            txtName.Focus();//cursor isime yönledirildi
        }
        private void txtIdentityNum_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}