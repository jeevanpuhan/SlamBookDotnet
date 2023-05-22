using Microsoft.CodeAnalysis.CSharp.Syntax;
using SlamBook.Models;

namespace SlamBook.Util
{
	public static class FriendsList
	{
		private static List<Friend> friends = InitializeFriends();
        
		public static List<Friend> GetFriends()
		{
			return friends;
		}

		public static void AddFriend(Friend friend)
		{
			friends.Add(friend);
		}

        // method -> return the list of Friends
        public static List<Friend> InitializeFriends()
		{
			List<Friend> friendsList = new List<Friend>()
			{
				new Friend
				{
					FirstName = "Jhalak",
					LastName = "Pathak",
					Email = "jhalak@deloitte.com",
					Phone = "9115481245",
					Address = "Bangalore",
					FavouriteColor = "Yellow",
					BestFriend = "Archit"
				},
				new Friend
				{
					FirstName = "Jeevan",
					LastName = "Puhan",
					Email = "jpuhan@deloitte.com",
					Phone = "9853570711",
					Address = "Bangalore",
					FavouriteColor = "Blue",
					BestFriend = "Adarsh",
				},
				new Friend
				{
					FirstName = "Ram",
					LastName = "Verma",
					Email = "rverma@deloitte.com",
					Phone = "967345209",
					Address = "Udaipur",
					FavouriteColor = "Black",
					BestFriend = "Subash",
				}
			};

			return friendsList;
		}
	}
}
