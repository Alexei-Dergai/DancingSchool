using DancingSchool_Models;

namespace DancingSchool_DataAccess.Repository.IRepository
{
    public interface IFeedBackRepository : IRepository<Feedback>
    {
        void Update(Feedback obj);
    }
}
