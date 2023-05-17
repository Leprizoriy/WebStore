using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.DataAccess.Data;
using WebStore.DataAccess.Repository.IRepository;
using WebStore.Models;

namespace WebStore.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
