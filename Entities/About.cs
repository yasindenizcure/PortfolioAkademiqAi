using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class About
{
    public int AboutId { get; set; }

    public string? NameSurname { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? ImageUrl { get; set; }
}
