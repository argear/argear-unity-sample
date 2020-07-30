using UnityEngine;
using AOT;

namespace ARGear.Callback
{
	public class ARGeariOSCallback
	{
		public delegate void ARGearContentsLoadingResult(bool success, string msg);
		public static ARGearContentsCallback argearContentsCallback = null;

		[MonoPInvokeCallback(typeof(ARGearContentsLoadingResult))]
		public static void contentsLoadingResult(bool success, string msg)
		{
			if (argearContentsCallback == null) return;

			if (success)
			{
				argearContentsCallback.OnSuccess();
			}
			else
			{
				argearContentsCallback.OnError(msg);
			}

			argearContentsCallback = null;
		}
	}
}