using CoronaMed.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model.Command
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand, INotifiable
    {
        Task ExecuteAsync(TCommand command);

    }
}
