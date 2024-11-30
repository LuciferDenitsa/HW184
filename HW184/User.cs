using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HW184.Interfaces;

namespace HW184
{
    internal class User
    {
        Icommand _command;

        public void SetCommand(Icommand command)
        {
            this._command = command;
        }

        public void RunCommand()
        {
            _command.Run();
        }

    }
}