using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;


namespace UPVTube.Services
{
    public interface IUPVTubeService
    {
        
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();
        void AddSubject(Subject subject);

        //
        // A partir de aquí los necesarios para los CU solicitados
        //
        Member Login(String nick, String password);
        IList<Member> AllMembers();
        IList<Subject> GetSubjects();
        Subject getSubjectbyCode(String code);
        Member getMemberbyNickname(String nick);
        void Logout();
        void contentEvaluationUpdate(Content content, Boolean selection);
        void SignUp(Member member);
        Content getContentbyId(String id);
        void contentUpload(Content content);
        Visualization getLastVisualizations(Member viewer, Content content);
        IEnumerable<Content> findContent(DateTime initialDate, DateTime finalDate, Member creator, string title, Subject subject, bool forAutorization);
        Content viewContent(Content content);
        IEnumerable<Content> getNotEvaluatedContent();
        void saveEvaluatedContent(Evaluation evaluation, Authorized authorized);
        Member getLogged();

    }
}
