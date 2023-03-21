using EkUserManagementSystem.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkManagementSystem.Core.Validation.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("User's First Name cannot be empty");
            RuleFor(u => u.FirstName).NotNull().WithMessage("User's First Name cannot be null");

            RuleFor(u => u.LastName).NotNull().WithMessage("User's Last Name cannot be null");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("User's Last Name cannot be empty" );
           
            RuleFor(u => u.Email).NotEmpty().WithMessage("User's Email cannot be empty");
            RuleFor(u => u.Email).NotNull().WithMessage("User's Email cannot be null");

            RuleFor(u => u.IdCardNo).NotEmpty().WithMessage("Id Card No cannot be empty");
            RuleFor(u => u.IdCardNo).NotNull().WithMessage("Id Card No cannot be null");

           

        }
    }
}
