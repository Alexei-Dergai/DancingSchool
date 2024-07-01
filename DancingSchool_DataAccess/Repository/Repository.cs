using DancingSchool_DataAccess.Data;
using DancingSchool_DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DancingSchool_DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        private readonly DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = db.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
