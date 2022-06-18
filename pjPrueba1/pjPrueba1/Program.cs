using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPrueba1
{
     class Program
    {
        static void Main(string[] args)
        {
            using (BDPRUEBA1Entities db = new BDPRUEBA1Entities())
            {
                #region Agregar
                //try
                //{
                //    Gente oGente = new Gente();
                //    oGente.nombre = "Alex";
                //    oGente.edad = 25;
                //    oGente.idsexo = 4;
                //    db.Gente.Add(oGente);
                //    db.SaveChanges();
                //}
                //catch (DbEntityValidationException e)
                //{
                //    foreach (var eve in e.EntityValidationErrors)
                //    {
                //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                //        foreach (var ve in eve.ValidationErrors)
                //        {
                //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                //                ve.PropertyName, ve.ErrorMessage);
                //        }
                //    }
                //    throw;
                //}
                #endregion

                #region Editar
                //Gente oGente = db.Gente.Where(d => d.nombre == "Alex").First();
                //oGente.edad = 30; 
                //db.Entry(oGente).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();
                #endregion

                #region Eliminar
                //Gente oGente = db.Gente.Find(5);

                //db.Gente.Remove(oGente);
                //db.SaveChanges(); 
                #endregion

                var lst = db.Gente;
                foreach (var oGente_ in lst) 
                {
                    Console.WriteLine(oGente_.nombre);
                }     
             
            }
            Console.Read();
        }
    }
}
