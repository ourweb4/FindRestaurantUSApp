// ***********************************************************************
// Assembly         : ZomatoAPI
// Author           : Bill
// Created          : 08-08-2019
//
// Last Modified By : Bill
// Last Modified On : 08-08-2019
// ***********************************************************************
// <copyright file="LocationSuggestion.cs" company="ZomatoAPI">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace FindRestaurantUSApp.Models
{
    /// <summary>
    /// Class LocationSuggestion.
    /// </summary>
    public class LocationSuggestion
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// 
        
        public int id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }
        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>The country identifier.</value>
        public int country_id { get; set; }
        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        /// <value>The name of the country.</value>
        public string country_name { get; set; }
        /// <summary>
        /// Gets or sets the country flag URL.
        /// </summary>
        /// <value>The country flag URL.</value>
        public string country_flag_url { get; set; }
        /// <summary>
        /// Gets or sets the should experiment with.
        /// </summary>
        /// <value>The should experiment with.</value>
        public int should_experiment_with { get; set; }
        /// <summary>
        /// Gets or sets the discovery enabled.
        /// </summary>
        /// <value>The discovery enabled.</value>
        public int discovery_enabled { get; set; }
        /// <summary>
        /// Gets or sets the has new ad format.
        /// </summary>
        /// <value>The has new ad format.</value>
        public int has_new_ad_format { get; set; }
        /// <summary>
        /// Gets or sets the state of the is.
        /// </summary>
        /// <value>The state of the is.</value>
        public int is_state { get; set; }
        /// <summary>
        /// Gets or sets the state identifier.
        /// </summary>
        /// <value>The state identifier.</value>
        public int state_id { get; set; }
        /// <summary>
        /// Gets or sets the name of the state.
        /// </summary>
        /// <value>The name of the state.</value>
        public string state_name { get; set; }
        /// <summary>
        /// Gets or sets the state code.
        /// </summary>
        /// <value>The state code.</value>
        public string state_code { get; set; }
    }
}
