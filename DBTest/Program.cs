using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UPVTube.Entities;
using UPVTube.Persistence;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new UPVTubeDbContext());

            CreateSampleDB(dal);

        }

        private void CreateSampleDB(IDAL dal)
        {
            // Remove all data from DB
            dal.RemoveAllData();

            Console.WriteLine("\n// CREACIÓN DE UN MIEMBRO - ALUMNO");

            // public Member(String email, string fullName, DateTime lastAccessDate, string nick, string password)

            Member a1 = new Member("bart@inf.upv.es", "Bart Simpson", DateTime.Now, "Bart", "1234");
            dal.Insert<Member>(a1);
            dal.Commit();

            Console.WriteLine("\n// CREACIÓN DE UN CONTENIDO");

            //public Content(string contentURI, string description, bool isPublic, string title, DateTime uploadDate, Member owner)

            Content c1 = new Content("URI al contenido del vídeo", "Vídeo de cómo se rasca un gato cuando le pica algo", true, "Gato rascándose", DateTime.Now, a1);
            a1.AddContent(c1);  // Hay que implementar el método AddContent(Content c) en Member
            dal.Insert<Content>(c1);
            dal.Commit();

            Console.WriteLine("Se acaba de subir un nuevo vídeo en: " + c1.ContentURI + " creado por " + c1.Owner.FullName);
            Console.WriteLine("\n// PULSE UNA TECLA PARA CONTINUAR");
            Console.ReadKey();
            Console.WriteLine("\n// CREACION DE UN MIEMBRO - PROFESOR");
            Member p1 = new Member("Krab@dsic.upv.es", "Edna Krabappel", DateTime.Now, "Edna", "4321");
            dal.Insert<Member>(p1);
            dal.Commit();

            Console.WriteLine("\n// PULSE UNA TECLA PARA CONTINUAR");
            Console.ReadKey();

            Console.WriteLine("\n// CREACION DE EVALUACION, COMENTARIO, Y VISUALIZACION DEL PROFESOR");

            Evaluation e1 = new Evaluation(DateTime.Now, "Aprobado", p1, c1);
            dal.Insert<Evaluation>(e1);
            dal.Commit();

            Visualization v1 = new Visualization(DateTime.Now, c1, p1);
            dal.Insert<Visualization>(v1);
            dal.Commit();

            Comment cm1 = new Comment("Este es el video del trabajo de Edna", DateTime.Now, c1, a1);
            dal.Insert<Comment>(cm1);
            dal.Commit();
            Console.WriteLine("\n// PULSE UNA TECLA PARA CONTINUAR");
            Console.ReadKey();

            Console.WriteLine("\n// CREACION DE UNA ASIGNATURA Y ASIGNACION DEL VIDEO A LA ASIGNATURA");
            Subject s1 = new Subject(666, "Religion", "REL");
            c1.Subjects.Add(s1);
            s1.Contents.Add(c1);
            dal.Insert<Subject>(s1);
            dal.Commit();

            Console.WriteLine("\n// FINALIZACION");

        }

    }
}
