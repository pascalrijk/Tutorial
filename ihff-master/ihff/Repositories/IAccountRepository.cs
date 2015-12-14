using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ihff.Models;

namespace ihff.Repositories
{
    interface IAccountRepository
    {
        Account GetAccount(string email, string password);
    }
}