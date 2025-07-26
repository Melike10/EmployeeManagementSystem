using Business.Abstract;
using DevExpress.XtraEditors;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class XtraEmployeeUpdate : DevExpress.XtraEditors.XtraForm
    {
        public XtraEmployeeList employeeList;
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        int employeeId = 0;
        int deptId = 0;
        string status = "";


        public XtraEmployeeUpdate(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        private void XtraEmployeeUpdate_Load(object sender, EventArgs e)
        {
            // yüklenirken departman listesi çektik
            var depts = _departmentService.GetList().Where(x => x.Status == true);
            foreach (var dept in depts)
            {
                txtDept.Properties.Items.Add(dept.Name);
            }

        }

        public void Get(int id)
        {

            var res = _employeeService.Get(id);
            var findDept = _departmentService.Get(res.DepartmentId);
            txtName.Text = res.Name;
            txtLastName.Text = res.LastName;
            txtBirthDate.Text = res.BirthDate.ToString("dd.MM.yyyy");
            txtStartingDate.Text = res.StartingDate.ToString("dd.MM.yyyy");
            txtSalary.Text = res.Salary.ToString();
            txtIdentityNum.Text = res.IdentitiyNumber;
            txtDept.Text = findDept.Name;
            //MessageBox.Show("Kayıt başarılı şekilde güncellendi (Id= " + id+")");
            employeeId = id;
            status = res.Status;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnUpdateEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Employee employee = new Employee
            {
                Id = employeeId,
                Name = txtName.Text,
                LastName = txtLastName.Text,
                BirthDate = Convert.ToDateTime(txtBirthDate.Text),
                StartingDate = Convert.ToDateTime(txtStartingDate.Text),
                Salary = decimal.Parse(txtSalary.Text.Replace("₺", "").Trim(), NumberStyles.Currency, new CultureInfo("tr-TR")),
                IdentitiyNumber = txtIdentityNum.Text,
                DepartmentId = deptId,
                Status= status,
            };
            var res = _employeeService.Update(employee);

            if (res)
            {
                employeeList.GetList();
                this.Close();
            }
        }

        private void txtDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            deptId= _departmentService.GetDepartmentId(txtDept.Text);
        }
    }
}