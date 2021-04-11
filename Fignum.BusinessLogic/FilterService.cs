using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fignum.BusinessLogic
{  

    public class FilterService : IFilterService
    {
        public FilterResponse ProcessFilter(FilterResponse stringResponse)
        {
            var error = ValidateInputString(stringResponse.InputString);
            if (error != null) return new FilterResponse(error);
            FilterResponse cleanString = FilterString(stringResponse.InputString);            
            return cleanString;
        }
        public FilterResponse ProcessSort(FilterResponse stringResponse)
        {
            var error = ValidateInputString(stringResponse.InputString);
            if (error != null) return new FilterResponse(error);            
            FilterResponse cleanString = SortString(stringResponse.InputString);
            return cleanString;
        }
        private FilterResponse SortString(string inputString)
        {
            FilterResponse stringResponse = new FilterResponse(inputString);
            int[] iaArr = inputString.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            iaArr = iaArr.OrderByDescending(c => c).ToArray();
            String sortString = string.Empty; 
            foreach (int ia in iaArr)
            {
                if (string.IsNullOrEmpty(sortString))
                    sortString = ia.ToString();
                else
                     sortString = sortString + "," + ia.ToString();
            }
            stringResponse.InputString = sortString;
            return stringResponse;
        }
        private FilterResponse FilterString(string inputString)
        {
            FilterResponse stringResponse = new FilterResponse(inputString);            
            int[] iaArr = inputString.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                       
            string cleanString = string.Empty;
            foreach (int ia in iaArr )
            {
                if (!IsPrime(ia))
                {
                    if (string.IsNullOrEmpty(cleanString))
                        cleanString =  ia.ToString();
                    else 
                        cleanString = cleanString + "," + ia.ToString();
                }                                    
            }
             stringResponse.InputString = cleanString;
            return stringResponse;
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        private StringError? ValidateInputString(string inputString)
        {
            var error = ValidateData(inputString);
            if (error != null) return error;
            bool validInput = HasNonIntegers(inputString);
            if (!validInput) return StringError.InputStringNotInteger;
            return null; 
        }
       
        private StringError? ValidateData(string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) return StringError.InputStringRequired;
            return null;
        }
        private bool HasNonIntegers(string inputString)
        {
            inputString = inputString.Replace(",", "");
            if (inputString.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}
