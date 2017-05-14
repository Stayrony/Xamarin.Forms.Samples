using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Unity;
using Prism.Navigation;
using Xamarin.Forms.Xaml;
using Microsoft.Practices.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Samples.Views;

namespace Xamarin.Forms.Samples
{
    public partial class App : PrismApplication
    {
        public static T Resolve<T>()
        {
            return (Current as App).Container.Resolve<T>();
        }

        public App()
        {
            InitializeComponent();
            MainPage = new Xamarin.Forms.Samples.Views.MainView();
        }

        #region -- Overrides --

        protected override void OnInitialized()
        {
        }

        protected override void RegisterTypes()
        {
            Container.RegisterInstance<INavigationService>(Container.Resolve<Prism.Unity.Navigation.UnityPageNavigationService>());
            //Services

            //Managers

            //Navigation
            Container.RegisterTypeForNavigation<LetterSpacingView>("LetterSpacing");
			Container.RegisterTypeForNavigation<MultiLineBreakLabelView>("MultiLineBreakLabel");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        #endregion
    }
}
