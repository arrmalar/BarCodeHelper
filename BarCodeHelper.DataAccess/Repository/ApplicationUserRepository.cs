﻿using BarCodeHelper.DataAccess.Data;
using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;

namespace BarCodeHelper.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ApplicationUser obj)
        {
            _db.ApplicationUsers.Update(obj);
        }
    }
}
