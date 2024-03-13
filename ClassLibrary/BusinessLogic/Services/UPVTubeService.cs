using UPVTube.Entities;
using UPVTube.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Reflection;

namespace UPVTube.Services
{
    public class UPVTubeService: IUPVTubeService
    {
        private readonly IDAL dal;

        private Member user;

        public UPVTubeService(IDAL dal)
        {
            this.dal = dal;
        }
        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }
        
        public void DBInitialization()
        {
            RemoveAllData();

            Subject s1 = new Subject(11555, "Ingeniería del software", "ISW");
            AddSubject(s1);
            Subject s2 = new Subject(11553, "Arquitectura e ingeniería de computadores", "AIC");
            AddSubject(s2);
            Subject s3 = new Subject(11548, "Bases de datos y sistemas de información", "BDA");
            AddSubject(s3);
            Subject s4 = new Subject(11560, "Sistemas inteligentes", "SIN");
            AddSubject(s4);

            // Añadir los 4 miembros
            Member user1 = new Member("kike@gmail.com", "Enrique León", DateTime.Now, "kike", "kike");
            SignUp(user1);
            Member user2 = new Member("jianeng@inf.upv.es", "Jianeng Huang", DateTime.Now, "jianeng", "jianeng");
            SignUp(user2);
            Member user3 = new Member("nasko@disca.upv.es", "Atanas Todorov", DateTime.Now, "nasko", "nasko");
            SignUp(user3);
            Member user4 = new Member("liwei@inf.upv.es", "Liwei Hu Zeng", DateTime.Now, "liwei", "liwei");
            SignUp(user4);

            // Añadir los 5 contenidos

            Content c1 = new Content("aaa", "Max subjects", true, "Titulo post 1", DateTime.Now, user4);
            Content c2 = new Content("bbb", "One subject", true, "Titulo post 2", DateTime.Now, user2);
            Content c4 = new Content("ddd", "No subject", true, "Titulo post 3", DateTime.Now, user2);
            Content c3 = new Content("ccc", "Private post", false, "Titulo post 4", DateTime.Now, user4);
            Content c5 = new Content("eee", "Post privado no autorizado", false, "Titulo post 5", DateTime.Now, user4);
            c1.Authorized = Authorized.Yes;
            c2.Authorized = Authorized.Yes;
            c3.Authorized = Authorized.Yes;
            c4.Authorized = Authorized.Yes;
            c5.Authorized = Authorized.Pending;
            c1.Subjects.Add(s1);
            c2.Subjects.Add(s2);
            c1.Subjects.Add(s3);
            c1.Subjects.Add(s4);
            contentUpload(c1);
            contentUpload(c2);
            contentUpload(c3);
            contentUpload(c4);
            contentUpload(c5);


        }

        public IList<Member> AllMembers()
        {
            return new List<Member>(dal.GetAll<Member>());
        }

        public IList<Subject> GetSubjects()
        {
            return new List<Subject>(dal.GetAll<Subject>());
        }
        public Member getMemberbyNickname(String nickname) { 
            return dal.GetById<Member>(nickname);
        }
        public Subject getSubjectbyCode(String Code ) {
            return dal.GetById<Subject>(Code);
        }

        public Content getContentbyId(String id)
        {
            return dal.GetById<Content>(int.Parse(id));
        }


        public void AddSubject(Subject subject)
        {
            // Restricción: No puede haber dos asignaturas con el mismo code
            if (dal.GetById<Subject>(subject.Code) == null)
            {
                // Restricción: No puede haber dos asignaturas con el mismo name
                if (!dal.GetWhere<Subject>(x => x.Name == subject.Name).Any())
                {
                    // Sólo se salva si no hay Code ni email duplicado
                    dal.Insert<Subject>(subject);
                    dal.Commit();
                }
                else
                    throw new ServiceException("Subject with name " + subject.Name + " already exists.");
            }
            else
                throw new ServiceException("Subject with code " + subject.Code + " already exists.");
        }

