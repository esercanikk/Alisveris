using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service
{
    public interface ICommandHandler
    {
        dynamic Handle(Command command);
    }

    public interface ICommandHandler<T> : ICommandHandler where T : Command
    {
        dynamic Handle(T command);
    }


    public abstract class CommandHandler<T> : ICommandHandler<T> where T : Command
    {
        public abstract dynamic Handle(T command);

        public virtual Task<dynamic> HandleAsync(T command)
        {
            throw new Exception("not implemented");
        }


        public dynamic Handle(Command command)
        {
            return Handle((T)command);
        }
    }
}
