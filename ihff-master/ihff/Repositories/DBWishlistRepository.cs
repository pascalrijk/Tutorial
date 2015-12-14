using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ihff.Models;

namespace ihff.Repositories
{
    public class DBWishlistRepository : IWishlistRepository
    {
        private DBContext context = new DBContext();


        public Wishlist findByEmail(string email)
        {
            return context.Wishlists.SingleOrDefault(w => w.Email == email);
        }

        public Wishlist findByCode(string code)
        {
            return context.Wishlists.SingleOrDefault(w => w.Code == code);
        }

        public List<Wishlist> allWishlists()
        {
            return context.Wishlists.ToList();
        }
    }
}