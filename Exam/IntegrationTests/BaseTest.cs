using System;
using System.Net.Http;

namespace IntegrationTests
{
    public class BaseTest
    {
        public BaseTest()
        {
            this.HttpClient = new HttpClient
            {
                BaseAddress = new Uri("https://libraryjuly.azurewebsites.net")
            };
        }

        protected HttpClient HttpClient { get; private set; }
    }
}
