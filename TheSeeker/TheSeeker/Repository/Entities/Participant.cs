using MongoRepository;

namespace TheSeeker.Repository.Entities
{
    public class Participant : IEntity
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string AccessToken { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
    }
}