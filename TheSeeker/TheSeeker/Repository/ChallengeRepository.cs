using MongoRepository;
using TheSeeker.Repository.Entities;

namespace TheSeeker.Repository
{
    public class ChallengeRepository : MongoRepository<Challenge>
    {
        public static MongoRepository<Challenge> challengerepo = new MongoRepository<Challenge>();

        public void GetByChallengeID(string id)
        {
            challengerepo.GetById(id);
        }
    }
}