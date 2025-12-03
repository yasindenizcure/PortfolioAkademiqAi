using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class Education
{
    public int EducationId { get; set; }

    public string? Title { get; set; }

    public string? Department { get; set; }

    public string? EducationDate { get; set; }
}
