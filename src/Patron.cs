namespace Clc.Api.Models
{
    public class Patron
    {
        public int PatronID { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public int AssignedBranchID { get; set; }
        public int AssignedLibraryID { get; set; }
        public string NameFirst { get; set; } = string.Empty;
        public string NameLast { get; set; } = string.Empty;
        public int DeliveryOptionID { get; set; }
        public int TxtPhoneNumber { get; set; }
        public string PhoneVoice1 { get; set; } = string.Empty;
        public int Phone1CarrierID { get; set; }
        public string PhoneVoice2 { get; set; } = string.Empty;
        public int Phone2CarrierID { get; set; }
        public string PhoneVoice3 { get; set; } = string.Empty;
        public int Phone3CarrierID { get; set; }
        public string EmailAddress { get; set; } = string.Empty;
        public string AltEmailAddress { get; set; } = string.Empty;
        public int EReceiptOptionID { get; set; }
        public bool AdditionalTxtEnabled { get; set; }

        public override string ToString() => $"{PatronID} - {Barcode} - {NameFirst} - {NameLast}";
        
    }
}
