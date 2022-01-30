using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor.Domain.Entities;

namespace Vendor.Application.Contracts
{
    public interface IBankRepository
    {
        Task<IEnumerable<Bank>> GetAllBanksByCompany(string CompanyName);
        Task<IEnumerable<Bank>> GetAllBanksByCompanyId(int CompanyId);

        Task<Bank> GetBankById(int Id);
        Task<IEnumerable<Bank>> GetAllBanks (int Id);
        Task<Bank> AddBank(Bank Bank);
        Task<Bank> UpdateBank(Bank Bank);
        Task<Bank> DeleteBank(int BankId);


    }
}
