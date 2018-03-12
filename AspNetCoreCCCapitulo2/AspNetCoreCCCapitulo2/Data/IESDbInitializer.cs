using AspNetCoreCCCapitulo2.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreCCCapitulo2.Data
{
    public static class IESDbInitializer
    {
        private static IEnumerable<Departamento> departamentos;

        public static  void Initializer(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Departamentos.Any())
            {
                return;
            }

            var departamento = new Departamento[]
            {
                new Departamento {Nome="Ciência da Computação"},
                new Departamento {Nome="Ciência de Alimentos"}
            };

            foreach(Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }

            context.SaveChanges();


        }
    }
}
