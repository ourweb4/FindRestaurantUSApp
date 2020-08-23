// ***********************************************************************
// Assembly         : ZomatoAPI
// Author           : Bill
// Created          : 08-08-2019
//
// Last Modified By : Bill
// Last Modified On : 08-08-2019
// ***********************************************************************
// <copyright file="Restaurant2.cs" company="ZomatoAPI"
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace FindRestaurantUSApp.Models
{
    /// <summary>
    /// Class Restaurant2.
    /// </summary>
    public class Restaurant3
    {
        /// <summary>
        /// Gets or sets the r.
        /// </summary>
        /// <value>The r.</value>
     // public R R { get; set; }
        /// <summary>
        /// Gets or sets the apikey.
        /// </summary>
        /// <value>The apikey.</value>
        public string apikey { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// 
        
        public int Pace_id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string url { get; set; }
        /// <summary>
        /// Gets or sets the location.
        /// y>
        /// <value>The location.</value>
     //   public Location location { get; set; }
        /// <summary>
        /// Gets or sets the switch to order menu.
        /// </summary>
        /// <value>The switch to order menu.</value>
        public int switch_to_order_menu { get; set; }
        /// <summary>
        /// Gets or sets the cuisines.
        /// </summary>
        /// <value>The cuisines.</value>
        public string cuisines { get; set; }
        /// <summary>
        /// Gets or sets the timings.
        /// </summary>
        /// <value>The timings.</value>
        public string timings { get; set; }
        /// <summary>
        /// Gets or sets the average cost for two.
        /// </summary>
        /// <value>The average cost for two.</value>
        /// <summary>
        public int average_cost_for_two { get; set; }
        /// Gets or sets the price range.
        /// </summary>
        /// <value>The price range.</value>
        public int price_range { get; set; }
        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string currency { get; set; }
        /// <summary>
        /// Gets or sets the highlights.
        /// </summary>
        /// <value>The highlights.</value>
        public List<string> highlights { get; set; }
        /// <summary>
        /// Gets or sets the offers.
        /// </summary>
        /// <value>The offers.</value>
        public List<object> offers { get; set; }
        /// <summary>
        /// Gets or sets the opentable support.
        /// </summary>
        /// <value>The opentable support.</value>
        public int opentable_support { get; set; }
        /// <summary>
        /// Gets or sets the is zomato book resource.
        /// </summary>
        /// <value>The is zomato book resource.</value>
        public int is_zomato_book_res { get; set; }
        /// <summary>
        /// Gets or sets the mezzo provider.
        /// </summary>
        /// <value>The mezzo provider.</value>
        public string mezzo_provider { get; set; }
        /// <summary>
        /// Gets or sets the is book form web view.
        /// </summary>
        /// <value>The is book form web view.</value>
        public int is_book_form_web_view { get; set; }
        /// <summary>
        /// Gets or sets the book form web view URL.
        /// </summary>
        /// <value>The book form web view URL.</value>
        public string book_form_web_view_url { get; set; }
        /// <summary>
        /// Gets or sets the book again URL.
        /// </summary>
        /// <value>The book again URL.</value>
        public string book_again_url { get; set; }
        /// <summary>
        /// Gets or sets the thumb.
        /// </summary>
        /// <value>The thumb.</value>
        public string thumb { get; set; }
        /// <summary>
        /// Gets or sets the user rating.
        /// </summary>
        /// <value>The user rating.</value>
//    public UserRating user_rating { get; set; }
        /// <summary>
        /// Gets or sets all reviews count.
        /// </summary>
        /// <value>All reviews count.</value>
        public int all_reviews_count { get; set; }
        /// <summary>
       
            /// Gets or sets the photos URL.
        /// </summary>
        /// <value>The photos URL.</value>
        public string photos_url { get; set; }
        /// <summary>
        /// Gets or sets the photo count.
        /// </summary>
        /// <value>The photo count.</value>
        public int photo_count { get; set; }
        /// <summary>
        /// Gets or sets the menu URL.
        /// </summary>
        /// <value>The menu URL.</value>
        public string menu_url { get; set; }
        /// <summary>
        /// Gets or sets the featured image.
        /// </summary>
        /// <value>The featured image.</value>
        public string featured_image { get; set; }
        /// <summary>
        /// Gets or sets the has online delivery.
        /// </summary>
        /// <value>The has online delivery.</value>
        public int has_online_delivery { get; set; }
        /// <summary>
        /// Gets or sets the is delivering now.
        /// </summary>
        /// <value>The is delivering now.</value>
        public int is_delivering_now { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [include bogo offers].
        /// <value><c>true</c> if [include bogo offers]; otherwise, <c>false</c>.</value>
        public bool include_bogo_offers { get; set; }
        /// <summary>
        /// </summary>
        /// Gets or sets the deeplink.
        /// </summary>
        /// <value>The deeplink.</value>
        public string deeplink { get; set; }
        /// <summary>
        /// Gets or sets the is table reservation supported.
        /// </summary>
        /// <value>The is table reservation supported.</value>
        public int is_table_reservation_supported { get; set; }
        /// <summary>
        /// Gets or sets the has table booking.
        /// </summary>
        /// <value>The has table booking.</value>
        public int has_table_booking { get; set; }
        /// <summary>
        /// Gets or sets the events URL.
        /// </summary>
        /// <value>The events URL.</value>
        public string events_url { get; set; }
        /// <summary>
        /// Gets or sets the phone numbers.
        /// </summary>
        /// <value>The phone numbers.</value>
        public string phone_numbers { get; set; }
        /// <summary>
        /// Gets or sets all reviews.
        /// </summary>
        /// <value>All reviews.</value>
  //    public AllReviews all_reviews { g0et; set; }
        /// <summary>
        /// Gets or sets the establishment.
        /// </summary>
        /// <value>The establishment.</value>
    //  public List<object> establishment { get; set; }
        /// <summary>
        /// Gets or sets the establishment types.
        /// </summary>
        /// <value>The establishment types.</val0e>
//      public List<object> establishment_types { get; set; }
        /// <summary>
        /// Gets or sets the photos.
        /// </summary>
        /// <value>The photos.</value>
//      public List<Photo> photos { get; set; }
    }
}
