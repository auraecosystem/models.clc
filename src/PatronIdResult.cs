namespace Clc.Api.Models
{
    public class PatronIdResult : ClcApiResult
    {
        public int PatronId { get; set; }

        public override string ToString()
        {
            return PatronId > 0 ? PatronId.ToString() : $"{ErrorCode} : {ErrorMessage}";
        }
    }
}
