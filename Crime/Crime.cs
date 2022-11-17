using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crime
{
    public class Crime
    {
        public string type;
        public string year, month, day, hour, minute;
        public string hundred_block, neighbourhood;
        public string x, y;
        public string latitude, longitude;

        public Crime(string type, string year, string month, string day, string hour, string minute, string hundred_block, string neighbourhood, string x, string y, string latitude, string longitude)
        {
            this.type = type;
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
            this.hundred_block = hundred_block;
            this.neighbourhood = neighbourhood;
            this.x = x;
            this.y = y;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public Crime()
        {
            this.type = "";
            this.year = "";
            this.month = "";
            this.day = "";
            this.hour = "";
            this.minute = "";
            this.hundred_block = "";
            this.neighbourhood = "";
            this.x = "";
            this.y = "";
            this.latitude = "";
            this.longitude = "";
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}", type, year, month, day, hour, minute, hundred_block, neighbourhood, x, y, latitude, longitude);
        }
    }
}
