package md5581a216ff57ccafb0b65543f11a04ef1;


public class FFBitmapDrawableG
	extends md5581a216ff57ccafb0b65543f11a04ef1.SelfDisposingBitmapDrawableG
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_setAlpha:(I)V:GetSetAlpha_IHandler\n" +
			"n_setColorFilter:(ILandroid/graphics/PorterDuff$Mode;)V:GetSetColorFilter_ILandroid_graphics_PorterDuff_Mode_Handler\n" +
			"n_onBoundsChange:(Landroid/graphics/Rect;)V:GetOnBoundsChange_Landroid_graphics_Rect_Handler\n" +
			"";
		mono.android.Runtime.register ("FFImageLoading.Drawables.FFBitmapDrawableG, UXDivers.Gorilla.SDK.Droid", FFBitmapDrawableG.class, __md_methods);
	}


	public FFBitmapDrawableG ()
	{
		super ();
		if (getClass () == FFBitmapDrawableG.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.FFBitmapDrawableG, UXDivers.Gorilla.SDK.Droid", "", this, new java.lang.Object[] {  });
	}


	public FFBitmapDrawableG (android.content.res.Resources p0)
	{
		super (p0);
		if (getClass () == FFBitmapDrawableG.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.FFBitmapDrawableG, UXDivers.Gorilla.SDK.Droid", "Android.Content.Res.Resources, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public FFBitmapDrawableG (android.content.res.Resources p0, android.graphics.Bitmap p1)
	{
		super (p0, p1);
		if (getClass () == FFBitmapDrawableG.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.FFBitmapDrawableG, UXDivers.Gorilla.SDK.Droid", "Android.Content.Res.Resources, Mono.Android:Android.Graphics.Bitmap, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public FFBitmapDrawableG (android.content.res.Resources p0, java.io.InputStream p1)
	{
		super (p0, p1);
		if (getClass () == FFBitmapDrawableG.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.FFBitmapDrawableG, UXDivers.Gorilla.SDK.Droid", "Android.Content.Res.Resources, Mono.Android:System.IO.Stream, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public FFBitmapDrawableG (android.content.res.Resources p0, java.lang.String p1)
	{
		super (p0, p1);
		if (getClass () == FFBitmapDrawableG.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.FFBitmapDrawableG, UXDivers.Gorilla.SDK.Droid", "Android.Content.Res.Resources, Mono.Android:System.String, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public FFBitmapDrawableG (android.graphics.Bitmap p0)
	{
		super (p0);
		if (getClass () == FFBitmapDrawableG.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.FFBitmapDrawableG, UXDivers.Gorilla.SDK.Droid", "Android.Graphics.Bitmap, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public FFBitmapDrawableG (java.io.InputStream p0)
	{
		super (p0);
		if (getClass () == FFBitmapDrawableG.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.FFBitmapDrawableG, UXDivers.Gorilla.SDK.Droid", "System.IO.Stream, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public FFBitmapDrawableG (java.lang.String p0)
	{
		super (p0);
		if (getClass () == FFBitmapDrawableG.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.FFBitmapDrawableG, UXDivers.Gorilla.SDK.Droid", "System.String, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);


	public void setAlpha (int p0)
	{
		n_setAlpha (p0);
	}

	private native void n_setAlpha (int p0);


	public void setColorFilter (int p0, android.graphics.PorterDuff.Mode p1)
	{
		n_setColorFilter (p0, p1);
	}

	private native void n_setColorFilter (int p0, android.graphics.PorterDuff.Mode p1);


	public void onBoundsChange (android.graphics.Rect p0)
	{
		n_onBoundsChange (p0);
	}

	private native void n_onBoundsChange (android.graphics.Rect p0);

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
