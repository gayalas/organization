using OrganizationApi.Domain.Models;

namespace OrganizationApi.Application.Interfaces;

public interface IDomainRepository
{
    Task<List<Domains>> GetAllAsync();
    Task<Domains?> UpdateByUIdAsync(string uId, Domains domain);
}