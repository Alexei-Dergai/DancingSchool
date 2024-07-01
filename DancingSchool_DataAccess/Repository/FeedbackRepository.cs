using DancingSchool_DataAccess.Data;
using DancingSchool_DataAccess.Repository.IRepository;
using DancingSchool_Models;
using System.Linq;

namespace DancingSchool_DataAccess.Repository
{
    public class FeedbackRepository : Repository<Feedback>, IFeedBackRepository
    {
        private readonly ApplicationDbContext _db;

        public FeedbackRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Feedback obj)
        {
            var objFromDb = _db.Feedback.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
            }
        }
    }
}
