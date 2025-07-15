namespace Clc.Api.Models
{
    public class InTransitItem
    {
        public int ItemRecordId { get; set; }
        public string Barcode { get; set; }
        public DateTime SentDate { get; set; }
    }
}
