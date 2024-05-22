using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Employee
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FatherName { get; set; }

    public string? Nationality { get; set; }

    public string? Sex { get; set; }

    public string? MaritalStatus { get; set; }

    public int? SocialSecurityNumber { get; set; }

    public string? PanCardNumber { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? PlaceOfBirth { get; set; }

    public short? HouseNo { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public int? PinCode { get; set; }

    public byte? PeriodOfStay { get; set; }

    public int? Telephone { get; set; }

    public int? MobilePhone { get; set; }

    public string? EmailId { get; set; }

    public string? InstantMessagingSystemId { get; set; }

    public byte[]? PhotoImage { get; set; }
}
