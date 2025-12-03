using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class Contact
{
    public int ContactId { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? MapLocation { get; set; }
}
