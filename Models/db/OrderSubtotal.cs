using System;
using System.Collections.Generic;

namespace CRUDCore.Models.db;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
