using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class Project
{
    public int ProjectId { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? ImageUrl { get; set; }
}
