// ***********************************************************************
// Assembly         : FindRestaurantUSApp
// Author           : Bill   Banks
// Created          : 11-13-2019
//
// Last Modified By : Bill   Banks
// Last Modified On : 12-02-2019
// ***********************************************************************
// <copyright file="HomePage.xaml.cs" company="FindRestaurantUSApp">
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
    /// Class HomePage.
    /// Implements the <see cref="Xamarin.Forms.ContentPage" />
    /// </summary>
    /// <seealso cref="Xamarin.Forms.ContentPage" />
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        /// <summary>
        /// The API
        /// </summary>
        private API api = new API();
        /// <summary>
        /// The places
        /// </summary>
        private List<Place> places = new List<Place>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        public HomePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Clicked event of the find control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async  void find_Clicked(object sender, EventArgs e)
        {
            btnfind.IsEnabled = false;
            string city = txtcity.Text;
            string state = txtstate.Text;
            string zip = txtzip.Text;

            if (!string.IsNullOrEmpty(zip))
            {
                var zipinfo = await  api.GetZIPCode(zip);
                city = zipinfo.City;
                state = zipinfo.State;
            }

            if (!string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(state))
            {
               var  qplaces =  await  api.GetPlaces(city, state);
                places =qplaces;
         
                lvplaces.ItemsSource = places;
             }
            btnfind.IsEnabled = true;
        }

        /// <summary>
        /// Handles the ItemTapped event of the lvplaces control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ItemTappedEventArgs"/> instance containing the event data.</param>
        private async  void lvplaces_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var dp = new DetailPage();
            var temp = e.Item as Place;
            dp.place = temp;
            await Navigation.PushAsync(dp);
        }

        /// <summary>
        /// Handles the ItemSelected event of the lvplaces control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectedItemChangedEventArgs" /> instance containing the event data.</param>
      
    }
}