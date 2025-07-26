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
    public partial class XtraEmployeeList : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly IOffDayService _dayService;
        public XtraEmployeeList(IEmployeeService employeeService, IDepartmentService departmentService, IOffDayService dayService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _departmentService = departmentService;
            _dayService = dayService;
        }

        private void XtraEmployeeList_Load(object sender, EventArgs e)
        {
            GetList();
        }

        public void GetList()
        {
            // bugün izinli olan var mı bakıldı. Bu örnek kod küçük firmalar için uygun olup büyük firmalarda kasabilir.
            var employeeDto = _employeeService.GetAll().Where(e=>e.Status != "İşten Ayrıldı").ToList();
            foreach (var employee in employeeDto) {
                string datestr = DateTime.Now.ToShortDateString();
                var res = _dayService.GetEmployeeOffDayByDate(employee.Id, Convert.ToDateTime(datestr));

                if (res != null)                
                    employee.Status = "İzinli";                   
                
                else                
                    employee.Status = "Çalışıyor";
                    
                

                _employeeService.UpdateList(employee);
            }

            // ilk olarak aktif çalışan listesi gelsin istendi.

            var employeeList = _employeeService.GetEmployeeDtos();
            gCEmployeeList.DataSource = employeeList.Where(e => e.Status == "Çalışıyor").ToList();

            var deptEmployeeList = _departmentService.GetListEmployeeCount();
            gCDepartmentList.DataSource = deptEmployeeList;

            int activeEmployee = employeeList.Where(e => e.Status == "Çalışıyor").Count();
            int onLeaveEmployee = employeeList.Where(e => e.Status == "İzinli").Count();
            int resignedEmployee = employeeList.Where(e => e.Status == "İşten Ayrıldı").Count();

            btnActiveEmployee.Text = "Çalışan: " + activeEmployee;
            btnOnLeaveEmployee.Text = "İzinli: " + onLeaveEmployee;
            btnResignedEmployee.Text = "Ayrılan: " + resignedEmployee;

            lblListName.Text = "Aktif Çalışan Listesi";

            // hangi butonun görüneceği seçimi yapıldı.
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = false;
            gridView1.Columns[9].Visible = false;
            gridView1.Columns[10].Visible = true;
            gridView1.Columns[11].Visible = true;
            gridView1.Columns[12].Visible = true;
            gridView1.Columns[13].Visible = false;



        }

        void GetLeaveOnEmployeeList()
        {
            var employeeList = _employeeService.GetEmployeeDtos();
            gCEmployeeList.DataSource = employeeList.Where(e => e.Status == "İzinli").ToList();
            // hangi butonun görüneceği seçimi yapıldı.
            gridView1.Columns[7].Visible = true;
            gridView1.Columns[8].Visible = false;
            gridView1.Columns[9].Visible = false;
            gridView1.Columns[10].Visible = true;
            gridView1.Columns[11].Visible = true;
            gridView1.Columns[12].Visible = true;
            gridView1.Columns[13].Visible = false;
        }

        void GetResignedEmployeeList()
        {
            var employeeList = _employeeService.GetEmployeeDtos();
            gCEmployeeList.DataSource = employeeList.Where(e => e.Status == "İşten Ayrıldı").ToList();
            // hangi butonun görüneceği seçimi yapıldı.
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = true;
            gridView1.Columns[9].Visible = true;
            gridView1.Columns[10].Visible = false;
            gridView1.Columns[11].Visible = false;
            gridView1.Columns[12].Visible = false;
            gridView1.Columns[13].Visible = true;
        }

        private void repositoryBtnEdit_Click(object sender, EventArgs e)
        {

            int id = (gridView1.GetFocusedRow() as EmployeeDto).Id;
            XtraEmployeeUpdate employeeUpdate = new XtraEmployeeUpdate(_employeeService, _departmentService);
            employeeUpdate.employeeList = this;
            employeeUpdate.Show();
            employeeUpdate.Get(id);
        }

        private void repositoryButtonDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"{(gridView1.GetFocusedRow() as EmployeeDto).Name} personelini silmek istiyor musunuz?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var emp = _employeeService.Get((gridView1.GetFocusedRow() as EmployeeDto).Id);
                _employeeService.Delete(emp);
                MessageBox.Show("Personel başarıyla silindi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetList();
            }
        }

        private void repositoryBtnEmployeeQuit_Click(object sender, EventArgs e)
        {

            int id = (gridView1.GetFocusedRow() as EmployeeDto).Id;
            XtraEmployeeQuit employeeQuit = new XtraEmployeeQuit(_employeeService);
            employeeQuit.employeeList = this;
            employeeQuit.Show();
            employeeQuit.FillTxtBox(id);
        }

        private void btnOnLeaveEmployee_Click(object sender, EventArgs e)
        {
            GetLeaveOnEmployeeList();
            lblListName.Text = "İzinli Çalışan Listesi";
        }

        private void btnResignedEmployee_Click(object sender, EventArgs e)
        {
            GetResignedEmployeeList();
            lblListName.Text = "İşten Ayrılan Listesi";
        }

        private void btnActiveEmployee_Click(object sender, EventArgs e)
        {
            GetList();

        }

        private void repositoryBtnReHired_Click(object sender, EventArgs e)
        {
            XtraReHired reHired = new XtraReHired(_employeeService);
            reHired.employeeList = this;
            reHired.Show();

            int id = (gridView1.GetFocusedRow() as EmployeeDto).Id;
            reHired.employeId = id;
        }
    }
}