﻿using AsyncAwaitBestPractices.MVVM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Bookshelf.Mobile.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Xamarin.Bookshelf.Mobile.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public ICommand LoginWithGoogleCommand { get; }

        public LoginPageViewModel()
        {
            LoginWithGoogleCommand = new AsyncCommand(LoginWithGoogleAsync);
        }

        private async Task LoginWithGoogleAsync()
        {
<<<<<<< HEAD
            await MainThread.InvokeOnMainThreadAsync(async () =>
=======
            Console.WriteLine(MainThread.IsMainThread);
            //await MainThread.InvokeOnMainThreadAsync(async () =>
            //{
            try
>>>>>>> Fix login error
            {
                var result = await WebAuthenticator.AuthenticateAsync(new Uri(Constants.AUTHENTICATION_URL), new Uri(Constants.DEEP_LINK_SCHEMA));
                var token = new AuthenticationToken()
                {
                    AccessToken = result.AccessToken,
                    RefreshToken = result.RefreshToken,
                    ExpiresIn = result.ExpiresIn
                };
            }
            catch (Exception ex)
            {
                return;
            }
            //});
        }
    }
}