using Business.Abstract;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Entities.Dtos;
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
    public partial class XtraOffDayList : DevExpress.XtraEditors.XtraForm
    {
        public XtraEmployeeList employeeList;
        private readonly IOffDayService _offDayService;
        public XtraOffDayList(IOffDayService offDayService)
        {
            InitializeComponent();
            _offDayService = offDayService;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void XtraOffDayList_Load(object sender, EventArgs e)
        {
            var res = _offDayService.GetEmployeeOffDays();
            gC1.DataSource = res;
        }
        public void GetList()
        {
            var res = _offDayService.GetEmployeeOffDays();
            gC1.DataSource = res;
        }

        private void repositoryBtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{(gridView1.GetFocusedRow() as OffDayDto).Name} isimli personelin iznini silmek istiyor musunuz?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (gridView1.GetFocusedRow() as OffDayDto).Id;
                var res = _offDayService.GetById(id);
                _offDayService.Delete(res);
                GetList();
                employeeList.GetList();
            }
        }

        private void repositoryBtnUpdate_Click(object sender, EventArgs e)
        {
            XtraOffDayUpdate offDayUpdate = new XtraOffDayUpdate(_offDayService);
            offDayUpdate.employeeList = employeeList;
            offDayUpdate.offDayList = this;
            offDayUpdate.Show();

            offDayUpdate.txtName.Text = (gridView1.GetFocusedRow() as OffDayDto).Name;
            offDayUpdate.txtDate.Text = (gridView1.GetFocusedRow() as OffDayDto).Date.ToString("dd.MM.yyyy");
            offDayUpdate.offDayId =  (gridView1.GetFocusedRow() as OffDayDto).Id;

        }
    }
}