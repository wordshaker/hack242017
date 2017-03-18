using System.Collections.Generic;
using System.Web.Mvc;
using com.esendex.sdk.messaging;

namespace TheSeeker.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public void AwaitingMembers(string name, string mobileNumber)
        {
            //pair{{iteration, challengeid}}
            var pairChallengeMattrix = new Dictionary<int, Dictionary<int, int>>();
            pairChallengeMattrix.Add(1, new Dictionary<int, int> {{1, 1}, {2, 3}, {3, 2}});
            pairChallengeMattrix.Add(2, new Dictionary<int, int> {{1, 2}, {2, 1}, {3, 3}});
            pairChallengeMattrix.Add(3, new Dictionary<int, int> {{1, 3}, {2, 1}, {3, 2}});

            foreach (var x in pairChallengeMattrix)
            {
                // finding out when they are free
                // create calander events

                foreach (var y in pairChallengeMattrix)
                {
                    var messagingService = new MessagingService("username", "password");
                    // pull in times to send and set them.
                    // this needs to take a list of numbers later ie.e
                    //messagingService.SendScheduledMessages(new SmsMessageCollection("Hello!", "accountRef"), System.DateTime.Now.AddMinutes(20));
                    string url = "www.google.com"; //need to know how to make this into a workable textable limnk
                    messagingService.SendScheduledMessage(new SmsMessage("07446335493", $"Hello! {url}", "accountRef"),
                        System.DateTime.Now.AddMinutes(20));
                    // need to insert the
                }
            }

        }
    }
}