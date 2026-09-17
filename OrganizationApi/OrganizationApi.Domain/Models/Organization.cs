namespace OrganizationApi.Domain.Models;

public class Organization
{
    public int OrganizationId { get; set; }

    public string? LegalId { get; set; }

    public string? LegalName { get; set; }

    public string? OrgId { get; set; }

    public int? OrgTypeEnum { get; set; }

    public string? AdministrativeId { get; set; }

    public bool? IsActive { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? VisualIdentity { get; set; }

    public string? LogoPictureUId { get; set; }

    public string? Url { get; set; }

    public DateTime? DateLastUpdate { get; set; }

    public int? EthnicTypeEnum { get; set; }

    public string? ReportHeaderFirstLine { get; set; }

    public string? ReportHeaderSecondLine { get; set; }
}
