// ***********************************************************************
// Assembly         : FindRestaurantUSApp
// Author           : Bill   Banks
// Created          : 11-26-2019
//
// Last Modified By : Bill   Banks
// Last Modified On : 12-04-2019
// ***********************************************************************
// <copyright file="DetailPage.xaml.cs" company="FindRestaurantUSApp">
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
    /// Class DetailPage.
    /// Implements the <see cref="Xamarin.Forms.ContentPage" />
    /// </summary>
    /// <seealso cref="Xamarin.Forms.ContentPage" />
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        /// <summary>
        /// The place
        /// </summary>
        public Place place;

        /// <summary>
        /// The settings
        /// </summary>
        private Settings settings = new Settings();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailPage"/> class.
        /// </summary>
        public DetailPage()
        {
            InitializeComponent();
          //  LoadData();
        }

        /// <summary>
        /// When overridden, allows application developers to customize behavior immediately prior to the <see cref="T:Xamarin.Forms.Page" /> becoming visible.
        /// </summary>
        /// <remarks>To be added.</remarks>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadData();
        }
        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadData()
        {
            lblname.Text = place.name;
            lbladdress.Text = place.address;
            lblphone.Text = place.phone_numbers;
            lblcuisines.Text = place.cuisines;
  //          lblurl.Text = place.url;
            lvreviews.ItemsSource = place.reveiws;
            if (!string.IsNullOrEmpty(place.featured_image))
            {
                var imgsouce = (ImageSource)ImageSource.FromUri(new Uri(place.featured_image));
                imgfeatured_image.Source = imgsouce;

            }
            }

        /// <summary>
        /// Handles the Clicked event of the btnreview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async  void btnreview_Clicked(object sender, EventArgs e)
        {
            var account  = settings.Read();
            if (string.IsNullOrEmpty(account.Apikey))
            {
                await DisplayAlert("Alert", "You need an account to write a reveiw", "Ok");
            } else
            {
                // review page
                var rp = new ReveiwPage();
                rp.Pace_id = place.Pace_id;
                await Navigation.PushAsync(rp);

            }
        }
    }
}