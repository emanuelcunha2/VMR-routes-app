package crc645e8ef271ef931913;


public class DangerousTrustProvider_DangerousTrustManager
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		javax.net.ssl.X509TrustManager,
		javax.net.ssl.TrustManager
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_checkClientTrusted:([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V:GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler:Javax.Net.Ssl.IX509TrustManagerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_checkServerTrusted:([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V:GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler:Javax.Net.Ssl.IX509TrustManagerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_getAcceptedIssuers:()[Ljava/security/cert/X509Certificate;:GetGetAcceptedIssuersHandler:Javax.Net.Ssl.IX509TrustManagerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("RouteCicleRegistrationApp.Platforms.Android.Resources.DangerousTrustProvider+DangerousTrustManager, RouteCicleRegistrationApp", DangerousTrustProvider_DangerousTrustManager.class, __md_methods);
	}


	public DangerousTrustProvider_DangerousTrustManager ()
	{
		super ();
		if (getClass () == DangerousTrustProvider_DangerousTrustManager.class) {
			mono.android.TypeManager.Activate ("RouteCicleRegistrationApp.Platforms.Android.Resources.DangerousTrustProvider+DangerousTrustManager, RouteCicleRegistrationApp", "", this, new java.lang.Object[] {  });
		}
	}


	public void checkClientTrusted (java.security.cert.X509Certificate[] p0, java.lang.String p1)
	{
		n_checkClientTrusted (p0, p1);
	}

	private native void n_checkClientTrusted (java.security.cert.X509Certificate[] p0, java.lang.String p1);


	public void checkServerTrusted (java.security.cert.X509Certificate[] p0, java.lang.String p1)
	{
		n_checkServerTrusted (p0, p1);
	}

	private native void n_checkServerTrusted (java.security.cert.X509Certificate[] p0, java.lang.String p1);


	public java.security.cert.X509Certificate[] getAcceptedIssuers ()
	{
		return n_getAcceptedIssuers ();
	}

	private native java.security.cert.X509Certificate[] n_getAcceptedIssuers ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}