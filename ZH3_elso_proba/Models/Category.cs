using System;
using System.Collections.Generic;

namespace ZH3_elso_proba.Models;

public partial class Category
{
    public int CategorySk { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
