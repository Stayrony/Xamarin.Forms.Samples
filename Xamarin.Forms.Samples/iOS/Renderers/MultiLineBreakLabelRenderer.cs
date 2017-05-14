using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms.Samples.Controls;
using Xamarin.Forms.Samples.iOS.Renderers;

[assembly: ExportRenderer(typeof(MultiLineBreakLabel), typeof(MultiLineBreakLabelRenderer))]
namespace Xamarin.Forms.Samples.iOS.Renderers
{
	public class MultiLineBreakLabelRenderer : LabelRenderer
	{
		#region -- Overrides --

		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);
			var label = Element as MultiLineBreakLabel;
			if (label == null || Control == null)
			{
				return;
			}

			Control.Lines = label.MaxLines;
		}

		#endregion
	}
}
