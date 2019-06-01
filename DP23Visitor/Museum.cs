using System;

namespace DP23Visitor
{
    public abstract class Museum
    {
        public abstract void Accept(Visitor visitor);
    }
}
