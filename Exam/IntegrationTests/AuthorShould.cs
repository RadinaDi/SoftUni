using FluentAssertions;
using IntegrationTests.Extensions;
using IntegrationTests.ModelBuilder;
using IntegrationTests.Models;
using IntegrationTests.Utils;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class AuthorShould : BaseTest
    {
        [Fact]
        public async Task BeCreatedSuccessfully()
        {
            var model = AuthorBuilder.NewAuthor();
            var response = await this.HttpClient.SendAsync("/api/authors", HttpMethod.Post, Json.ToJson(model));
            response.StatusCode.Should().Be(HttpStatusCode.Created);

            var body = await response.Content.ReadAsStringAsync();
            var author = Json.ToObject<Author>(body);
            author.Should().Match<Author>(x =>
                                x.Name == $"{model.FirstName} {model.LastName}" &&
                                x.Genre == model.Genre);
        }

        [Fact]
        public async Task BeRetrievedSuccessfully()
        {
            var model = AuthorBuilder.NewAuthor();
            var postResponse = await this.HttpClient.SendAsync("/api/authors", HttpMethod.Post, Json.ToJson(model));
            postResponse.StatusCode.Should().Be(HttpStatusCode.Created);

            var body = await postResponse.Content.ReadAsStringAsync();
            var author = Json.ToObject<Author>(body);

            var getResponse = await this.HttpClient.SendAsync($"/api/authors/{author.Id}", HttpMethod.Get);
            getResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            body = await getResponse.Content.ReadAsStringAsync();
            author = Json.ToObject<Author>(body);
            author.Should().Match<Author>(x =>
                                x.Name == $"{model.FirstName} {model.LastName}" &&
                                x.Genre == model.Genre);
        }

        [Fact]
        public async Task BeDeletedSuccessfully()
        {
            var model = AuthorBuilder.NewAuthor();
            var postResponse = await this.HttpClient.SendAsync("/api/authors", HttpMethod.Post, Json.ToJson(model));
            postResponse.StatusCode.Should().Be(HttpStatusCode.Created);

            var body = await postResponse.Content.ReadAsStringAsync();
            var author = Json.ToObject<Author>(body);

            var deleteResponse = await this.HttpClient.SendAsync($"/api/authors/{author.Id}", HttpMethod.Delete);
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.NoContent);
        }
    }
}
