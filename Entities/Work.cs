using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class Work
{
    public int WorkId { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? ImageUrl { get; set; }
}
