using WorkInProgress2.Shared.Models.ProductExtra.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WorkInProgress2.Shared.Models.ProductExtra
{
    public class Order : StatusDetailDate //rede
    {
        public OrderType OrderType { get; set; }
        public RequestedBy RequestedBy { get; set; }

    }
}
