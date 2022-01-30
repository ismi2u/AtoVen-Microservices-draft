using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor.Domain.Entities;

namespace Vendor.Application.Contracts
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAllContactsByCompany(string ContactName);
        Task<IEnumerable<Contact>> GetAllContactsByCompanyId(int ContactId);
        Task<Contact> GetContactById(int ContactId);

        Task<Contact> AddContact(Contact Contact);
        Task<Contact> UpdateContact(Contact Contact);
        Task<Contact> DeleteContact(int ContactId);

    }
}
