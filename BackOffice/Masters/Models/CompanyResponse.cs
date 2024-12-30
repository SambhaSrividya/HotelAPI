namespace BackOffice.Masters.Models
{
    public class CompanyResponse
    {
        public CompanyDetails companydetails {  get; set; }
        public Roles roles { get; set; }
        public Services services { get; set; }
        public Error Error { get; set; }

    }
}
