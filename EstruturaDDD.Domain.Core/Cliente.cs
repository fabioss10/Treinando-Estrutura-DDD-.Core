

using EstruturaDDDCore.DomainT.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstruturaDDDCore.Domain.Entities
{
    public class Cliente: Entity
    {
        [Column(TypeName = "varchar(100)")]
        public string Nome { get; set; }
    }
}
