using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class Experience
{
    public int ExperienceId { get; set; }

    public string? CompanyName { get; set; }

    public string? WorkDate { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? IconUrl { get; set; }
}
