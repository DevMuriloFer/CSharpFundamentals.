using System;
using System.Collections.Generic;
using System.Text;

namespace _08_ProductOrderApp.Entities.Enums
{
    internal enum OrderStatus
    {
        Pending_Payment = 1,
        Processing = 2,
        Shipped = 3,
        Delivered = 4
    }
}
