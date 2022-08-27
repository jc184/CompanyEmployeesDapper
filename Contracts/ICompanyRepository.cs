﻿using Shared.DataTransferObjects;

namespace Contracts
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<CompanyDto>> GetAllCompanies();
        Task<CompanyDto> GetCompany(Guid id);
        Task<IEnumerable<CompanyWithEmployeesDto>> GetCompaniesWithEmployees();
        Task<CompanyDto> CreateCompany(CompanyForCreationDto company);
        Task<CompanyDto> CreateCompanyWithEmployees(CompanyForCreationDto company);
        Task<IEnumerable<CompanyDto>> GetByIds(IEnumerable<Guid> ids);
        Task<IEnumerable<CompanyDto>> CreateCompanyCollection(IEnumerable<CompanyForCreationDto> companies);

    }
}
