﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cinder.Documents;

namespace Cinder.Api.Infrastructure.Repositories
{
    public interface IBlockReadOnlyRepository
    {
        Task<IReadOnlyCollection<CinderBlock>> GetRecentBlocks(int limit = 10, CancellationToken cancellationToken = default);
        Task<CinderBlock> GetBlockByHash(string hash, CancellationToken cancellationToken = default);
    }
}