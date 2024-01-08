﻿using amazon_clone.DataAccess.Data;
using amazon_clone.Models.Models;

namespace amazon_clone.DataAccess.Repositories
{
    public class WishListRepository : Repository<WishList>, IWishListRepository
    {
        public WishListRepository(AppDbContext context):base(context) { }
        

        public void Update(WishList entity)
        {
            _context.Update(entity);
        }
    }
}