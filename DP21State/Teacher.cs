using System.Collections.Generic;

namespace DP21State
{
    public class Teacher
    {
        private Dictionary<int, BodyState> _state = new Dictionary<int, BodyState>();

        public Teacher()
        {
            _state.Add(1, new GoodState());
            _state.Add(2, new BadState());
        }

        public void Teach(bool Good)
        {
            if (Good)
                _state[1].Work();
            _state[2].Work();
        }
    }
}
