namespace IlkaPoint.Migrations
{
    using IlkaPoint.Clases;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IlkaPoint.Clases.AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IlkaPoint.Clases.AppDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //  PARA RESUMIR EN ESPAÑOL, CADA VEZ QUE SE ACTUALIZA LA BASE DE DATOS DESDE LA CONSOLA
            //  VA A CORRER ESTA LINEA DE CODIGO, ESTO NOS SERVIRA PARA GUARDAR LA CLAVE CIFRADA

            try
            {
                if (!context.Admins.Any()) //Si no hay administradores existentes
                {
                    context.Admins.Add(new Clases.Administrador
                    {
                        PassEncrypted = CifradoXOR.Cifrar("Abarroteria")
                    });
                    context.SaveChanges();
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var validationError in error.ValidationErrors)
                    {
                        throw new Exception($"Campo: {validationError.PropertyName} - Error: {validationError.ErrorMessage}");
                    }
                }
            }
        }
    }
}
