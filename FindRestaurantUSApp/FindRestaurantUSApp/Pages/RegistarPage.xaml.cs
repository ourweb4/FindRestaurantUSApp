// ***********************************************************************
// Assembly         : FindRestaurantUSApp
// Author           : Bill   Banks
// Created          : 11-13-2019
//
// Last Modified By : Bill   Banks
// Last Modified On : 12-08-2019
// ***********************************************************************
// <copyright file="RegistarPage.xaml.cs" company="FindRestaurantUSApp">
//     Copyright (c) Ourweb.net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using FindRestaurantUSApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindRestaurantUSApp.Pages
{
    /// <summary>
    /// Class RegistarPage.
    /// Implements the <see cref="Xamarin.Forms.ContentPage" />
    /// </summary>
    /// <seealso cref="Xamarin.Forms.ContentPage" />
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistarPage : ContentPage
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
        /// Initializes a new instance of the <see cref="RegistarPage"/> class.
        /// </summary>
        public RegistarPage()
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
        /// Handles the Clicked event of the btnreg control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void btnreg_Clicked(object sender, EventArgs e)
        {
            var username = txtusername.Text;
            var passwozrd = txtpassword.Text;
            var email = txtemail.Text;
            var answer = txtanswer.Text;
            var question = txtquestion.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwozrd) || string.IsNullOrEmpty(email) )
            {
                lblmessage.Text = "Username, Password and Email cant be blank";
            }
            else
            {
                account = await api.CreateUser(username, passwozrd, email, question, answer);
                if (account.Status == AccountStatus.Success)
                {
                    lblmessage.Text = "You are logon ";
                    Settings.Write(account);
                }
                else if (account.Status == AccountStatus.DuplicateUserName)
                    lblmessage.Text = "Username is use";
                else lblmessage.Text = "Error  user not created";


            }
        }
    }
}