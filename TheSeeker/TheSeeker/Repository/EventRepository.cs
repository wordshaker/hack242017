using System.Collections.Generic;
using MongoRepository;
using TheSeeker.Repository.Entities;

namespace TheSeeker.Repository
{
    public class EventRepository : MongoRepository<Event>
    {
        public static MongoRepository<Event> eventrepo = new MongoRepository<Event>();

        public void AddToEventDb(string code, string id, string challenge)
        {
            var participant = new Event()
            {
                Id = code,
                Participants = new List<string> {id},
                ChallengesDone = new List<string> { challenge },
            };
            eventrepo.Add(participant);
        }

        public void AddToChallengeCompleteToEvent(string id, string challenge)
        {
            var @event = eventrepo.GetById(id);
            eventrepo.Update(eventrepo.GetById(id)).ChallengesDone.Add(challenge);
        }

        public void AddParticipantsEvent(string id, string participantId)
        {
            var @event = eventrepo.GetById(id);
            eventrepo.Update(eventrepo.GetById(id)).Participants.Add(participantId);
        }

        public void GetByParticipantID(string code)
        {
            eventrepo.GetById(code);
        }
    }
}