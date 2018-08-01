using LED_Service.Models;
using System.Collections.Generic;

namespace NumberToLEDService.Data
{
    public static class Data
    {
        private static Dictionary<char, LEDDisplayInfoModel> mydict;

        public static void Init()
        {
            mydict = new Dictionary<char, LEDDisplayInfoModel>()
            {
                { '-', new LEDDisplayInfoModel { Middle = true} },
                { '0', new LEDDisplayInfoModel { Top = true, TopLeft = true, TopRight = true, BottomLeft = true, BottomRight = true, Bottom = true }},
                { '1', new LEDDisplayInfoModel { TopRight = true,  BottomRight = true } },
                { '2', new LEDDisplayInfoModel { Top = true, TopRight = true, Middle=true, BottomLeft = true, Bottom = true } },
                { '3', new LEDDisplayInfoModel { Top = true,  TopRight = true, Middle=true,  BottomRight = true, Bottom = true } },
                { '4', new LEDDisplayInfoModel { TopLeft = true, TopRight = true, Middle=true,  BottomRight = true } },
                { '5', new LEDDisplayInfoModel { Top = true, TopLeft = true, Middle=true, BottomRight = true, Bottom = true } },
                { '6', new LEDDisplayInfoModel { TopLeft = true, Middle=true,  BottomLeft = true, BottomRight = true, Bottom = true } },
                { '7', new LEDDisplayInfoModel { Top = true,  TopRight = true, BottomRight = true} },
                { '8', new LEDDisplayInfoModel { Top = true, TopLeft = true, TopRight = true, Middle=true, BottomLeft = true, BottomRight = true, Bottom = true } },
                { '9', new LEDDisplayInfoModel { Top = true, TopLeft = true, TopRight = true, Middle=true,  BottomRight = true } },
                { 'E', new LEDDisplayInfoModel { Top = true, TopLeft = true, Middle=true,  BottomLeft = true, Bottom = true } },
            };         
           
        }

        public static LEDDisplayInfoModel GetDisplay(char digit, bool includeDecimal)
        {
            if (mydict == null)
                Init();

            LEDDisplayInfoModel value;
            if (mydict.TryGetValue(digit, out value))
            {
                value.Dot = includeDecimal;
                return value;
            }
            else
            {
                return mydict['E'];
            }
        }
    }
}