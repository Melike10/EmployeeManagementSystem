using Entitities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(r=>r.Name).NotEmpty().WithMessage("Personel ismi boş bırakılamaz!");
            RuleFor(r => r.Name).MinimumLength(3).WithMessage("Personel ismi en az 3 karakterli olmalıdır!");
            RuleFor(r => r.LastName).NotEmpty().WithMessage("Personel soyismi boş bırakılamaz!");
            RuleFor(r => r.LastName).MinimumLength(3).WithMessage("Personel soyismi en az 3 karakterli olmalıdır!");
            RuleFor(r => r.Salary).GreaterThan(0).WithMessage("Personel ücreti askeri ücretten büyük olmalıdır!");
            RuleFor(r => r.BirthDate).LessThan(DateTime.Now.AddYears(-18)).WithMessage("18 yaşından küçükler işe alınamaz");
            RuleFor(r => r.DepartmentId).GreaterThan(0).WithMessage("Personel için bölüm seçmelisiniz!");
            RuleFor(r => r.IdentitiyNumber).NotEmpty().MaximumLength(11).MinimumLength(11).WithMessage("T.C. Kmlik numarası 11 haneli olmalıdır!");

        }
    }
}
