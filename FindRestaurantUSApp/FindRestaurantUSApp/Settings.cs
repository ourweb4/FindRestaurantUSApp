// ***********************************************************************
// Assembly         : FindRestaurantUSApp
// Author           : Bill   Banks
// Created          : 11-14-2019
//
// Last Modified By : Bill   Banks
// Last Modified On : 11-14-2019
// ***********************************************************************
// <copyright file="Settings.cs" company="FindRestaurantUSApp">
//     Copyright (c) Ourweb.net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using FindRestaurantUSApp.Models;
using Xamarin.Forms;

namespace FindRestaurantUSApp
{
    /// <summary>
    /// Class Settings.
    /// </summary>
    class Settings
    {
        /// <summary>
        /// The keyusername
        /// </summary>
        private const string KEYUSERNAME = "username";
        /// <summary>
        /// The keyemail
        /// </summary>
        private const string KEYEMAIL = "email";
        /// <summary>
        /// The keyapi
        /// </summary>
        private const string KEYAPI = "api";

        /// <summary>
        /// Reads this instance.
        /// </summary>
        /// <returns>Account.</returns>
        public Account Read()
        {
            Account account = new Account();


            if (Application.Current.Properties.ContainsKey(KEYUSERNAME))
                account.Username = Application.Current.Properties[KEYUSERNAME].ToString();

            if (Application.Current.Properties.ContainsKey(KEYAPI))
                account.Apikey = Application.Current.Properties[KEYAPI].ToString();
            if (Application.Current.Properties.ContainsKey(KEYEMAIL))
                account.Email = Application.Current.Properties[KEYEMAIL].ToString();
            return account;
        }

        /// <summary>
        /// Writes the specified account.
        /// </summary>
        /// <param name="account">The account.</param>
        public void Write(Account account)
        {
            Application.Current.Properties[KEYAPI] = account.Apikey;
            Application.Current.Properties[KEYEMAIL] = account.Email;
            Application.Current.Properties[KEYUSERNAME] = account.Username;
            Application.Current.SavePropertiesAsync();

        }
    }
}
