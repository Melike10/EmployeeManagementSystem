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
using System.Windows.Controls;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class XtraOffDayAdd : DevExpress.XtraEditors.XtraForm
    {
        public XtraEmployeeList employeeList;
        private readonly IOffDayService _dayService;
        private readonly IEmployeeService _employeeService;
        public int employeeId = 0;
        public XtraOffDayAdd(IEmployeeService employeeService, IOffDayService dayService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _dayService = dayService;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraOffDayAdd_Load(object sender, EventArgs e)
        {
            GetEmployeeList();
            txtStartDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtEndDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        void GetEmployeeList()
        {
            var res = _employeeService.GetEmployeeOffDayList();
            searchEmployeeList.Properties.DataSource = res;
            searchEmployeeList.Properties.DisplayMember = "Name";
        }

        private void searchEmployeeList_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var view = searchEmployeeList.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
                int rowHandle = view.FocusedRowHandle;
                string fieldName = "Id";
                object value = view.GetRowCellValue(rowHandle, fieldName);

                if (value == null)
                {
                    MessageBox.Show("Seçilen personel ID'si alınamadı!");
                    return;
                }

                employeeId = Convert.ToInt32(value.ToString());



            }
            catch (Exception error)
            {

                MessageBox.Show("Hata : " + error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var res = _dayService.Add(employeeId, txtStartDate.Text, txtEndDate.Text);

            if (res)
            {
                _employeeService.GetAll();
                employeeList.GetList();
                this.Close();

            }
        }
    }
}