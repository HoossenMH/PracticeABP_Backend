using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;
using Abp.Application.Services.Dto;
using PracticeABP.Players;
using PracticeABP.Players.Dto;

namespace PracticeABP.Tests.Players
{
    public class PlayerAppService_Tests : PracticeABPTestBase
    {
        private readonly IPlayerAppService _playerAppService;

        public PlayerAppService_Tests()
        {
            _playerAppService = Resolve<IPlayerAppService>();
        }

        [Fact]
        public async Task CreatePlayer_Test()
        {
            // Act
            await _playerAppService.Create(
                new CreatePlayerDto
                {
                    Name = "Hasan",
                    Age = 28,
                    Height = 1.65,
                });

            await UsingDbContextAsync(async context =>
            {
                var player = await context.Players.FirstOrDefaultAsync(u => u.Name == "Hasan");
                player.ShouldNotBeNull();
            });
        }
    }
}
