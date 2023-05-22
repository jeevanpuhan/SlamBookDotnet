using Microsoft.AspNetCore.Mvc;
using SlamBook.Models;
using SlamBook.Util;
using System.Diagnostics;

namespace SlamBook.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			List<Friend> friends = FriendsList.GetFriends();

			return View(friends);
		}

		public IActionResult GetFriends()
		{
            List<Friend> friends = FriendsList.GetFriends();

            return View(friends);
        }

		[HttpGet]
		public IActionResult AddFriend()
		{

			return View();
		}

		[HttpPost]
        public IActionResult AddFriend(Friend friend)
        {
			FriendsList.AddFriend(friend);

			return RedirectToAction("Index");
        }

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}