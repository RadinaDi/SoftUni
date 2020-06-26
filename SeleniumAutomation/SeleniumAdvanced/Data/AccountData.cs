using SeleniumAdvanced.Extensions;
using SeleniumAdvanced.Model;
using System;

namespace SeleniumAdvanced.Data
{
    public static class AccountData
    {
        private static Random random = new Random();

        public static Account NewAccount()
        {
            return new Account()
            {
                PhoneNumber = random.NextPhoneNumber(),
                LastName = random.NextString(32),
                FirstName = random.NextString(32),
                Address = random.NextString(128),
                City = random.NextString(64),
                Email = random.NextString(118) + "@gmail.com",
                Password = random.NextString(32),
                State = "Alabama",
                Zip = random.NextZip(),
            };
        }

        public static Account WithPhoneNumber(this Account account, string phoneNumber)
        {
            account.PhoneNumber = phoneNumber;
            return account;
        }

        public static Account WithPassword(this Account account, string password)
        {
            account.Password = password;
            return account;
        }

        public static Account WithLastName(this Account account, string lastName)
        {
            account.LastName = lastName;
            return account;
        }

        public static Account WithFirstName(this Account account, string firstName)
        {
            account.FirstName = firstName;
            return account;
        }

        public static Account WithCity(this Account account, string city)
        {
            account.City = city;
            return account;
        }

        public static Account WithAddress(this Account account, string address)
        {
            account.Address = address;
            return account;
        }

        public static Account WithZip(this Account account, string zip)
        {
            account.Zip = zip;
            return account;
        }

        private static string NextPhoneNumber(this Random random)
        {
            int num = random.Next(999999);
            return $"0888{num:D6}";
        }

        private static string NextZip(this Random random)
        {
            int num = random.Next(99999);
            return $"{num:D5}";
        }
    }
}
