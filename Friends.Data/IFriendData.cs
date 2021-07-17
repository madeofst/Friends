using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Friends.Data
{
    public interface IFreindData
    {
        IEnumerable<Friend> GetFriends();
    }

    public class InMemoryFriendData : IFreindData
    {
        readonly List<Friend> friends;

        public IFriendData()
        {
            friends = new List<Friend>()
            {
                new Friend { Id = 1, Name = "Colin", Age = 49, Hometown="Wisconsin", CharacterType = CharacterType.DungeonMaster },
                new Friend { Id = 2, Name = "Sandra", Age = 22, Hometown="Corby", CharacterType = CharacterType.Partridge },
                new Friend { Id = 3, Name = "Alfalfa", Age = 30, Hometown="London", CharacterType = CharacterType.Dweeb },
                new Friend { Id = 4, Name = "Zip", Age = 188, Hometown="The Moon", CharacterType = CharacterType.None }
            };
        }

        public IEnumerable<Friends> GetFriends()
        {
            return friends.OrderBy(f => f.Name).ToList();
        }
    }

}