using RMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RMS.Domain.Entities
{
public class Equipment
    {
        [Key]
        public Guid Id { get; set; }
        public string? SerialNumber { get; set; }
        public string? Models { get; set; }

        public Category Category { get; set; }
        public LoanStatus LoanStatus { get; set; }
    }
}
