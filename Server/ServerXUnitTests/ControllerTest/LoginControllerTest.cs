using Microsoft.EntityFrameworkCore;
using Server.Controllers;
using Server.Database.DatabaseContext;
using Server.Service.Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Xunit;

namespace ServerXUnitTests.ControllerTest
{
    public class LoginControllerTest
    {
        [Fact]
        public async void Post_NewUser_NotNull()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            LoginController controller = new LoginController(context);
            string id = new Random().Next().ToString();
            IEnumerable<Claim> claims = new List<Claim>()
            {
                new Claim("given_name","MyName"),
                new Claim("family_name","MySurname"),
                new Claim("email",string.Format("myEmail{0}@email.com",id)),
            };
            JwtPayload payload = new JwtPayload(claims)
            {
                ["sub"] = "mySub" + id
            };
            JwtSecurityToken security = new JwtSecurityToken(new JwtHeader(), payload);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            string token = handler.WriteToken(security);

            //Act
            Token result = await controller.Post(token);

            //Assert
            Assert.True(result != null);
        }

        [Fact]
        public async void Post_OldUser_NotNull()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            LoginController controller = new LoginController(context);
            IEnumerable<Claim> claims = new List<Claim>()
            {
                new Claim("given_name","MyName"),
                new Claim("family_name","MySurname"),
                new Claim("email","myEmail@email.com"),
            };
            JwtPayload payload = new JwtPayload(claims)
            {
                ["sub"] = "mySub"
            };
            JwtSecurityToken security = new JwtSecurityToken(new JwtHeader(), payload);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            string token = handler.WriteToken(security);

            //Act
            Token result = await controller.Post(token);

            //Assert
            Assert.True(result != null);
        }
    }
}
