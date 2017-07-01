using System.Threading.Tasks;
using System.Windows.Input;

using Prism.Navigation;
using Xamarin.Forms.Samples.Helpers;

namespace Xamarin.Forms.Samples.ViewModels
{
    public class MainViewModel : BasePageViewModel
    {
        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigation)
        {
            _navigationService = navigation;
        }

        #region -- Public properties --

        public ICommand LetterSpacingCommand => SingleExecutionCommand.FromFunc(OnLetterSpacingCommandAsync);
		public ICommand MultiLineBreakLabelCommand => SingleExecutionCommand.FromFunc(OnMultiLineBreakLabelCommandAsync);
		public ICommand ShadowCardCommand => SingleExecutionCommand.FromFunc(OnShadowCardCommandAsync);

        #endregion

        #region -- Private helpers --

        private async Task OnLetterSpacingCommandAsync()
        {
            await _navigationService.NavigateAsync("LetterSpacing");
        }

		private async Task OnMultiLineBreakLabelCommandAsync()
		{
			await _navigationService.NavigateAsync("MultiLineBreakLabel");
		}

		private async Task OnShadowCardCommandAsync()
		{
			await _navigationService.NavigateAsync("ShadowCard");
		}

        #endregion

    }
}
