﻿using Application.IServices;
using Application.Services;
using Domain.Entities;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class ConsumerService : GenericServices<Consumer>, IConsumerService
    {
        public ConsumerService(IConsumerRepository repository, IConsumerCommandService commandService)
            : base(repository, commandService)
        {
        }
    }
}
