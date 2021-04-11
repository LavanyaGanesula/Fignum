using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fignum.BusinessLogic
{
    public abstract class ErrorDto
    {
        public bool? HasError { get; set; }
        public string Method { get; set; }
        public string ErrorMessage { get; set; }
    }
    
    
}
