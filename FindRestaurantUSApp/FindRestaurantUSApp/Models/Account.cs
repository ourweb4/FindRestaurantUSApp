// ***********************************************************************
// Assembly         : Findrestaurantus
// Author           : Bill   Banks
// Created          : 11-10-2019
//
// Last Modified By : Bill   Banks
// Last Modified On : 11-10-2019
// ***********************************************************************
// <copyright file="Account.cs" company="Ourweb.net">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindRestaurantUSApp.Models
{
    /// <summary>
    /// Enum AccountStatus
    /// </summary>
    public enum AccountStatus
    {
        //
        // Summary:
        //     The user was successfully created.
        /// <summary>
        /// The success
        /// </summary>
        Success = 0,
        //
        // Summary:
        //     The user name was not found in the database.
        /// <summary>
        /// The invalid user name
        /// </summary>
        InvalidUserName = 1,
        //
        // Summary:
        //     The password is not formatted correctly.
        /// <summary>
        /// The invalid password
        /// </summary>
        InvalidPassword = 2,
        //
        // Summary:
        //     The password question is not formatted correctly.
        /// <summary>
        /// The invalid question
        /// </summary>
        InvalidQuestion = 3,
        //
        // Summary:
        //     The password answer is not formatted correctly.
        /// <summary>
        /// The invalid answer
        /// </summary>
        InvalidAnswer = 4,
        //
        // Summary:
        //     The e-mail address is not formatted correctly.
        /// <summary>
        /// The invalid email
        /// </summary>
        InvalidEmail = 5,
        //
        // Summary:
        //     The user name already exists in the database for the application.
        /// <summary>
        /// The duplicate user name
        /// </summary>
        DuplicateUserName = 6,
        //
        // Summary:
        //     The e-mail address already exists in the database for the application.
        /// <summary>
        /// The duplicate email
        /// </summary>
        DuplicateEmail = 7,
        //
        // Summary:
        //     The user was not created, for a reason defined by the provider.
        /// <summary>
        /// The user rejected
        /// </summary>
        UserRejected = 8,
        //
        // Summary:
        //     The provider user key is of an invalid type or format.
        /// <summary>
        /// The invalid provider user key
        /// </summary>
        InvalidProviderUserKey = 9,
        //
        // Summary:
        //     The provider user key already exists in the database for the application.
        /// <summary>
        /// The duplicate provider user key
        /// </summary>
        DuplicateProviderUserKey = 10,
        //
        // Summary:
        //     The provider returned an error that is not described by other System.Web.Security.MembershipCreateStatus
        //     enumeration values.
        /// <summary>
        /// The provider error
        /// </summary>
        ProviderError = 11

    }
    /// <summary>
    /// Class Account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the apikey.
        /// </summary>
        /// <value>The apikey.</value>
        public string Apikey { get; set; }
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public AccountStatus Status { get; set; }

    }
}