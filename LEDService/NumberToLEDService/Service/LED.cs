using System;
using System.Collections.Generic;
using System.IO;
using NumberToLEDService.Service.Logging;
using LED_Service.Models;
using System.Linq;

namespace NumberToLEDService.Service
{
    public static class LED
    {
        public static LEDDisplayInfoModel[] GetDisplayInfo(decimal number)
        {

            LEDDisplayInfoModel value;
            List<LEDDisplayInfoModel> returnArray = new List<LEDDisplayInfoModel>();

          
            Decimal validDecimal;

            var isAValidNumber = Decimal.TryParse(number.ToString(), out validDecimal);

            if (isAValidNumber)
            {
                
                var listofInputs = new List<char>();
                listofInputs.AddRange(validDecimal.ToString());



                //Loop thru each character in the input.
                //Return the corresponding display info from the dictionary or "E" if none is found
                for (int index=0; index<listofInputs.Count(); index++)
                {
                    if (listofInputs[index] == '.')
                    {
                        //ignore it
                    }
                    else
                    {
                        var isNextADecimal = index == listofInputs.Count-1 ? false : listofInputs[index + 1] == '.';
                        returnArray.Add(Data.Data.GetDisplay(listofInputs[index], isNextADecimal));
                    }
                }
               
            }
            else
            {
                returnArray.Add(Data.Data.GetDisplay('E', false));
            }

            return returnArray.ToArray();
        }
    }
}