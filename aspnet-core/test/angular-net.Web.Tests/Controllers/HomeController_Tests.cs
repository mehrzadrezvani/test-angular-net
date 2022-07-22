using System.Threading.Tasks;
using angular-net.Models.TokenAuth;
using angular-net.Web.Controllers;
using Shouldly;
using Xunit;

namespace angular-net.Web.Tests.Controllers
{
    public class HomeController_Tests: angular-netWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}