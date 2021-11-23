using Abp.Application.Services;
using Abp.Application.Services.Dto;

using PracticeABP.Players.Dto;

using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeABP.Players
{
    public interface IPlayerAppService : IAsyncCrudAppService<PlayerDto, int, PagedAndSortedResultRequestDto, CreatePlayerDto, PlayerDto>
    {
    }
}
