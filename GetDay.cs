using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class GetDay:Command
    {
        Date date;
        public GetDay(Date date)
        {
            this.date = date;
        }
        public void execute()
        {
            date.getDay();
        }
    }
}