        public Member Login(String nick, String password)
        {
            user = dal.GetById<Member>(nick);

            if (user == null)
            {
                IEnumerable<Member> miembros = dal.GetWhere<Member>(m => m.Email == nick);
                if(miembros.Count() == 0) { throw new ServiceException("El usuario introducido no existe."); }
                else { user = miembros.First(); }
                
            }
            if (user.Password == password)
                return user;
            throw new ServiceException("Contraseña incorrecta.");
        }

        public void Logout()
        {
            if (user == null) throw new ServiceException("No hay un usuario con la sesión iniciada");
            Member auxM = dal.GetById<Member>(user.Nick);
            auxM.LastAccessDate = DateTime.Now;
            dal.Commit();
            user = auxM;
            this.user = null;
        }
        public void contentEvaluationUpdate(Content content, Boolean selection)
        {
            if (selection)
            {
                dal.GetById<Content>(content.Id).Authorized = Authorized.Yes;
                dal.Commit();
            }
                dal.GetById<Content>(content.Id).Authorized = Authorized.No;
                dal.Commit();
        }
        // A partir de aquí los métodos para implementar los CU
        public void SignUp(Member member)
        {
            if ((dal.GetById<Member>(member.Nick) == null) && (!dal.GetWhere<Member>(x => x.Email == member.Email).Any()))
            {
                dal.Insert<Member>(member);
                dal.Commit();
            }
            else
            {
                throw new ServiceException("This member already exists.");
            }
        }

        public void contentUpload(Content content) {
            if (content != null)
            {
                dal.Insert<Content>(content);
                dal.Commit();
            }
            else 
            { 
                throw new ServiceException("This content cannot be uploaded"); 
            }
        }

        public Visualization getLastVisualizations(Member viewer, Content content)
        {
            ParameterExpression c = Expression.Parameter(typeof(Visualization), "c");
            MemberExpression cOwner = Expression.Property(c, "Member");
            MemberExpression cOwnerNick = Expression.Property(cOwner, "Nick");
            MemberExpression cContent = Expression.Property(c, "Content");
            MemberExpression cContentId = Expression.Property(cContent, "Id");
            ConstantExpression viewerNick = Expression.Constant(viewer.Nick, typeof(string));
            ConstantExpression contentId = Expression.Constant(content.Id, typeof(int));
            BinaryExpression sameViewer = Expression.Equal(viewerNick, cOwnerNick);
            BinaryExpression sameContent = Expression.Equal(contentId, cContentId);
            Expression query = Expression.AndAlso(sameViewer, sameContent);
            IEnumerable<Visualization> res = dal.GetWhere<Visualization>(Expression.Lambda<Func<Visualization, bool>>(query, new[] { c })).OrderByDescending(cf => cf.VisualizationDate);
            if (res.Count() > 0)
                return res.First();
            return null;
        }

