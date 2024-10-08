﻿using KalendarzPracowniczyDomain.Entities.Cars;
using KalendarzPracowniczyDomain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace KalendarzPracowniczyDomain.Entities.Events
{
    public class Event
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
        public string? DeletedById { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? CarId { get; set; }
        public Car? Car { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}