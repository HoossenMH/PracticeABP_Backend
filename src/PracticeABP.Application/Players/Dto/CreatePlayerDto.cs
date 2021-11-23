using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace PracticeABP.Players
{
    [AutoMapFrom(typeof(Player))]
    [AutoMapTo(typeof(Player))]
    public class CreatePlayerDto
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }
    }
}