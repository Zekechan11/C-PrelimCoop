﻿using System;
using System.Collections.Generic;

namespace mvczeke.Entities;

public partial class ClientInfo
{
    public int Id { get; set; }

    public int? UserType { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public int? ZipCode { get; set; }

    public DateTime? Birthdate { get; set; }

    public int? Age { get; set; }

    public string? NameofFather { get; set; }

    public string? NameofMother { get; set; }

    public string? Civilstatus { get; set; }

    public string? Religion { get; set; }

    public string? Occupation { get; set; }
}
