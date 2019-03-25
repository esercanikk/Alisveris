﻿using Alisveris.Data;
using Alisveris.Model.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Service.Handlers.Commerce
{
    public class AddBrandHandler : CommandHandler<Commands.AddBrand>
    {
        private readonly IRepository<Brand> brandRepository;
        private readonly IUnitOfWork unitOfWork;
        public AddBrandHandler(IUnitOfWork unitOfWork, IRepository<Brand> brandRepository)
        {
            this.unitOfWork = unitOfWork;
            this.brandRepository = brandRepository;
        }
        public override async Task<dynamic> HandleAsync(Commands.AddBrand command)
        {
            Result result;
            // validate the command
            if (string.IsNullOrWhiteSpace(command.Name))
            {
                result = new Result(false, command.Name, "Adı gereklidir.", true, null);
                return await Task.FromResult(result);
            }
            if (command.Name.Length > 200)
            {
                result = new Result(false, command.Name, "Ad 200 karakterden uzun olamaz.", true, null);
                return await Task.FromResult(result);
            }
            if (string.IsNullOrWhiteSpace(command.Slug))
            {
                result = new Result(false, command.Slug, "Bağlantı gereklidir.", true, null);
                return await Task.FromResult(result);
            }
            if (command.Slug.Length > 200)
            {
                result = new Result(false, command.Slug, "Bağlantı 200 karakterden uzun olamaz.", true, null);
                return await Task.FromResult(result);
            }
            if (string.IsNullOrWhiteSpace(command.Image))
            {
                result = new Result(false, command.Image, "Resim gereklidir.", true, null);
                return await Task.FromResult(result);
            }
            if (command.Image.Length > 200)
            {
                result = new Result(false, command.Image, "Resim 200 karakterden uzun olamaz.", true, null);
                return await Task.FromResult(result);
            }

            // map command to the model
            var model = Mapper.Map<Brand>(command);

            // mark the model to insert
            brandRepository.Insert(model);

            // save changes to database
            await unitOfWork.SaveChangesAsync();

           
            result = new Result(true, model.Id, "Marka başarıyla eklendi.", true, 1);
            // return the result
            return await Task.FromResult(result);
        }
    }
}
