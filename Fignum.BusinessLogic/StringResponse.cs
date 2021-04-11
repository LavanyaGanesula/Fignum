namespace Fignum.BusinessLogic
{
	public class StringResponse
	{
		public StringResponse(string inputString)
		{
			this.InputString = inputString;
		}

		public StringResponse(StringError? error)
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