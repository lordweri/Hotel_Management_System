﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Business
{
    public class DateRange
    {
        private DateTime Start;
        private DateTime End;


        public DateRange(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }

        public int GetNumberOfDays()
        {
            return (End - Start).Days;
        }

        public DateTime GetStart()
        {
            return Start;
        }

        public DateTime getEnd()
        {
            return End;
        }
    }
}
