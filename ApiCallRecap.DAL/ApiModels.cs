namespace ApiCallRecap.DAL
{
    public class AddressModel
    {
        public string? Address { get; set; }
        public string? City { get; set; }
        public CoordinatesModel? Coordinates { get; set; }
        public string? PostalCode { get; set; }
        public string? State { get; set; }
    }

    public class BankModel
    {
        public string? CardExpire { get; set; }
        public string? CardNumber { get; set; }
        public string? CardType { get; set; }
        public string? Currency { get; set; }
        public string? Iban { get; set; }
    }

    public class CompanyModel
    {
        public AddressModel? Address { get; set; }
        public string? Department { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
    }

    public class CoordinatesModel
    {
        public double? Lat { get; set; }
        public double? Lng { get; set; }
    }

    public class HairModel
    {
        public string? Color { get; set; }
        public string? Type { get; set; }
    }

    public class RootModel
    {
        public List<UserModel>? Users { get; set; }
        public int? Total { get; set; }
        public int? Skip { get; set; }
        public int? Limit { get; set; }
    }

    public class UserModel
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MaidenName { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? BirthDate { get; set; }
        public string? Image { get; set; }
        public string? BloodGroup { get; set; }
        public int? Height { get; set; }
        public double? Weight { get; set; }
        public string? EyeColor { get; set; }
        public HairModel? Hair { get; set; }
        public string? Domain { get; set; }
        public string? Ip { get; set; }
        public AddressModel? Address { get; set; }
        public string? MacAddress { get; set; }
        public string? University { get; set; }
        public BankModel? Bank { get; set; }
        public CompanyModel? Company { get; set; }
        public string? Ein { get; set; }
        public string? Ssn { get; set; }
        public string? UserAgent { get; set; }
    }


}
