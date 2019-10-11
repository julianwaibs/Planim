package md5fdb5f0f899e8f1814f40d7b870e1a11e;


public class LongPressGestureListener
	extends android.view.GestureDetector.SimpleOnGestureListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLongPress:(Landroid/view/MotionEvent;)V:GetOnLongPress_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("UXDivers.Gorilla.Droid.LongPressGestureListener, UXDivers.Gorilla.SDK.Droid", LongPressGestureListener.class, __md_methods);
	}


	public LongPressGestureListener ()
	{
		super ();
		if (getClass () == LongPressGestureListener.class)
			mono.android.TypeManager.Activate ("UXDivers.Gorilla.Droid.LongPressGestureListener, UXDivers.Gorilla.SDK.Droid", "", this, new java.lang.Object[] {  });
	}


	public void onLongPress (android.view.MotionEvent p0)
	{
		n_onLongPress (p0);
	}

	private native void n_onLongPress (android.view.MotionEvent p0);

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
