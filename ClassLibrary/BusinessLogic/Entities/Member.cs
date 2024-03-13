using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Member
    {
        public Member() {
            
            this.Subscriptors = new List<Member>();
            this.SubscribedTo = new List<Member>();
            this.Visualizations = new List<Visualization>(); 
            this.Contents = new List<Content>();
            this.Evaluations = new List<Evaluation>();
            this.Comments = new List<Comment>();
        }

        public Member(string email, string fullName, DateTime lastAccessDate, string nick, string password) : this() { 
            this.FullName = fullName;
            this.Nick = nick;
            this.Password = password;
            this.LastAccessDate = lastAccessDate;
            this.Email= email;
        }

        // La implementación para saber si es un alumno o un profesor pasa por dos atributos de clase y dos métodos
        static private List<String> TeacherDomains = new List<string> { "@dsic.upv.es", "@disca.upv.es" };
        static private List<String> StudentDomains = new List<string> { "@inf.upv.es" };

        /// <summary>
        /// Devuelve true si el correo es de un profesor
        /// </summary>
        /// <returns></returns>
        public bool IsTeacher()
        {
            foreach (String alias in TeacherDomains)
                if (Email.Contains(alias)) return true;
            return false;
        }

        /// <summary>
        /// Devuelve true si el correo es de un alumno (de la lista de servidores de alumno)
        /// </summary>
        /// <returns></returns>
        public bool IsStudent()
        {
            foreach (String alias in StudentDomains)
                if (Email.Contains(alias)) return true;
            return false;
        }

        public void AddContent(Content c1)
        {
            Contents.Add(c1);
        }
    }
}
