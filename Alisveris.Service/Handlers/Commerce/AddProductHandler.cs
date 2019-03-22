using Alisveris.Data;
using Alisveris.Model.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Service.Handlers
{
    public class AddProductHandler : CommandHandler<Commands.AddProduct>
    {
        private readonly IRepository<Product> productRepository;
        private readonly IUnitOfWork unitOfWork;
        public AddProductHandler(IUnitOfWork unitOfWork, IRepository<Product> productRepository)
        {
            this.unitOfWork = unitOfWork;
            this.productRepository = productRepository;
        }
        public override async Task<dynamic> HandleAsync(Commands.AddProduct command)
        {
            Result result;
            // validate the command
            if (string.IsNullOrWhiteSpace(command.Name))
            {
                result = new Result(false, command.Name, "Ad gereklidir.", true, null);
                return Task.FromResult(result);
            }
            if (command.Name.Length > 200)
            {
                result = new Result(false, command.Name, "Ad 200 karakterden uzun olamaz.", true, null);
                return Task.FromResult(result);
            }
            if (string.IsNullOrWhiteSpace(command.Slug))
            {
                result = new Result(false, command.Slug, "Bağlantı gereklidir.", true, null);
                return Task.FromResult(result);
            }
            if (command.Slug.Length > 200)
            {
                result = new Result(false, command.Slug, "Bağlantı 200 karakterden uzun olamaz.", true, null);
                return Task.FromResult(result);
            }
            if (!string.IsNullOrEmpty(command.MetaTitle) && command.MetaTitle.Length > 200)
            {
                result = new Result(false, command.MetaTitle, "Meta Başlığı 200 karakterden uzun olamaz.", true, null);
                return Task.FromResult(result);
            }

            // map command to the model
            var model = Mapper.Map<Product>(command);

            // mark the model to insert
            productRepository.Insert(model);

            // save changes to database
            await unitOfWork.SaveChangesAsync();

            result = new Result(true, model.Id, "Ürün başarıyla eklendi.", true, 1);
            // return the result
            return Task.FromResult(result);
        }
    }
}
