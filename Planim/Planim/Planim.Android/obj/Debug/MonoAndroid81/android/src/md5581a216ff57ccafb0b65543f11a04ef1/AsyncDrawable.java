package md5581a216ff57ccafb0b65543f11a04ef1;


public class AsyncDrawable
	extends android.graphics.drawable.BitmapDrawable
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("FFImageLoading.Drawables.AsyncDrawable, UXDivers.Gorilla.SDK.Droid", AsyncDrawable.class, __md_methods);
	}


	public AsyncDrawable ()
	{
		super ();
		if (getClass () == AsyncDrawable.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.AsyncDrawable, UXDivers.Gorilla.SDK.Droid", "", this, new java.lang.Object[] {  });
	}


	public AsyncDrawable (android.content.res.Resources p0)
	{
		super (p0);
		if (getClass () == AsyncDrawable.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.AsyncDrawable, UXDivers.Gorilla.SDK.Droid", "Android.Content.Res.Resources, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public AsyncDrawable (android.content.res.Resources p0, android.graphics.Bitmap p1)
	{
		super (p0, p1);
		if (getClass () == AsyncDrawable.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.AsyncDrawable, UXDivers.Gorilla.SDK.Droid", "Android.Content.Res.Resources, Mono.Android:Android.Graphics.Bitmap, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public AsyncDrawable (android.content.res.Resources p0, java.io.InputStream p1)
	{
		super (p0, p1);
		if (getClass () == AsyncDrawable.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.AsyncDrawable, UXDivers.Gorilla.SDK.Droid", "Android.Content.Res.Resources, Mono.Android:System.IO.Stream, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public AsyncDrawable (android.content.res.Resources p0, java.lang.String p1)
	{
		super (p0, p1);
		if (getClass () == AsyncDrawable.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.AsyncDrawable, UXDivers.Gorilla.SDK.Droid", "Android.Content.Res.Resources, Mono.Android:System.String, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public AsyncDrawable (android.graphics.Bitmap p0)
	{
		super (p0);
		if (getClass () == AsyncDrawable.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.AsyncDrawable, UXDivers.Gorilla.SDK.Droid", "Android.Graphics.Bitmap, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public AsyncDrawable (java.io.InputStream p0)
	{
		super (p0);
		if (getClass () == AsyncDrawable.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.AsyncDrawable, UXDivers.Gorilla.SDK.Droid", "System.IO.Stream, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public AsyncDrawable (java.lang.String p0)
	{
		super (p0);
		if (getClass () == AsyncDrawable.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.AsyncDrawable, UXDivers.Gorilla.SDK.Droid", "System.String, mscorlib", this, new java.lang.Object[] { p0 });
	}

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
