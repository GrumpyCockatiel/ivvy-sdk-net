using System;
using System.Collections.Generic;

namespace Ivvy.API
{
	/// <summary>
	/// A dictionary of all US State codes.
	/// </summary>
	public static class TZDictionary
	{
		public static Dictionary<string, TimeSpan> TZ = null;

		static TZDictionary()
		{
			TZ = new Dictionary<string, TimeSpan>();

			//TZ.Add("AL", "Alabama");
			//TZ.Add("AK", "Alaska");
			//TZ.Add("AZ", "Arizona");
			//TZ.Add("AR", "Arkansas");
			//TZ.Add("CA", "California");
			//TZ.Add("CO", "Colorado");
			//TZ.Add("CT", "Connecticut");
			//TZ.Add("DE", "Delaware");
			//TZ.Add("DC", "District Of Columbia");
			//TZ.Add("FL", "Florida");
			//TZ.Add("GA", "Georgia");
			//TZ.Add("HI", "Hawaii");
			//TZ.Add("ID", "Idaho");
			//TZ.Add("IL", "Illinois");
			//TZ.Add("IN", "Indiana");
			//TZ.Add("IA", "Iowa");
			//TZ.Add("KS", "Kansas");
			//TZ.Add("KY", "Kentucky");
			//TZ.Add("LA", "Louisiana");
			//TZ.Add("ME", "Maine");
			//TZ.Add("MD", "Maryland");
			//TZ.Add("MA", "Massachusetts");
			//TZ.Add("MI", "Michigan");
			//TZ.Add("MN", "Minnesota");
			//TZ.Add("MS", "Mississippi");
			//TZ.Add("MO", "Missouri");
			//TZ.Add("MT", "Montana");
			//TZ.Add("NE", "Nebraska");
			//TZ.Add("NV", "Nevada");
			//TZ.Add("NH", "New Hampshire");
			//TZ.Add("NJ", "New Jersey");
			//TZ.Add("NM", "New Mexico");
			//TZ.Add("NY", "New York");
			//TZ.Add("NC", "North Carolina");
			//TZ.Add("ND", "North Dakota");
			//TZ.Add("OH", "Ohio");
			//TZ.Add("OK", "Oklahoma");
			//TZ.Add("OR", "Oregon");
			//TZ.Add("PA", "Pennsylvania");
			//TZ.Add("RI", "Rhode Island");
			//TZ.Add("SC", "South Carolina");
			//TZ.Add("SD", "South Dakota");
			//TZ.Add("TN", "Tennessee");
			//TZ.Add("TX", "Texas");
			//TZ.Add("UT", "Utah");
			//TZ.Add("VT", "Vermont");
			//TZ.Add("VA", "Virginia");
			//TZ.Add("WA", "Washington");
			//TZ.Add("WV", "West Virginia");
			//TZ.Add("WI", "Wisconsin");
			//TZ.Add("WY", "Wyoming");
		}

		/// <summary>
		/// Gets the code.
		/// </summary>
		/// <returns>The code.</returns>
		/// <param name="state">State.</param>
		//public static string GetCode(string state)
		//{
		//	if (String.IsNullOrWhiteSpace(state))
		//		return null;

		//	return States.Values.Where(v => v.Equals(state, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

		//}

		///// <summary>
		///// Is the code valid
		///// </summary>
		///// <returns><c>true</c>, if valid code was ised, <c>false</c> otherwise.</returns>
		///// <param name="code">Code.</param>
		//public static bool IsValidCode(string code)
		//{
		//	if (String.IsNullOrWhiteSpace(code))
		//		return false;

		//	code = code.Trim().ToUpper();

		//	return States.ContainsKey(code);
		//}
	}
}