        public IEnumerable<Content> findContent(DateTime from, DateTime to, Member owner, string keyword, Subject subject, bool forAutorization)
        {
            Expression query = Expression.Constant(true, typeof(bool));
            ParameterExpression c = Expression.Parameter(typeof(Content), "c");
            MemberExpression cOwner = Expression.Property(c, "Owner");
            MemberExpression cOwnerNick = Expression.Property(cOwner, "Nick");
            MemberExpression cTitle = Expression.Property(c, "Title");
            MemberExpression cUploadDate = Expression.Property(c, "UploadDate");
            MemberExpression cPublic = Expression.Property(c, "IsPublic");
            MemberExpression cAutorization = Expression.Property(c, "Authorized");


            if (owner != null)
            {
                ConstantExpression ownerNick = Expression.Constant(owner.Nick, typeof(string));
                BinaryExpression isOwner = Expression.Equal(ownerNick, cOwnerNick);
                query = Expression.AndAlso(query, isOwner);
            }

            if(keyword != null)
            {
                ConstantExpression kw = Expression.Constant(keyword, typeof(string));
                MethodInfo methodContains = typeof(string).GetMethod("Contains", new[] { typeof(string) });
                MethodCallExpression methodCallExpression = Expression.Call(cTitle, methodContains, kw);
                query = Expression.AndAlso(query, methodCallExpression);
            }

            if(from != null)
            {
                ConstantExpression iniDate = Expression.Constant(from, typeof(DateTime));
                BinaryExpression greaterThanIni = Expression.LessThanOrEqual(iniDate, cUploadDate);
                query = Expression.AndAlso(query, greaterThanIni);
            }

            if(to != null)
            {
                ConstantExpression endDate = Expression.Constant(to, typeof(DateTime));
                BinaryExpression lessThanEnd = Expression.GreaterThanOrEqual(endDate, cUploadDate);
                query = Expression.AndAlso(query, lessThanEnd);
            }


            if(!(user.IsTeacher() || user.IsStudent())) 
            {
                BinaryExpression isPublic = Expression.Equal(cPublic, Expression.Constant(true));
                query = Expression.AndAlso(query, isPublic);
            }

            if(forAutorization)
            {
                ConstantExpression aut = Expression.Constant(Authorized.Pending, typeof(Authorized));
                BinaryExpression forAut = Expression.Equal(cAutorization, aut);
                query = Expression.AndAlso(query, forAut);
            }

            IEnumerable<Content> res = dal.GetWhere<Content>(Expression.Lambda<Func<Content, bool>>(query, new[] { c })).OrderBy(cf => cf.UploadDate);
            
            if (subject != null)
                res = res.Where<Content>(cf => cf.Subjects.Contains(subject));
            
            return res;
        }


        public IEnumerable<Content> findSuscribed()
        {
            Expression query = Expression.Constant(false, typeof(bool));
            ParameterExpression c = Expression.Parameter(typeof(Content), "c");
            MemberExpression cOwner = Expression.Property(c, "Owner");
            MemberExpression cOwnerNick = Expression.Property(cOwner, "Nick");
            MemberExpression cUploadDate = Expression.Property(c, "UploadDate");

            foreach (Member suscribed in user.SubscribedTo)
            {
                ConstantExpression suscribedNick = Expression.Constant(suscribed.Nick, typeof(string));
                BinaryExpression isSuscribed = Expression.Equal(suscribedNick, cOwnerNick);
                Expression.Or(query, isSuscribed);
            }

            ConstantExpression iniDate = Expression.Constant(user.LastAccessDate, typeof(DateTime));
            BinaryExpression greaterThanIni = Expression.LessThanOrEqual(iniDate, cUploadDate);
            query = Expression.AndAlso(query, greaterThanIni);

            IEnumerable<Content> res = dal.GetWhere<Content>(Expression.Lambda<Func<Content, bool>>(query, new[] { c }));
            return res;
        }


        public Content viewContent(Content content) 
        {
            if (user == null) throw new ServiceException("Inicia sesión para ver tu contenido");
            return content;
        }


        public IEnumerable<Content> getNotEvaluatedContent()
        {
            if (user == null) throw new ServiceException("Antes de evaluar contenido, debes iniciar sesión");
            if (!user.IsTeacher()) throw new ServiceException("Solo los profesores pueden evaluar el contenido");

            return dal.GetWhere<Content>(content => content.Evaluation == null).OrderBy(x => x.UploadDate);
        }

        public void saveEvaluatedContent(Evaluation evaluation, Authorized authorized)
        {
            if (authorized == Authorized.No && evaluation.RejectionReason == null) throw new ServiceException("Se tienen que justificar porque se ha rechazado");
            evaluation.EvaluationDate = DateTime.Now;

            evaluation.Content.Authorized = authorized;
        }

        public Member getLogged() { return getMemberbyNickname(user.Nick); }
    }
}
