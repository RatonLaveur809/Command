using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class Distance:Command
    {
        Date date;
        public Distance(Date date)
        {
            this.date = date;
        }
        public void execute()
        {
            date.getDistance();
        }
    }
}
