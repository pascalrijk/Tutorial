using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ihff.Models;

namespace ihff.Repositories
{
    public class InMemoryWishlistRepository : IWishlistRepository
    {

        private List<Wishlist> allWishlists;
        public InMemoryWishlistRepository()
        {
            allWishlists = new List<Wishlist>();
        }
    }
}