namespace Clc.Api.Models
{
    public class OrganizationInfo
    {
        public int OrganizationID { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int OrganizationCodeID { get; set; }

        public int? ParentOrganizationID { get; set; }
        public string ParentName { get; set; }
        public string ParentAbbreviation { get; set; }
    }
}
