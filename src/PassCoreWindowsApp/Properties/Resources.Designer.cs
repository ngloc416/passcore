﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PassCoreWindowsApp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PassCoreWindowsApp.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change Account Password | Self-Service Account Management Tools.
        /// </summary>
        internal static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change Password.
        /// </summary>
        internal static string ChangePassButton {
            get {
                return ResourceManager.GetString("ChangePassButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a valid email address.
        /// </summary>
        internal static string CheckEmailLabel {
            get {
                return ResourceManager.GetString("CheckEmailLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords do not match.
        /// </summary>
        internal static string CheckPassLabel {
            get {
                return ResourceManager.GetString("CheckPassLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current Password.
        /// </summary>
        internal static string CurrPassLabel {
            get {
                return ResourceManager.GetString("CurrPassLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not verify you are not a robot..
        /// </summary>
        internal static string ErrorCaptcha {
            get {
                return ResourceManager.GetString("ErrorCaptcha", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password does not meet the password policy requirements. Check password complexity and password history requirements..
        /// </summary>
        internal static string ErrorComplexPassword {
            get {
                return ResourceManager.GetString("ErrorComplexPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled error connecting to the LDAP server..
        /// </summary>
        internal static string ErrorConnectionLdap {
            get {
                return ResourceManager.GetString("ErrorConnectionLdap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password you are trying to set is not diferent enough of your last password..
        /// </summary>
        internal static string ErrorDistancePassword {
            get {
                return ResourceManager.GetString("ErrorDistancePassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The passwords do not match..
        /// </summary>
        internal static string ErrorFieldMismatch {
            get {
                return ResourceManager.GetString("ErrorFieldMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fulfill all the fields..
        /// </summary>
        internal static string ErrorFieldRequired {
            get {
                return ResourceManager.GetString("ErrorFieldRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You need to provide the correct current password..
        /// </summary>
        internal static string ErrorInvalidCredentials {
            get {
                return ResourceManager.GetString("ErrorInvalidCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have supplied an invalid domain to logon to..
        /// </summary>
        internal static string ErrorInvalidDomain {
            get {
                return ResourceManager.GetString("ErrorInvalidDomain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We could not find your user account..
        /// </summary>
        internal static string ErrorInvalidUser {
            get {
                return ResourceManager.GetString("ErrorInvalidUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not allowed to change your password. Please contact your system administrator..
        /// </summary>
        internal static string ErrorPasswordChangeNotAllowed {
            get {
                return ResourceManager.GetString("ErrorPasswordChangeNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password you are trying to use is publicly known and can be used in dictionary attacks..
        /// </summary>
        internal static string ErrorPwnedPassword {
            get {
                return ResourceManager.GetString("ErrorPwnedPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password you are trying to set is not secure enough..
        /// </summary>
        internal static string ErrorScorePassword {
            get {
                return ResourceManager.GetString("ErrorScorePassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed due to password complex policies: New password length is shorter than AD minimum password length..
        /// </summary>
        internal static string ErrorShortPassword {
            get {
                return ResourceManager.GetString("ErrorShortPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string ErrorTitle {
            get {
                return ResourceManager.GetString("ErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change Account Password.
        /// </summary>
        internal static string FormTitle {
            get {
                return ResourceManager.GetString("FormTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://192.168.11.242:8088/.
        /// </summary>
        internal static string Host {
            get {
                return ResourceManager.GetString("Host", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Password.
        /// </summary>
        internal static string NewPassLabel {
            get {
                return ResourceManager.GetString("NewPassLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HKEY_CURRENT_USER\SOFTWARE\inMeeting\PassCore.
        /// </summary>
        internal static string RegistryKeyName {
            get {
                return ResourceManager.GetString("RegistryKeyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Re-enter New Password.
        /// </summary>
        internal static string ReNewPassLabel {
            get {
                return ResourceManager.GetString("ReNewPassLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please note it may take a few hours for your new password to reach all domain controllers..
        /// </summary>
        internal static string SuccessContent {
            get {
                return ResourceManager.GetString("SuccessContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have changed your password successfully..
        /// </summary>
        internal static string SuccessTiltle {
            get {
                return ResourceManager.GetString("SuccessTiltle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username.
        /// </summary>
        internal static string UsernameLabel {
            get {
                return ResourceManager.GetString("UsernameLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your organization&apos;s username.
        /// </summary>
        internal static string UsernameSubTitle {
            get {
                return ResourceManager.GetString("UsernameSubTitle", resourceCulture);
            }
        }
    }
}