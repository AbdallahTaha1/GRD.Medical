using Application.Articles.Commands.CreateArticle;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MedicalInfos.Commands.UpdateMedicalInfo
{
    public class UpdateMedicalInfoCommandValidator : AbstractValidator<UpdateMedicalInfoCommand>
    {
        public UpdateMedicalInfoCommandValidator(IApplicationDbContext context)
        {
            When(c => c.Age != null, () =>
            {
                RuleFor(c => c.Age)
                 .GreaterThan(0)
                 .WithMessage("The value must be greater than 0.");
            });

            When(c => c.Hight != null, () =>
            {
                RuleFor(c => c.Hight)
                 .GreaterThan(0)
                 .WithMessage("The value must be greater than 0.");
            });

            When(c => c.Wight != null, () =>
            {
                RuleFor(c => c.Wight)
                 .GreaterThan(0)
                 .WithMessage("The value must be greater than 0.");
            });
            
        }
    }
}
