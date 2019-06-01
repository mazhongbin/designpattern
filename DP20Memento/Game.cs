using System;
using System.Threading;

namespace DP20Memento
{
    public class Game : IOriginator
    {
        private int _life = 100;

        public void Fight()
        {
            Thread.Sleep(1000);
            _life = new Random().Next(100);
        }

        public void Load(Memento memento)
        {
            _life = memento.Life;
        }

        public Memento Save()
        {
            return new Memento { Life = _life };
        }

        public override string ToString()
        {
            return $"当前生命值：{_life},游戏结束：{_life < 1}";
        }
    }
}
