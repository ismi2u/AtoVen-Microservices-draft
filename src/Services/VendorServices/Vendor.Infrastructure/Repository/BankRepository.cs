using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor.Application.Contracts;
using Vendor.Domain.Entities;
using Vendor.Infrastructure.Data;

namespace Vendor.Infrastructure.Repository
{
    public class BankRepository : IBankRepository
    {
        private readonly AtoVenDbContext _context;
        public BankRepository(AtoVenDbContext context)
        {
             _context = context;
        }

        public Task<Bank> AddBank(Bank Bank)
        {
            throw new NotImplementedException();
        }

        public Task<Bank> DeleteBank(int BankId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bank>> GetAllBanks(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bank>> GetAllBanksByCompany(string CompanyName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bank>> GetAllBanksByCompanyId(int CompanyId)
        {
            throw new NotImplementedException();
        }

        public Task<Bank> GetBankById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Bank> UpdateBank(Bank Bank)
        {
            throw new NotImplementedException();
        }
    }
}
