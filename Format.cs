using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class Format : Command
    {
        Date date;
        public Format(Date date)
        {
            this.date = date;
        }
        public void execute()
        {
            date.getFormattedDate();
        }
    }
}
