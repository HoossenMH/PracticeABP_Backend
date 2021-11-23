using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;

using PracticeABP.Authorization;
using PracticeABP.Players.Dto;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticeABP.Players
{
    [AbpAuthorize(PermissionNames.Pages_Players)]
    public class PlayerAppService : AsyncCrudAppService<Player, PlayerDto, int, PagedAndSortedResultRequestDto, CreatePlayerDto, PlayerDto>, IPlayerAppService
    {
        private readonly IRepository<Player> _repository;

        public PlayerAppService(IRepository<Player> repository) : 
            base(repository)
        {
            _repository = repository;
        }

        public override async Task<PlayerDto> Create(CreatePlayerDto input)
        {
            var player = ObjectMapper.Map<Player>(input);

            await _repository.InsertAsync(player);

            return MapToEntityDto(player);
        }
    }
}
