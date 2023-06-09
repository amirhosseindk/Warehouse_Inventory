﻿using Application.IServices;
using Application.Services;
using Domain.Entities;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class MeasureService : GenericServices<UnitMeasure>, IMeasureService
    {
        public MeasureService(IMeasureRepository repository, IMeasureCommandService commandService)
            : base(repository, commandService)
        {
        }
    }
}
