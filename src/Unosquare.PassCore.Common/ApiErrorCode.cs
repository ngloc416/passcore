﻿namespace Unosquare.PassCore.Common;

/// <summary>
/// Represents API error codes.
/// </summary>
public enum ApiErrorCode
{
    /// <summary>
    /// The generic
    /// </summary>
    Generic = 0,

    /// <summary>
    /// The field required
    /// </summary>
    FieldRequired = 1,

    /// <summary>
    /// The field mismatch
    /// </summary>
    FieldMismatch = 2,

    /// <summary>
    /// The user not found
    /// </summary>
    UserNotFound = 3,

    /// <summary>
    /// The invalid credentials
    /// </summary>
    InvalidCredentials = 4,

    /// <summary>
    /// The invalid captcha
    /// </summary>
    InvalidCaptcha = 5,

    /// <summary>
    /// The change not permitted
    /// </summary>
    ChangeNotPermitted = 6,

    /// <summary>
    /// The invalid domain
    /// </summary>
    InvalidDomain = 7,

    /// <summary>
    /// LDAP problem connection
    /// </summary>
    LdapProblem = 8,

    /// <summary>
    /// Complex password issue
    /// </summary>
    ComplexPassword = 9,

    /// <summary>
    /// The score is minor than the Minimum Score  
    /// </summary>
    MinimumScore = 10,

    /// <summary>
    /// The score is minor than the Minimum Score  
    /// </summary>
    MinimumDistance = 11,

    /// <summary>
    /// The password is in Pwned database
    /// </summary>
    PwnedPassword = 12,

    /// <summary>
    /// The password length is shorter than minimum password length
    /// </summary>
    ShortPassword = 13,
}