using System;
using System.Collections.Generic;

namespace WebApplication2.DBContexts;

public partial class CdnUser
{
    public Guid Id { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Skillsets { get; set; }

    public string? Hobby { get; set; }
}
