using Auto_Login.Classes;
using static Auto_Login.Main;

namespace Auto_Login.Mappers
{
    public class AccountMapper
    {
        internal static Account Map(UserAccount account)
        {
            return new Account
            {
                username = account?.username,
                password = account?.password,
                region = account?.region
            };
        }
    }
}
