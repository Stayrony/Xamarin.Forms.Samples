using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using NControl.Controls.iOS;
using UIKit;

namespace Xamarin.Forms.Samples.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        #region -- Overrides --

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            NControls.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        #endregion

    }
}
