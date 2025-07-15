namespace Clc.Api.Models
{
    public class ApiKey
    {
        public int ID { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? ExpirationDate { get; set; }
        public List<string> Permissions { get; set; } = [];
    }
}
