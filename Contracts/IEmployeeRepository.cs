﻿using Shared.DataTransferObjects;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeDto>> GetEmployees(Guid companyId);
        Task<EmployeeDto> GetEmployee(Guid companyId, Guid id);
    }

}