using System;

namespace DP14Command
{
    public abstract class Command
    {
        public abstract void Execute();

        public abstract Guid CommandId { get; }
    }
}
