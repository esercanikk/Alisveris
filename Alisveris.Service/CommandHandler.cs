﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Service
{
    public interface ICommandHandler
    {
        dynamic Handle(Command command);
        Task<dynamic> HandleAsync(Command command);
    }

    public interface ICommandHandler<T> : ICommandHandler where T : Command
    {
        dynamic HandleAsync(T command);
        Task<dynamic> HandleAsync(T command);
    }


    public abstract class CommandHandler<T> : ICommandHandler<T> where T : Command
    {

        public virtual async Task<dynamic> HandleAsync(T command)
        {
            return await HandleAsync((T)command);
        }
        public virtual async Task<dynamic> HandleAsync(Command command)
        {
            return await HandleAsync((T)command);
        }

        public virtual dynamic Handle(Command command)
        {
            return HandleAsync((T)command);
        }

        public virtual dynamic HandleAsync(T command)
        {
            throw new NotImplementedException();
        }
    }
}
