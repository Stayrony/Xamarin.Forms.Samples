using System;
using Xamarin.Forms.Samples.Views;

namespace Xamarin.Forms.Samples.ViewModels
{
    public class BasePageViewModel : BaseViewModel, IViewActionsHandler
    {
        #region -- IViewActionsHandler implementation --

        public virtual void OnAppearing()
        {

        }

        public virtual bool OnBackButtonPressed()
        {
            return false;
        }

        public virtual void OnDisappearing()
        {

        }

        #endregion
    }
}
