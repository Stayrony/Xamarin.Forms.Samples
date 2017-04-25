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

        #endregion

        #region -- Private helpers --

        private async Task OnLetterSpacingCommandAsync()
        {
            await _navigationService.NavigateAsync("LetterSpacing");
        }

        #endregion

    }
}
