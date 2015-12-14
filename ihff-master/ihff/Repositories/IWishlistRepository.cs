using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ihff.Models;

namespace ihff.Repositories
{
    interface IWishlistRepository
    {
        Wishlist findByEmail(string email);
        Wishlist findByCode(string code);
        List<Wishlist> allWishlists();
    }
}
