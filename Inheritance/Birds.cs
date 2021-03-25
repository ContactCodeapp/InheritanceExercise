using System;
namespace Inheritance
{
    public class Birds : Animals
    {
        public Birds()
        {
        }

        public int Wings { get; set; }
        public string CanFly { get; set; }
        public string LayEggs { get; set; }
        public string Beak { get; set; }

    }
}
