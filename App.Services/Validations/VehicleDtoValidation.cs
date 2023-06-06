using System;
using FluentValidation;
using App.Core.Dtos;
namespace App.Services.Validations
{
    public class VehicleDtoValidation : AbstractValidator<VehicleDto>
    {
        public VehicleDtoValidation()
        {
            RuleFor(x => x.Plate).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}

