// ***********************************************************************
// Assembly         : FindRestaurantUSApp
// Author           : Bill   Banks
// Created          : 11-13-2019
//
// Last Modified By : Bill   Banks
// Last Modified On : 12-07-2019
// ***********************************************************************
// <copyright file="LoginPage.xaml.cs" company="FindRestaurantUSApp">
//     Copyright (c) Ourweb.net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FindRestaurantUSApp.Models;


namespace FindRestaurantUSApp.Pages
{
    /// <summary>
    /// Class LoginPage.
    /// Implements the <see cref="Xamarin.Forms.ContentPage" />
    /// </summary>
    /// <seealso cref="Xamarin.Forms.ContentPage" />
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        /// <summary>
        /// The API
        /// </summary>
        private API api = new API();
        /// <summary>
        /// The settings
        /// </summary>
        private Settings Settings = new Settings();
        /// <summary>
        /// The account
        /// </summary>
        private Account account;
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage"/> class.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When overridden, allows application developers to customize behavior immediately prior to the <see cref="T:Xamarin.Forms.Page" /> becoming visible.
        /// </summary>
        /// <remarks>To be added.</remarks>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            account = Settings.Read();

            if (!string.IsNullOrEmpty(account.Apikey))
                lblmessage.Text = "You are logon ";

        }

        /// <summary>
        /// Handles the Clicked event of the btnlogon control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async  void btnlogon_Clicked(object sender, EventArgs e)
        {
            var username = txtusername.Text;
            var passwozrd = txtpassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwozrd))
            {
                lblmessage.Text = "Username and Password cant be blank";
            }
            else
            {
                account = await api.Login(username, passwozrd);

                if (!string.IsNullOrEmpty(account.Apikey))
                {
                    lblmessage.Text = "You are logon ";
                    Settings.Write(account);
                } else
                    lblmessage.Text = "Username and Password is invalid";


            }
        }

        /// <summary>
        /// Handles the Clicked event of the btnregistar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void btnregistar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistarPage());
             
        }
    }
}