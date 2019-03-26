﻿using Alisveris.Data;
using Alisveris.Model.Entities;
using Alisveris.Service.Queries.Commerce;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Service.Handlers.Cms
{
    public class GetAdvertisementHandler : CommandHandler<Commands.GetAdvertisement>
    {
        private readonly IRepository<Advertisement> advertisementRepository;
        public GetAdvertisementHandler(IRepository<Advertisement> advertisementRepository)
        {
            this.advertisementRepository = advertisementRepository;
        }
        public override async Task<dynamic> HandleAsync(Commands.GetAdvertisement command)
        {
            Result result;
            // get the model from database
            var model = advertisementRepository.Get(command.Id);

            // if nothing found
            if (model == null)
            {
                // return the not found result
                result = new Result(true, command.Id, "Reklam bulunamadı.", true, 0);
                return await Task.FromResult(result);
            }
            // map the model to query
            var value = Mapper.Map<AdvertisementQuery>(model);

            // return the query result
            result = new Result(true, value, "1 adet reklam bulundu.", false, 1);
            return await Task.FromResult(result);
        }
    }
}
