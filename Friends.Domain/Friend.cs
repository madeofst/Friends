using System;

namespace Friends.Domain
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
        public CharacterType CharacterType { get; set; }
    }
}
