using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns
{
    public static class ValidationTool
    {
        public static bool Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var res = validator.Validate(context);
            if (!res.IsValid)
            {
                foreach (var error in res.Errors) {
                    MessageBox.Show(error.ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;

            //DepartmentValidator validationRules = new DepartmentValidator();
            //ValidationResult validationResult = validationRules.Validate(department);
            //IList<ValidationFailure> failures = validationResult.Errors;
            //if (!validationResult.IsValid)
            //{
            //    foreach (ValidationFailure item in failures)
            //    {
            //        MessageBox.Show(item.ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }

            //    return false;
            //}

            
        }
    }
}
