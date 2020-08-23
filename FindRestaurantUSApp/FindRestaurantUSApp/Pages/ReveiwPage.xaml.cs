// ***********************************************************************
// Assembly         : FindRestaurantUSApp
// Author           : Bill   Banks
// Created          : 12-09-2019
//
// Last Modified By : Bill   Banks
// Last Modified On : 12-10-2019
// ***********************************************************************
// <copyright file="ReveiwPage.xaml.cs" company="FindRestaurantUSApp">
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
    /// Class ReveiwPage.
    /// Implements the <see cref="Xamarin.Forms.ContentPage" />
    /// </summary>
    /// <seealso cref="Xamarin.Forms.ContentPage" />
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReveiwPage : ContentPage
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
        /// The reveiw
        /// </summary>

        private Reveiw reveiw = new Reveiw();
        /// <summary>
        /// The pace identifier
        /// </summary>
        public int Pace_id;
        /// <summary>
        /// Initializes a new instance of the <see cref="ReveiwPage"/> class.
        /// </summary>
        public ReveiwPage()
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
            var key = account.Apikey;
            api.SetAPIKey(key);
            reveiw.email = account.Email;
            reveiw.usernamme = account.Username;
            reveiw.Pace_id = Pace_id;
            reveiw.date = DateTime.Today;
        }

        /// <summary>
        /// Handles the Clicked event of the btnadd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async  void btnadd_Clicked(object sender, EventArgs e)
        {
            reveiw.text = txttext.Text;
            reveiw.rating = Convert.ToInt16(  txtrating.Text);
            await api.Addreveiw(reveiw);
            await DisplayAlert("Save", "Reveiw saved.", "Ok");
        }
    }
}