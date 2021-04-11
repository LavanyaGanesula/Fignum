using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FignumProject
{
    public class AppSettings
    {
    
        public const string FilterPrimeNumbers = "FilterPrimeNumbers";
        public const string SortDescending = "SortDescending";        
        public bool ProcessFilterPrimeNumbers
        {
            get
            {
                string filterPrimeNumbers = ConfigurationManager.AppSettings[AppSettings.FilterPrimeNumbers];
                return string.IsNullOrEmpty(filterPrimeNumbers) ? false : Convert.ToBoolean(filterPrimeNumbers);
            }
        }
        public bool ProcessSortDescending
        {
            get
            {
                string SortDescending = ConfigurationManager.AppSettings[AppSettings.SortDescending];
                return string.IsNullOrEmpty(SortDescending) ? false : Convert.ToBoolean(SortDescending);
            }
        }
    }
    
}
