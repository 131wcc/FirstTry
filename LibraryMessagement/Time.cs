using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMessagement
{
    class Time
    {
        private int year;
        private int month;
        private int day;
        public string TimeNow;

        public Time()
        {
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            TimeNow = DateTime.Now.ToString("yyyy/MM/dd");
        }


        public Time(int aday)
        {
            int[] day30=new int[4] { 4,6,9,11 };
            int[] day31=new int[7] { 1,3,5,7,8,10,12 };

            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            day+=aday;

            here1:
	        for (int i = 0; i < 4; i++)
		        if (month == day30[i])
                    if (day > 30) { day -= 30; month += 1; goto here1; }			        
	        for (int i = 0; i < 7; i++)
		        if (month == day31[i])
                    if (day > 31) { day -= 31; month += 1; goto here1; }
	        if (month == 2)
	        {
		        if ((year % 100 == 0 && year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    if (day > 29) { day -= 29; month += 1; goto here1; }
                }
		        else
                {
                    if (day > 28) { day -= 28; month += 1; goto here1; }
                }
	        }

            if (month > 12) { month -= 12; year += 1; goto here1; }


            if (month < 10 && day < 10)
                TimeNow = year.ToString() + "/0" + month.ToString() + "/0" + day.ToString();
            else if (month < 10 && day >= 10)
                TimeNow = year.ToString() + "/0" + month.ToString() + "/" + day.ToString();
            else if (day < 10 && month >= 10)
                TimeNow = year.ToString() + "/" + month.ToString() + "/0" + day.ToString();
            else
                TimeNow = year.ToString() + "/" + month.ToString() + "/" + day.ToString();
	
        }
    }
}
