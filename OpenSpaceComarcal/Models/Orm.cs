using System;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace OpenSpaceComarcal.Models
{
    public static class Orm
    {
        public static openSpaceComarcalEntities bd = new openSpaceComarcalEntities();

        public static String MensajeError(SqlException sqlException)
        {
            String missatge = "";

            switch (sqlException.Number)
            {
                case 2:
                    missatge = "El servidor no esta operativo";
                    break;
                case 547:
                    missatge = "El registro tiene datos relacionados";
                    break;
                case 2601:
                    missatge = "Registro duplicado";
                    break;
                case 2627:
                    missatge = "Registro duplicado";
                    break;
                case 4060:
                    missatge = "No se pudo abrir la base de datos";
                    break;
                case 18456:
                    missatge = "Error al iniciar sesión";
                    break;
                default:
                    missatge = sqlException.Number + " - " + sqlException.Message;
                    break;
            }

            return missatge;
        }

        public static String MySaveChanges()
        {
            String missatge = "";
            try
            {
                Orm.bd.SaveChanges();

                // Recargar entidades específicas
                foreach (var entry in bd.ChangeTracker.Entries().Where(e => e.Entity is alumno || e.Entity is inscripcion))
                {
                    entry.Reload();
                }
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                missatge = Orm.MensajeError(sqlException);
                Console.WriteLine(missatge);
                Console.WriteLine(ex);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("InnerException: " + ex.InnerException.Message);

                    if (ex.InnerException.InnerException != null)
                    {
                        Console.WriteLine("Inner InnerException: " + ex.InnerException.InnerException.Message);
                    }
                }
                RejectChanges();
            }

            return missatge;
        }

        private static void RejectChanges()
        {
            foreach (DbEntityEntry item in bd.ChangeTracker.Entries())
            {
                switch (item.State)
                {
                    case System.Data.Entity.EntityState.Detached:
                        break;
                    case System.Data.Entity.EntityState.Unchanged:
                        break;
                    case System.Data.Entity.EntityState.Added:
                        item.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        item.Reload();
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        item.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    default:
                        break;

                }
            }
        }

    }
}
