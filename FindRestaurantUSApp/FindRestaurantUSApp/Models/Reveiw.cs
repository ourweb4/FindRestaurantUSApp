// ***********************************************************************
// Assembly         : Findrestaurantus
// Author           : Bill   Banks
// Created          : 10-31-2019
//
// Last Modified By : Bill   Banks
// Last Modified On : 11-01-2019
// ***********************************************************************
// <copyright file="Reveiw.cs" company="Ourweb.net">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindRestaurantUSApp.Models
{
    /// <summary>
    /// Class Reveiw.
    /// </summary>
    public class Reveiw
    {
        /// <summary>
        /// Gets or sets the reveiw identifier.
        /// </summary>
        /// <value>The reveiw identifier.</value>
        /// 
        
        public int Reveiw_Id { get; set; }
        /// <summary>
        /// Gets or sets the pace identifier.
        /// </summary>
        /// <value>The pace identifier.</value>
        public int Pace_id { get; set; }
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime date  { get; set; }
        /// <summary>
        /// Gets or sets the usernamme.
        /// </summary>
        /// <value>The usernamme.</value>
        public string usernamme { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string email { get; set; }
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string text { get; set; }
        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>The rating.</value>
        public int rating { get; set; }
    }
}