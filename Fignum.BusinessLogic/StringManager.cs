using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fignum.BusinessLogic
{
   public class FignumStringManager
    {
        public string InputString { get; set; }
        //public StringResponse ProcessString(IRepository repository)
        //{
        //    var error = ValidateInputString();
        //    if (error != null) return new StringResponse(error);
        //    string cleanString = FilterString(this);
        //    string cleanString = repository.SaveString(this);
        //    return new StringResponse(cleanString);
        //}
        //private StringError? ValidateInputString()
        //{
        //    var error = ValidateData();
        //    if (error != null) return error;
        //    bool validInput = HasNonIntegers();
        //    if (!validInput) return StringError.InputStringNotInteger;            
        //    return approvalError;
        //}
        //private StringError? FilterString()
        //{
        //    foreach (var session in Sessions)
        //    {
        //        session.Approved = !SessionIsAboutOldTechnology(session);
        //    }
        //    if (Sessions.Any(s => s.Approved)) return null;
        //    return RegisterError.NoSessionsApproved;
        //}
        //private StringError? ValidateData()
        //{
        //    if (string.IsNullOrEmpty(InputString)) return StringError.InputStringRequired;            
        //    return null;
        //}
        //private bool HasNonIntegers()
        //{
        //    //need to get just the domain from the email
        //    string emailDomain = Email.Split('@').Last();
        //    var ancientEmailDomains = new List<string>() { "aol.com", "prodigy.com", "compuserve.com" };
        //    return (ancientEmailDomains.Contains(emailDomain) || ((Browser.Name == WebBrowser.BrowserName.InternetExplorer && Browser.MajorVersion < 9)));
        //}
    }
}
