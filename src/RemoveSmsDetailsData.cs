namespace Clc.Api.Models
{
    public class RemoveSmsDetailsData
    {
        public string Note { get; set; } = string.Empty;

        public RemoveSmsDetailsData()
        {
            
        }

        public RemoveSmsDetailsData(string note)
        {
            Note = note;
        }
    }
}
