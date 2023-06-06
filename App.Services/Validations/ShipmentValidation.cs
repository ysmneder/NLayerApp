using System;
using App.Core.Dtos;
using FluentValidation;
namespace App.Services.Validations 
{
    public class ShipmentValidation : AbstractValidator<ShipmentBaseDto>
    {
        public ShipmentValidation()
        {
            RuleFor(x => x.Barcode).NotEmpty().WithMessage("{Property} is required").NotNull().WithMessage("{Property} is required");
            RuleFor(x => x.VolumetricWeight).ExclusiveBetween(0, decimal.MaxValue).WithMessage("{PropertyName} must be greater 0");
            RuleFor(x => x.DeliveryPointId).NotEmpty().WithMessage("{Property} is required").NotNull().WithMessage("{Property} is required");
        }
    }
}

