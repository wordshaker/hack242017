using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using com.esendex.sdk.messaging;
using Cronofy;
using TheSeeker.Models;
using TheSeeker.Repository;
using TheSeeker.ViewModel;

namespace TheSeeker.Controllers
{
    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        private MessagingService _messagingService = new MessagingService("code.jessw@gmail.com", "womenintech");
        private Dictionary<string, Participant> _participantDetails = new Dictionary<string, Participant>();
        private CronofyOAuthClient _cronofyOAuth = new CronofyOAuthClient("HhJWCcEe6z74NAALOsGUpEXbo8ORoNTW",
                "WWgkGCZ_M2Zo4BvRZCJhgKVUi7ZGv2rCIHsXqXDsaP18sHkkwda3H3B4-GYd0x-cxnAu5xXm1Xy_0jjtGEyO2A");

        private string _oauthAccountIdCallbackUrl = String.Format("{0}/availability/AccountId",
            ConfigurationManager.AppSettings["domain"]);

        private string _refreshToken;
        private string _accessToken;

        public ActionResult Index()
        {
            return View();
        }

        [Route("congrats")]
        public ActionResult Congrats()
        {

            return View();
        }

        [Route("signup")]
        public ActionResult SignUp()
        {
               return View();
        }

        [Route("challenge")]
        public ActionResult Challenge()
        {
        //    ViewBag.Number = Request.QueryString.Get("id"); 
            return View();
        }

        [Route("challenge")]
        public ActionResult Challenge2()
        {
            //    ViewBag.Number = Request.QueryString.Get("id"); 
            return View();
        }

        [Route("challenge")]
        public ActionResult Challenge3()
        {
            //    ViewBag.Number = Request.QueryString.Get("id"); 
            return View();
        }

        [Route("confirmation")]
        public ActionResult Confirmation()
        {
            var code = Request.QueryString.Get("code");
            var participantdetails = Request.QueryString.Get("state");
            var blobl = participantdetails.Split('_');
          //  _accessToken = _cronofyOAuth.GetTokenFromCode(code, "https://api.cronofy.com/oauth/token").AccessToken;
            var participant = new TheSeeker.Repository.Entities.Participant
            {
                Id = code,
                Code = code,
                AccessToken = _accessToken,
                Name = blobl[0],
                MobileNo = blobl[1]
            };
            _participantDetails.Add(code, new Participant {Name = blobl[0], MobileNo = blobl[1]});
            ParticipantRepository.participantrepo.Add(participant);

            //return View(new Availability
            //{
            //    AuthUrl = _cronofyOAuth.GetAuthorizationUrlBuilder(_oauthAccountIdCallbackUrl).ToString(),
            //    AccountId1 = new CronofyAccountClient(_accessToken).GetAccount().Id,
            //    RequiredParticipants = "all",
            //    Duration = 60,
            //    Start = DateTime.Now.Date.AddDays(1),
            //    End = DateTime.Now.Date.AddDays(2),
            //});
            _messagingService.SendScheduledMessage(new SmsMessage("07446335493", "You have signed up to be totally bodacious", "EX0226394"), System.DateTime.Now.AddSeconds(5));

            //string url = "http://magicalmysterytourhack24.azurewebsites.net/home/challenge"; //need to know how to make this into a workable textable limnk
                                                                                           //
            string url = "http://magicalmysterytourhack24.azurewebsites.net/home/challenge"; //need to know how to make this into a workable textable limnk

            string message = $"To find out about your first most excellent adventure go to: {url}";
            //_messagingService.SendScheduledMessage(new SmsMessage("07446335493", $"Hello! {url}", "EX0226394"), System.DateTime.Now.AddMinutes(20));
            _messagingService.SendScheduledMessage(new SmsMessage("07446335493", message, "EX0226394"), System.DateTime.Now.AddSeconds(10));

            return View();
        }
    }
}