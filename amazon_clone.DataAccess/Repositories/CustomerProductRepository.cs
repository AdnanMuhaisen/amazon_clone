﻿using amazon_clone.DataAccess.Data;
using amazon_clone.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace amazon_clone.DataAccess.Repositories
{
    public class CustomerProductRepository : Repository<CustomerProduct>, ICustomerProductRepository
    {
        public CustomerProductRepository(AppDbContext context):base(context) { }
        
        public void Update(CustomerProduct entity)
        {
            _context.Attach(entity);

            _context.Entry(entity)
                .Property(x => x.CustomerProductID)
                .IsModified = false;      

            _context.Entry(entity).State = EntityState.Modified;

            _context.Update(entity);
        }
    }
}
