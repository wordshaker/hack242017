using System.Collections.Generic;
using MongoRepository;

namespace TheSeeker.Repository.Entities
{
    public class Event : IEntity
    {
        public string Id { get; set; }

        public List<string> Participants { get; set; }

        public List<string> ChallengesDone { get; set; }

    }
}