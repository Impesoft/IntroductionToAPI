using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApi.Helpers
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime date)
        {
            int age = (int)((DateTime.Now - date).Days / 365.25);
            return age;
        }
    }
}