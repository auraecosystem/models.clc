namespace Clc.Api.Models
{
    public class AddNonBlockingNoteData
    {
        public string Note { get; set; } = string.Empty;

        public AddNonBlockingNoteData()
        {
            
        }

        public AddNonBlockingNoteData(string note)
        {
            Note = note;
        }
    }
}
