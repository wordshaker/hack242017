using MongoRepository;

namespace TheSeeker.Repository.Entities
{
    public class Challenge : IEntity
    {
        public string Id { get; set; }

        public string Map { get; set; }
        public string Description { get; set; }
    }
}