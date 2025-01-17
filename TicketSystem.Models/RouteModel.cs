﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketSystem.Models
{
    public class RouteModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid DestinationStationId { get; set; }
        [ForeignKey("DestinationStationId")]
        [ValidateNever]
        public StationModel DestinationStation { get; set; }
        [Required]
        public Guid OutgoingStationId { get; set; }
        [ForeignKey("OutgoingStationId")]
        [ValidateNever]
        public StationModel OutgoingStation { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Distance { get; set; }
        [ValidateNever]
        public TimeSpan Duration { get; set; }

    }
}
