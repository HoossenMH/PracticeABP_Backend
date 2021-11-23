using Abp.Application.Services.Dto;
using Abp.AutoMapper;

using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeABP.Players.Dto
{
    [AutoMapFrom(typeof(Player))]
    [AutoMapTo(typeof(Player))]
    public class PlayerDto : EntityDto<int>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }
    }
}
