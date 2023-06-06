using System;
using FluentValidation;
using App.Core.Dtos;
namespace App.Services.Validations
{
    public class DeliveryPointValidation: AbstractValidator<DeliveryPointDto>
    {
        public DeliveryPointValidation()
        {
            RuleFor(x => x.DeliveryPointName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Value).InclusiveBetween(0, int.MaxValue).WithMessage("{PropertyName} is greater than 0");
        }
    }
}

