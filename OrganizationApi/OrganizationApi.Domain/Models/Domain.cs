namespace OrganizationApi.Domain.Models;

public class Domains
{
    public int DomainId { get; set; }

    public string? Name { get; set; }

    public string UId { get; set; }

    public string DisplayName { get; set; }

    public string TimeZoneId { get; set; }

    public string CultureCode { get; set; }
}