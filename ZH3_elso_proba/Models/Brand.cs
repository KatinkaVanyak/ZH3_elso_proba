using System;
using System.Collections.Generic;

namespace ZH3_elso_proba.Models;

public partial class Brand
{
    public int BrandSk { get; set; }

    public string BrandName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
