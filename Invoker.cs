using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class Invoker
    {
        Command what;
        public void setCommand(Command command)
        {
            what = command;
        }
        public void doIt()
        {
            what.execute();
        }
    }
}
