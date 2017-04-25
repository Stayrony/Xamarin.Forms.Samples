using System;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms.Samples.Controls;
using Xamarin.Forms.Samples.iOS.Renderers;

[assembly: ExportRenderer(typeof(LetterSpacingLabel), typeof(LetterSpacingLabelRenderer))]
namespace Xamarin.Forms.Samples.iOS.Renderers
{
    public class LetterSpacingLabelRenderer : LabelRenderer
    {
        #region -- Overrides --

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var data = Element as LetterSpacingLabel;
            if (data == null || Control == null)
            {
                return;
            }

            var text = Control.Text;
            var attributedString = new NSMutableAttributedString(text);

            var nsKern = new NSString("NSKern");
            var spacing = NSObject.FromObject(data.LetterSpacing * 10);
            var range = new NSRange(0, text.Length);

            attributedString.AddAttribute(nsKern, spacing, range);
            Control.AttributedText = attributedString;
        }

        #endregion
    }
}
