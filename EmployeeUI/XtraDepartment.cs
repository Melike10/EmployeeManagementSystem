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
using DataAccess.Concrete.EntityFramework.Context;
using Business.Abstract;
using Entitities.Concrete;

namespace EmployeeUI
{
    public partial class XtraDepartment : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmentService;
        int _id;

        public XtraDepartment(IDepartmentService departmentService)
        {
            InitializeComponent();
            _departmentService = departmentService;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Vazgeç")
            {
                Clear();

            }
            else
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Güncelle")
            {
                var findDept = _departmentService.Get(_id);
                findDept.Name = txtDepartmentName.Text;
                var res = _departmentService.Update(findDept);
                if (res)
                {

                    GetList();
                    Clear();

                }
                else
                {
                    MessageBox.Show("Hata ile karşılaşıldı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Department department = new Department
                {
                    Name = txtDepartmentName.Text,
                    Status = true
                };
                var res = _departmentService.Add(department);
                if (res)
                {

                    GetList();
                    Clear();
                }

            }
        }

        private void XtraDepartment_Load(object sender, EventArgs e)
        {
            GetList();

        }

        void GetList()
        {
            var res = _departmentService.GetList();

            gridControl1.DataSource = res;
        }

        void Clear()
        {
            txtDepartmentName.Text = "";
            btnClose.Text = "Kapat";
            btnSave.Text = "Kaydet";
        }

        private void repositoryBtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as Department).Name} Silmek istiyor musunuz?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dept = (gridView1.GetFocusedRow() as Department);
                _departmentService.Delete(dept);
                GetList();
            }
        }

        private void repositoryBtnEdit_Click(object sender, EventArgs e)
        {
            _id = (gridView1.GetFocusedRow() as Department).Id;
            string name = (gridView1.GetFocusedRow() as Department).Name;
            txtDepartmentName.Text = name;
            btnSave.Text = "Güncelle";
            btnClose.Text = "Vazgeç";
        }

        private void repositoryButtonStatusChange_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as Department).Name} bölümün durumunu değiştirmek istiyor musun?", "Değişiklik?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dept = (gridView1.GetFocusedRow() as Department);
                _departmentService.StatusChange(dept);
                GetList();
            }
        }
    }
}