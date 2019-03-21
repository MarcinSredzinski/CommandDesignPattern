using System;
using System.Collections.Generic;
using System.Text;

namespace CommandUI.Contracts
{
    public interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
