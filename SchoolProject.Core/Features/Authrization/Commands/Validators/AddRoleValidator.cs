using FluentValidation;
using SchoolProject.Core.Features.Authrization.Commands.Models;
using SchoolProject.Service.Abstracts;
using SchoolProject.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Authrization.Commands.Validators
{
    public class AddRoleValidator :AbstractValidator<AddRoleCommand>
    {
        private readonly IAuthrizationServices _authrizationServices;
        public AddRoleValidator(IAuthrizationServices authrizationServices)
        {
            _authrizationServices = authrizationServices;

            RuleFor(x => x.RoleName)
            .NotEmpty().WithMessage("Role name cannot be empty.");
            RuleFor(x => x.Permission)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Permission)
                .Must(x => x.Distinct().Count()==x.Count)
                .WithMessage("You Cannot add duplicated Permissions for the same role")
                .When(x => x.Permission != null);
        }
    }
}
