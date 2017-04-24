using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Samples.Controls;
using Xamarin.Forms.Samples.Droid.Renderers;

[assembly: ExportRenderer(typeof(LetterSpacingLabel), typeof(LetterSpacingLabelRenderer))]
namespace Xamarin.Forms.Samples.Droid.Renderers
{
    public class LetterSpacingLabelRenderer : LabelRenderer
    {
        protected LetterSpacingLabel LetterSpacingLabel { get; private set; }

        #region -- Overrides --

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                this.LetterSpacingLabel = (LetterSpacingLabel)this.Element;
            }

            var letterSpacing = this.LetterSpacingLabel.LetterSpacing;
            this.Control.LetterSpacing = letterSpacing;

            this.UpdateLayout();
        }

        #endregion
    }
}
