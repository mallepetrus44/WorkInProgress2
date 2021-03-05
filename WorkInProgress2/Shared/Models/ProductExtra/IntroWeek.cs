using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WorkInProgress2.Shared.Models.ProductExtra
{
    public class IntroWeek : StatusDetailDate
    {
        public int Year { get; set; }
        public int Week { get; set; }
    }
}
