using System;
using Prism.Mvvm;

namespace Xamarin.Forms.Samples.Views
{
    public class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            ViewModelLocator.SetAutowireViewModel(this, true);
        }

        #region -- Overrides --

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var actionsHandler = BindingContext as IViewActionsHandler;
            if (actionsHandler != null)
                actionsHandler.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            bool isHandled = false;
            var actionsHandler = BindingContext as IViewActionsHandler;
            if (actionsHandler != null)
                isHandled = actionsHandler.OnBackButtonPressed();
            return isHandled || base.OnBackButtonPressed();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            var actionsHandler = BindingContext as IViewActionsHandler;
            if (actionsHandler != null)
                actionsHandler.OnAppearing();
        }

        #endregion
    }
}
