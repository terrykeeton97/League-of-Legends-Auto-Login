using SweetAlertSharp.Enums;
using SweetAlertSharp;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Auto_Login.Classes
{
    static class AccountController
    {
        private static List<UserAccount> UserAccounts = new List<UserAccount>();

        public static IReadOnlyCollection<UserAccount> GetAccounts()
        {
            return UserAccounts;
        }
        public static void AddAccount(string username, string password, string region)
        {
            if (UserAccounts.Any(x => string.Equals(x.username, username, StringComparison.OrdinalIgnoreCase)))
            {
                SweetAlert.Show("Error", "Account already exists", SweetAlertButton.YesNo, SweetAlertImage.ERROR);
                return;
            }
            UserAccounts.Add(new UserAccount { username = username, password = password, region = region });
        }

        public static UserAccount GetAccount(string username)
        {
            return UserAccounts.FirstOrDefault(x => string.Equals(x.username, username, StringComparison.OrdinalIgnoreCase));
        }

        public static void RemoveAccount(UserAccount account)
        {
            UserAccounts.Remove(account);
        }
    }

    class UserAccount
    {
        public string username { get; set; }
        public string password { get; set; }
        public string region { get; set; }
    }
}
