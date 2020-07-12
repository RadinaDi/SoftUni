using IntegrationTests.Extensions;
using IntegrationTests.Models;
using System;

namespace IntegrationTests.ModelBuilder
{
    public static class AuthorBuilder
    {
        private static Random random = new Random();

        public static Author NewAuthor()
        {
            return new Author()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = random.NextString(maxLength: 25),
                LastName = random.NextString(maxLength: 25),
                Genre = random.NextString(maxLength: 25),
            };
        }
    }
}
