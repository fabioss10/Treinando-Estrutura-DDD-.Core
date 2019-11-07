using System;



public class ModeloContexto : DbContext

{
	public ModeloContexto() 
        : base ("ConexaoDDDNetCore")
	{


	}

    public DbSet<Cliente> Clientes { get; set; }
}
