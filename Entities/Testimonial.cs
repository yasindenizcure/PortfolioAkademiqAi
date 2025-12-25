using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class Testimonial
{
    public int TestimonialId { get; set; }

    public string? NameSurname { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }
}
