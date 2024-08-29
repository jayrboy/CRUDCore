using System;
using System.Collections.Generic;

namespace CRUDCore.Models.db;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
