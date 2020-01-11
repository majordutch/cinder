﻿using System.Threading.Tasks;
using Cinder.Api.Application.Features.Stats;
using Cinder.Core.Paging;
using Cinder.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinder.Api.Host.Controllers
{
    public class StatsController : BaseController
    {
        [HttpGet("richest")]
        [ProducesResponseType(typeof(GetRichest.Model), StatusCodes.Status200OK)]
        public async Task<IPage<GetRichest.Model>> GetRichest([FromQuery] int? page, [FromQuery] int? size)
        {
            return await Mediator.Send(new GetRichest.Query {Page = page, Size = size}).AnyContext();
        }

        [HttpGet("supply")]
        [ProducesResponseType(typeof(GetSupply.Model), StatusCodes.Status200OK)]
        public async Task<GetSupply.Model> GetSupply()
        {
            return await Mediator.Send(new GetSupply.Query()).AnyContext();
        }

        [HttpGet("netinfo")]
        [ProducesResponseType(typeof(GetNetInfo.Model), StatusCodes.Status200OK)]
        public async Task<GetNetInfo.Model> GetNetInfo()
        {
            return await Mediator.Send(new GetNetInfo.Query()).AnyContext();
        }

        [HttpGet("price")]
        [ProducesResponseType(typeof(GetPrice.Model), StatusCodes.Status200OK)]
        public async Task<GetPrice.Model> GetPrice()
        {
            return await Mediator.Send(new GetPrice.Query()).AnyContext();
        }
    }
}
