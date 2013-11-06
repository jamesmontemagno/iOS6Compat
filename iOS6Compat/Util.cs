using System;
using MonoTouch.UIKit;

namespace iOS6Compat
{
	public static class Util
	{
		/// <summary>
		/// Checks if the operating system of the phone is 7.0 or higher
		/// </summary>
		/// <value><c>true</c> if is iOS7; otherwise, <c>false</c>.</value>
		public static bool IsiOS7
		{
			get { return UIDevice.CurrentDevice.CheckSystemVersion (7, 0); }
		}

		/// <summary>
		/// Gets the resource based on version of iOS
		/// </summary>
		/// <returns>The icon.</returns>
		/// <param name="resourceName">Resource name.</param>
		public static string GetIcon(string resourceName)
		{
			if (IsiOS7)
				return "ios7_" + resourceName;

			return resourceName;
		}
	}
}

