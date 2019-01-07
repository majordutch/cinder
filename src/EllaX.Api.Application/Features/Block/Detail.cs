﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EllaX.Data;
using EllaX.Extensions;
using FluentValidation;
using MediatR;

namespace EllaX.Api.Application.Features.Block
{
    public class Detail
    {
        public class Validator : AbstractValidator<Query>
        {
            public Validator()
            {
                RuleFor(m => m.Number).NotEmpty();
            }
        }

        public class Query : IRequest<Model>
        {
            public ulong Number { get; set; }
        }

        public class Model
        {
            public string Number { get; set; }
        }

        public class Handler : IRequestHandler<Query, Model>
        {
            private readonly ApplicationDbContext _db;
            private readonly IMapper _mapper;

            public Handler(ApplicationDbContext db, IMapper mapper)
            {
                _db = db;
                _mapper = mapper;
            }

            public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
            {
                Model model = await _db.Blocks.Where(block => block.Number == request.Number)
                    .ProjectToSingleOrDefaultAsync<Model>(_mapper.ConfigurationProvider);

                return model;
            }
        }
    }
}