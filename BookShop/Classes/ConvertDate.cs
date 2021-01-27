﻿using MD.PersianDateTime.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Classes
{
    public class ConvertDate : IConvertDate
    {
        public  DateTime ConvertShamsiToMiladi(string Date)
        {
            PersianDateTime persianDateTime =  PersianDateTime.Parse(Date);
            return persianDateTime.ToDateTime();
        }
        public string ConvertMiladiToShamsi(DateTime date,string Format)
        {
            PersianDateTime persianDateTime = new PersianDateTime(date);
            //return persianDateTime.ToString("dddd d MMMM yyyy ساعت hh:mm:ss tt");
            //return persianDateTime.ToString("dddd d MMMM yyyy");
            return persianDateTime.ToString(Format);

        }
    }
}
