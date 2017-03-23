using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Social : MonoBehaviour
{

	public void ShareFB()
	{
		ShareVia ("fb","Hi");
	}

	public void ShareVK()
	{
		ShareVia ("vk","Hi");
	}

	public void ShareIn()
	{
		ShareVia ("tg","Hi");
	}

	public void ShareTW()
	{
		ShareVia ("tw","Hi");
	}


	#if UNITY_IOS
	[DllImport ("__Internal")]
	private static extern void shareVia (string app, string message, string url, string param);
	#endif

	public static void ShareVia (string app, string message, string param = "") {
		#if UNITY_ANDROID
		message = string.Format ("{0} {1}", message, "http://my.url.com"); 
		using (var plugin = new AndroidJavaClass("com.mycompany.sharing.Plugin")) {
			plugin.CallStatic("shareVia", app, message);
		}
		#elif UNITY_IOS
		shareVia (app, message, "http://my.url.com", param);
		#endif
	}
		
	void OnShareError (string result) {
		switch (result) {
		case "NotInstall":
			break;
		case "NotAvailable":
			break;
		case "AccessDenied":
			break;
		default:
			break;
		}
	}

}
