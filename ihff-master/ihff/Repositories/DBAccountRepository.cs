using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ihff.Models;

namespace ihff.Repositories
{
    class DBAccountRepository : IAccountRepository
    {
		
		private DBContext db = new DBContext();
		
        public Account GetAccount(string email, string password)
        {
            Account Account = this.db.Accounts.FirstOrDefault(a => a.Email == email && a.Password == password);
			return Account;
        }
    }

}