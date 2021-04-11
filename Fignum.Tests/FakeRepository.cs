using Fignum.BusinessLogic;

namespace CodeLuau.Tests
{
    class FakeRepository : IRepository
    {
        public string SaveString(StringResponse inputString)
        {
            if (inputString == null)
            {
                throw new System.ArgumentNullException(nameof(inputString));
            }
            // Simulate saving a cleaned string and returning the ID since this is a simiple fake repository.
            // return inputString.inputString;
            return "str";
        }
    }
}
