using EstruturaDDDCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD.infra.DataR.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {



        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome)
            .IsRequired()
            .HasColumnName("nome")
            .HasColumnType("varchar(100)");
        }
    }
}
