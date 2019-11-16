using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spryng.Models
{
    public static class SpryngRoute
    {
        public const string BUSINESS = "BUSINESS";
        public const string ECONOMY = "ECONOMY";
        public const string CUSTOM_0 = "0";
        public const string CUSTOM_1 = "1";
        public const string CUSTOM_2 = "2";
        public const string CUSTOM_3 = "3";
        public const string CUSTOM_4 = "4";
        public const string CUSTOM_5 = "5";
        public const string CUSTOM_6 = "6";
        public const string CUSTOM_7 = "7";
        public const string CUSTOM_8 = "8";
        public const string CUSTOM_9 = "9";

        internal static readonly string[] VALID_ROUTES = new[]
        {
            BUSINESS,
            ECONOMY,
            CUSTOM_0,
            CUSTOM_1,
            CUSTOM_2,
            CUSTOM_3,
            CUSTOM_4,
            CUSTOM_5,
            CUSTOM_6,
            CUSTOM_7,
            CUSTOM_8,
            CUSTOM_9
        };
    }
}
