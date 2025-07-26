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
    public partial class XtraOffDayUpdate : DevExpress.XtraEditors.XtraForm
    {
        public XtraOffDayList offDayList;
        public XtraEmployeeList employeeList;
        private readonly IOffDayService _offDayService;
        public int offDayId =0;
        public XtraOffDayUpdate(IOffDayService offDayService)
        {
            InitializeComponent();
            _offDayService = offDayService;
        }

        private void XtraOffDayUpdate_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var offDay = _offDayService.GetById(offDayId);
            offDay.Date=Convert.ToDateTime(txtDate.Text);
            

            var res = _offDayService.Update(offDay);
            if (res)
            {
                employeeList.GetList();
                offDayList.GetList();
                this.Close();
            }
        }
    }
}