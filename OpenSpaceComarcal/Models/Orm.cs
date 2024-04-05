﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpaceComarcal.Models
{
    public static class Orm
    {
        public static open_spaceEntities bd = new open_spaceEntities();

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
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                missatge = Orm.MensajeError(sqlException);
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
