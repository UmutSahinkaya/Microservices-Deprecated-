namespace Web.Models
{
    public class ServiceApiSettings
    {
        public string IdentityBaseUri { get; set; }
        public string GatewayBaseUri { get; set; }
        public string PhotoStockApiUri { get; set; }
        public ServiceApi Catalog { get; set; }
    }
    public class ServiceApi
    {
        public string Path { get; set; }
    }
}
