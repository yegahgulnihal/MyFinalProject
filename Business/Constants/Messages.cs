using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        internal static string AuthorizationDenied= "you don't have authorization ";
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product name invalid";
        public static string MaintenanceTime = "Maintenance Time ";
        internal static string ProductListed = "Prodcuts are Listed";
        internal static string ProductCountofCategoryError="Limit exceeded";
        internal static string ProductNameAlreadyExist="Product name already exist";
        internal static string CategoryLimitExceeded="Category Limit Exceeded";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string AccessTokenCreated;

        public static string UserAlreadyExists { get; internal set; }
    }
}
