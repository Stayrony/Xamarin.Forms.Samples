using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Samples.Controls;
using Xamarin.Forms.Samples.Droid.Renderers;

[assembly: ExportRenderer(typeof(ShadowFrame), typeof(ShadowFrameRenderer))]
namespace Xamarin.Forms.Samples.Droid.Renderers
{
	public class ShadowFrameRenderer : FrameRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
		{
			base.OnElementChanged(e);
			if (e.NewElement != null)
			{
				//http://inloop.github.io/shadow4android/
				ViewGroup.SetBackgroundResource(Resource.Drawable.shadow_card);
			}
		}
	}
}
