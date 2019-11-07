using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EstruturaDDDCore.DomainT.Entities
{
    public class Cliente: Entity
    {

        public string Nome { get; set; }
    }
}
