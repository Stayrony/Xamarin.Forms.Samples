using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Samples.Controls;
using Xamarin.Forms.Samples.Droid.Renderers;
using Android.Text;

[assembly: ExportRenderer(typeof(MultiLineBreakLabel), typeof(MultiLineBreakLabelRenderer))]
namespace Xamarin.Forms.Samples.Droid.Renderers
{
	public class MultiLineBreakLabelRenderer : LabelRenderer
	{
		#region -- Overrides --

		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				var label = (MultiLineBreakLabel)this.Element;
				Control.SetMaxLines(label.MaxLines);
			}
		}

		#endregion
	}
}
