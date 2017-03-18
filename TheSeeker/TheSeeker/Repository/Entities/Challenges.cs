using MongoRepository;

namespace TheSeeker.Repository.Entities
{
    public class Challenges : IEntity
    {
        public string Id { get; set; }

        public double Lat { get; set; }
        public double Long { get; set; }
        public double Description { get; set; }
    }
}