﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor.Domain.Entities;

namespace Vendor.Application.Contracts
{
    public interface ICompanyRepository 
    {
        Task<IEnumerable<Company>> GetAllCompanies();
        Task<Company> GetCompanyById(int CompanyId);
        Task<Company> AddCompany(Company Company);
        Task<Company> UpdateCompany(Company Company);
        Task<Company> DeleteCompany(int CompanyId);
    }
}
