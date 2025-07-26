using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OffDayManager : IOffDayService
    {
        private readonly IOffDayDal _offDayDal;
        

        public OffDayManager(IOffDayDal offDayDal)
        {
            _offDayDal = offDayDal;
           
        }

        public bool Add(int employeeId, string date1,string date2)
        {
            DateTime d1 = Convert.ToDateTime(date1);
            DateTime d2 = Convert.ToDateTime(date2);

            if (d1 > d2)
            {
                MessageBox.Show("İzin başlangıç tarihi bitiş tarihinden büyük olamaz.","Hata!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            while (d1 <= d2)
            {
                var res = _offDayDal.GetList(x => x.Date == d1 && x.EmployeeId == employeeId).Count();
                if (res > 0)
                {
                    MessageBox.Show("Seçilen kullanıcı o tarihler arasında zaten izinli.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                d1 = d1.AddDays(1);
            }
            d1 = Convert.ToDateTime(date1);
            while (d1 <= d2)
            {
                OffDay offDay = new OffDay()
                {
                    EmployeeId = employeeId,
                    Date = d1,
                };
                _offDayDal.Add(offDay);
                d1 = d1.AddDays(1);
            }
            return true;
        }



        public bool Delete(OffDay offDay)
        {
            var employee= GetEmployee(offDay.EmployeeId);
            if (employee.Status != "İşten Ayrıldı")
            {
                _offDayDal.Delete(offDay);
                MessageBox.Show("Personel izni başarıyla silinmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("İşten ayrılan personelin kaydı silinemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false; 
        }

        public OffDay GetById(int id)
        {
            return _offDayDal.Get(o=>o.Id == id);
        }

        public Employee GetEmployee(int employeeId)
        {
            return _offDayDal.GetEmployee(employeeId);
        }

        public OffDay GetEmployeeOffDayByDate(int id, DateTime date)
        {
            return _offDayDal.Get(g=>g.EmployeeId== id  && g.Date== date);
        }

        public List<OffDayDto> GetEmployeeOffDays()
        {
            return _offDayDal.GetEmployeeOffDays();
        }

        public bool Update(OffDay offDay)
        {
            var res = _offDayDal.GetList(x => x.Date == offDay.Date && x.EmployeeId == offDay.EmployeeId).Count();
            if (res > 0)
            {
                MessageBox.Show("Seçilen kullanıcı o tarihler arasında zaten izinli.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _offDayDal.Update(offDay);
            MessageBox.Show("Seçilen kullanıcı başarıyla güncellendi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}
