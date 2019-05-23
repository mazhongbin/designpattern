using System;

namespace DP11Proxy
{
    public class Classmate : IGirlFriend
    {
        private SchoolFlower sf = new SchoolFlower();
        public void WatchFilm()
        {
            Console.WriteLine("先铺垫");
            Console.WriteLine("再动员");
            sf.WatchFilm();
            Console.WriteLine("红娘工作完成");
        }
    }
}
