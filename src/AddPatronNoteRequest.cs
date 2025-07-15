namespace Clc.Api.Models
{
    public class AddPatronNoteRequest
    {
        public int PatronId { get; set; }
        public string PatronBarcode { get; set; }
        public string Note { get; set; }
    }
}
