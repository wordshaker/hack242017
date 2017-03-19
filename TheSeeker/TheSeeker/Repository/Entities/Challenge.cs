using MongoRepository;

namespace TheSeeker.Repository.Entities
{
    public class Challenge : IEntity
    {
        public string Id { get; set; }

        public string Lat { get; set; }
        public string Long { get; set; }
        public string Description { get; set; }
    }
}