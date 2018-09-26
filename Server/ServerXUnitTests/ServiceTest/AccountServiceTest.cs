using System;
using Microsoft.EntityFrameworkCore;
using Server.Database.DatabaseContext;
using Server.Service;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Xunit;

namespace ServerXUnitTests.ServiceTest
{
    public class AccountServiceTest
    {
        [Fact]
        public async void RegistrateAsync()
        {
            //Arrange
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWalletTest;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            AccountService service = new AccountService(context);
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
            bool result = await service.RegistrateAsync(token);

            //Assert
            Assert.True(result);
        }
    }
}
