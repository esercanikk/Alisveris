using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Sipariş silindi.")]
    public class DeleteOrder : Command
    {
        public string Id { get; set; }
    }
}
