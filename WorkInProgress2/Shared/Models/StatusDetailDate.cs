using System;
using System.ComponentModel.DataAnnotations;
using WorkInProgress2.Shared.Models.ProductExtra.Enums;

namespace WorkInProgress2.Shared.Models
{
    public class StatusDetailDate
    {
        public StatusDetailDate()
        {
            RegisterDate = DateTime.Now;
        }
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        [Key]
        public int Id { get; set; }
        public bool SetStatus { get; set; }
        public Status Status { get; set; }
        public bool SetDetail { get; set; }
        public string Detail { get; set; }
        public bool SetEndDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
       
    }
}
