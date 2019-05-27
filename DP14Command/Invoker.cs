using System;
using System.Collections.Generic;

namespace DP14Command
{
    public class Invoker
    {
        private Dictionary<Guid, Command> command = new Dictionary<Guid, Command>();

        public void AddCommand(Command cmd)
        {
            if (!this.command.ContainsKey(cmd.CommandId))
                command.Add(cmd.CommandId, cmd);
            Console.WriteLine("命令已执行");
        }

        public void RemoveCommand(Command cmd)
        {
            if (this.command.ContainsKey(cmd.CommandId))
                this.command.Remove(cmd.CommandId);
        }

        public void ExecuteAllCommand()
        {
            if (NetWork.Online)
            {

                foreach (var item in command)
                {
                    item.Value.Execute();
                }
                this.command.Clear();
            }
            else
            {
                Console.WriteLine($"命令目前不执行，缓存在本地，本地命令为{command.Count}");
            }
        }
    }
}
