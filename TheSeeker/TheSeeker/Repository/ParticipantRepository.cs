using MongoRepository;
using TheSeeker.Repository.Entities;

namespace TheSeeker.Repository
{
    public class ParticipantRepository : MongoRepository<Challenges>
    {
        public static MongoRepository<Participant> participantrepo = new MongoRepository<Participant>();

        public void AddToParticipantDb(string code, string name, string mobile)
        {
            var participant = new Participant
            {
                Id = code,
                Code = code,
                Name = name,
                MobileNo = mobile
            };
            participantrepo.Add(participant);
        }

        public void GetByParticipantID(string code)
        {
            participantrepo.GetById(code);
        }
    }
}