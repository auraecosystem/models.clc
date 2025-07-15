using Microsoft.AspNetCore.Mvc;

namespace Clc.Api.Models
{
    public class ClcApiResult
    {
        public int ErrorCode { get; set; } = 0;
        public string ErrorMessage { get; set; } = string.Empty;

        public ClcApiResult()
        {
            
        }

        public ClcApiResult(PatronIdResult patronIdResult)
        {
            ErrorCode = patronIdResult.ErrorCode;
            ErrorMessage = patronIdResult.ErrorMessage;
        }

        public static NotFoundObjectResult PatronIdNotFoundResult(string barcode) => new(new ClcApiResult { ErrorCode = -3000, ErrorMessage = $"No patron found for barcode {barcode}" });

        public override string ToString() => $"{ErrorCode} - {ErrorMessage}";
    }

    public class PatronIdNotFoundResult : ClcApiResult
    {
        public PatronIdNotFoundResult(string barcode)
        {
            ErrorCode = -3000;
            ErrorMessage = $"No patron found for barcode {barcode}";
        }
    }
}
