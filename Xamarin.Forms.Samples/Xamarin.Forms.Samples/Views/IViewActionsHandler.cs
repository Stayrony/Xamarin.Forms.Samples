using System;
namespace Xamarin.Forms.Samples.Views
{
    public interface IViewActionsHandler
    {
        bool OnBackButtonPressed();
        void OnAppearing();
        void OnDisappearing();
    }
}
