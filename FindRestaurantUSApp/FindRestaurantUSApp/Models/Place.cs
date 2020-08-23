using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FindRestaurantUSApp.Models
{
    public class Place : Restaurant3
    {
        public string  Placeno { get; set; }
        public int Cityid_id { get; set; }
       public DateTime DateTimeentereda { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string address { get; set; }
        /// <summary>
        /// Gets or sets the locality.
        /// </summary>
        /// <value>The locality.</value>
        public string locality { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string city { get; set; }
        /// <summary>
        /// Gets or sets the city identifier.
        /// </summary>
        /// <value>The city identifier.</value>
        public int city_id { get; set; }
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>The latitude.</value>
        public string latitude { get; set; }
        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>The longitude.</value>
        public string longitude { get; set; }
        /// <summary>
        /// Gets or sets the zipcode.
        /// </summary>
        /// <value>The zipcode.</value>
        public string zipcode { get; set; }
        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>The country identifier.</value>
        public int country_id { get; set; }
        /// <summary>
        /// Gets or sets the locality verbose.
        /// </summary>
        /// <value>The locality verbose.</value>
        public string locality_verbose { get; set; }

        public int order { get; set; }
        public List<Reveiw> reveiws  { get; set; }

    }
}