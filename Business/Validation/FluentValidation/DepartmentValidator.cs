using Entitities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class DepartmentValidator:AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage("Bölüm adı boş olamaz");
            RuleFor(r => r.Name).MinimumLength(3).WithMessage("En az 4 karakter olmalı");

        }
    }
}
