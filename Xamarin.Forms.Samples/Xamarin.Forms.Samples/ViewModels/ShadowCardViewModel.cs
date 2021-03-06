﻿using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms.Samples.Helpers;

namespace Xamarin.Forms.Samples.ViewModels
{
	public class ShadowCardViewModel : BasePageViewModel
	{
		private readonly INavigationService _navigationService;

		public ShadowCardViewModel(INavigationService navigation)
		{
			_navigationService = navigation;
		}

		#region -- Public properties --

		public ICommand BackCommand => SingleExecutionCommand.FromFunc(OnBackCommandAsync);

		#endregion

		#region -- Private helpers --

		private Task OnBackCommandAsync()
		{
			return _navigationService.GoBackAsync();
		}

		#endregion
	}
}
