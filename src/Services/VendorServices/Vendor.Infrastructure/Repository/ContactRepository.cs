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
    public class ContactRepository : IContactRepository
    {
        private readonly AtoVenDbContext _context;
        public ContactRepository(AtoVenDbContext context)
        {
            _context = context;
        }

        public Task<Contact> AddContact(Contact Contact)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> DeleteContact(int ContactId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAllContactsByCompany(string ContactName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAllContactsByCompanyId(int ContactId)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetContactById(int ContactId)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> UpdateContact(Contact Contact)
        {
            throw new NotImplementedException();
        }
    }
}
