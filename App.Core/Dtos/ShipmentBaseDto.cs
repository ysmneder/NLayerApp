﻿using System;
namespace App.Core.Dtos
{
    public abstract class ShipmentBaseDto
    {
        public Guid Id { get; set; }
        public decimal VolumetricWeight { get; set; }
        public Guid DeliveryPointId { get; set; }
        public string Barcode { get; set; }
    }
}

