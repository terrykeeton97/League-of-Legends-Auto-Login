using System.Collections;
using System.Windows.Forms;

namespace Auto_Login.Classes
{
    static class AccountController
    {
        public static ArrayList userAccounts = new ArrayList();

        public static void AddAccount(string username, string password, string region)
        {
            foreach (var item in userAccounts)
            {
                UserAccount temp = (UserAccount)item;
                if (temp.username.ToLower().Equals(username.ToLower()))
                {
                    MessageBox.Show("Account already exists", "Error");
                    return;
                }
            }
            userAccounts.Add(new UserAccount { username = username, password = password, region = region });
        }

        public static UserAccount GetAccount(string username)
        {
            foreach (var item in userAccounts)
            {
                UserAccount account = (UserAccount)item;
                if (account.username.ToLower().Equals(username.ToLower()))
                {
                    return account;
                }
            }
            return null;
        }

        public static void RemoveAccount(UserAccount account)
        {
            userAccounts.Remove(account);
        }
    }

    class UserAccount
    {
        public string username { get; set; }
        public string password { get; set; }
        public string region { get; set; }
    }
}
