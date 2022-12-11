﻿using System;
using System.Collections.Generic;

namespace ZH3_elso_proba.Models;

public partial class Staff
{
    public int StaffSk { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public byte Active { get; set; }

    public int StoreFk { get; set; }

    public int? ManagerFk { get; set; }

    public virtual ICollection<Staff> InverseManagerFkNavigation { get; } = new List<Staff>();

    public virtual Staff? ManagerFkNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual Store StoreFkNavigation { get; set; } = null!;
}
