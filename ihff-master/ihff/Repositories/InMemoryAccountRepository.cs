using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ihff.Models;

namespace ihff.Repositories
{
    public class InMemoryAccountRepository : IAccountRepository
    {
        private List<Account> allAccounts;

        public InMemoryAccountRepository()
        {
            allAccounts = new List<Account>();
            allAccounts.Add(new Account(1, "Pathé", "Reserveringen@pathe.com", "pathe"));
            allAccounts.Add(new Account(2, "test", "test", "test"));
            allAccounts.Add(new Account(3, "Theater", "Sales@theater.com", "theater"));
        }

        public Account GetAccount(string email, string password)
        {
            return allAccounts.SingleOrDefault(a => a.Email == email && a.Password == password);   
        }
    }
}