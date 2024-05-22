namespace WebApplication1.Models
{
    public class FormModel
    {
        public long ID { get; set; }
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
        public short? HouseNO { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? PinCode { get; set; }
        public byte? PeriodOfStay { get; set; }
        public int? Telephone { get; set; }
        public int? MobilePhone { get; set; }
        public string? EmailID { get; set; }
        public string? InstantMessagingSystemID { get; set; }
        public IFormFile PhotoImage { get; set; }
    }
}