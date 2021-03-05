using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WorkInProgress2.Shared.Models.ProductExtra
{
    public class AssortimentCode : StatusDetailDate
    {
        //public AssortimentCode(): base()
        //{
            
        //}

        [Display(Name ="AssortimentsCode")]
        public int Code { get; set; }
    }
}
