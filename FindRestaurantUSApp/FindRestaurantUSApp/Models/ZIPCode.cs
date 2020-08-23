// ***********************************************************************
// Assembly         : Findrestaurantus
// Author           : Bill
// Created          : 10-09-2019
//
// Last Modified By : Bill
// Last Modified On : 10-09-2019
// ***********************************************************************
// <copyright file="ZIPCode.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace FindRestaurantUSApp.Models
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class ZIPCode.
    /// </summary>
    public partial class ZIPCode
    {
        /// <summary>
        /// Gets or sets the zip code1.
        /// </summary>
        /// <value>The zip code1.</value>
        public string ZipCode1 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>The latitude.</value>
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>The longitude.</value>
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the classification.
        /// </summary>
        /// <value>The classification.</value>
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets the population.
        /// </summary>
        /// <value>The population.</value>
        public int? Population { get; set; }
    }
}
