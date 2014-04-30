using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Command.SimpleRemoteControl
{
    public class RemoteControl
    {
        private ICommand[] OnCommands { get; set; }
        private ICommand[] OffCommands { get; set; }

        public RemoteControl()
        {
            OnCommands = new ICommand[7];
            OffCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            OnCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            OffCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < OnCommands.Length; i++)
            {
                stringBuilder.AppendFormat("[slot {0}] {1} {2}\n", i, OnCommands[i], OffCommands[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
