﻿using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Nethereum.BlockchainProcessing.BlockStorage.BlockStorageStepsHandlers;
using Nethereum.RPC.Eth.DTOs;
using Periscope.Core.Extensions;
using Periscope.Data.Repositories;

namespace Periscope.Indexing.BlockIndexer.Host.Infrastructure.StepsHandlers
{
    public class CinderTransactionReceiptStorageStepHandler : TransactionReceiptStorageStepHandler
    {
        private readonly ILogger<CinderTransactionReceiptStorageStepHandler> _logger;

        public CinderTransactionReceiptStorageStepHandler(ILogger<CinderTransactionReceiptStorageStepHandler> logger,
            ITransactionRepository transactionRepository, IAddressTransactionRepository addressTransactionRepository = null) :
            base(transactionRepository, addressTransactionRepository)
        {
            _logger = logger;
        }

        protected override async Task ExecuteInternalAsync(TransactionReceiptVO value)
        {
            _logger.LogDebug("Processing transaction receipt");
            await base.ExecuteInternalAsync(value).AnyContext();
        }
    }
}
