﻿using Alisveris.Data;
using Alisveris.Model.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Service.Handlers
{
    public class EditStoreHandler : CommandHandler<Commands.EditStore>
    {
        private readonly IRepository<Alisveris.Model.Entities.Store> storeRepository;
        private readonly IUnitOfWork unitOfWork;
        public EditStoreHandler(IUnitOfWork unitOfWork, IRepository<Alisveris.Model.Entities.Store> storeRepository)
        {
            this.unitOfWork = unitOfWork;
            this.storeRepository = storeRepository;
        }
        public override async Task<dynamic> HandleAsync(Commands.EditStore command)
        {
            Result result;
            // validate the command
            if (string.IsNullOrWhiteSpace(command.Id))
            {
                result = new Result(false, command.Id, "Id gereklidir.", true, null);
                return await Task.FromResult(result);
                
            }
            if (string.IsNullOrWhiteSpace(command.Name))
            {
                result = new Result(false, true, "Ad gereklidir.", true, null);
                return await Task.FromResult(result);
                
            }
            if (command.Name.Length > 200)
            {
                result = new Result(false, true, "Ad 200 karakterden uzun olamaz.", true, null);
                return await Task.FromResult(result);
                
            }
            if (string.IsNullOrWhiteSpace(command.Slug))
            {
                result = new Result(false, true, "Bağlantı gereklidir.", true, null);
                return await Task.FromResult(result);
               
            }
            if (command.Slug.Length > 200)
            {
                result = new Result(false, true, "Bağlantı 200 karakterden uzun olamaz.", true, null);
                return await Task.FromResult(result);
              
            }

            // map command to the model
            var model = Mapper.Map<Alisveris.Model.Entities.Store>(command);

            // mark the model to update
            storeRepository.Update(model);

            // save changes to database
           await unitOfWork.SaveChangesAsync();

            // return the result
            result = new Result(true, model.Id, "Mağaza başarıyla güncellendi.", false, 1);
            return await Task.FromResult(result);
            
        }
    }
}
