namespace Fignum.BusinessLogic
{
	public class FilterResponse
	{
		public FilterResponse(string inputString)
		{
			this.InputString = inputString;
		}

		public FilterResponse(StringError? error)
		{
			this.Error = error;
		}

		public string InputString { get; set; }
		public StringError? Error { get; set; }
	}

	public enum StringError
    {
		InputStringRequired,
		InputStringNotInteger		
	};
}