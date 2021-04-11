using Fignum.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FignumProject
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a bunch of digits separated by a coma: ");
            Console.WriteLine("Input should in format 9,3,6,4,12 ..........and so on...: ");
            
            var str = Console.ReadLine();

            Console.WriteLine("================================ ");

            Console.WriteLine($"original String ==  { str}");

            IFilterService stringService = new FilterService();
            AppSettings appSettings = new AppSettings();
            FilterResponse strResponse = new FilterResponse(str);

            // Filter Prime Numbers
            if (appSettings.ProcessFilterPrimeNumbers)
            {
                try
                {
                    strResponse = stringService.ProcessFilter(strResponse);

                    if (strResponse.Error.HasValue)
                        Console.WriteLine($"After filtering the prime numbers  ==  { strResponse.Error.ToString()}");

                    if (!string.IsNullOrEmpty(strResponse.InputString))
                        Console.WriteLine($"After filtering the prime numbers ==  { strResponse.InputString}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exceoption Occurred ==  { ex.InnerException.Message}");
                    Console.ReadLine();
                }                
            }
            //Apply sort 
            if (appSettings.ProcessSortDescending)
            {
                try {
                    strResponse = stringService.ProcessSort(strResponse);

                    if (strResponse.Error.HasValue)
                        Console.WriteLine($"After sorting in Descending order ==  { strResponse.Error.ToString()}");

                    if (!string.IsNullOrEmpty(strResponse.InputString))
                        Console.WriteLine($"After sorting in Descending order ==  { strResponse.InputString}");
                }
                catch(Exception ex) {
                    Console.WriteLine($"Exceoption Occurred ==  { ex.InnerException.Message}");
                    Console.ReadLine();
                }                
            }
            Console.ReadLine();
        }
    }
}
