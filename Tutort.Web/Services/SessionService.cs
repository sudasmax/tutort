//using System;
//using System.Web;
//using Tutort.Base;
//using Tutort.Web.Models.Security;
//using Tutort.Web.Models.Session;

//namespace Tutort.Web.Services
//{
//	public class SessionService : ISessionService
//    {
//        private const string _sessionKey = "TutortSession";

//        public ISession CreateSession()
//        {
//            var session = IoC.Get<ISession>();
//            session.SessionId = Guid.NewGuid().ToString();

//            this.SaveSession(session);

//            return session;
//        }

//        public bool HasAccess(Roles accessLevel)
//        {
//            return accessLevel == Roles.Anonymous;
//        }

//        public bool IsAnonymousAccess()
//        {
//            return true;
//        }

//        public ISession LoadSession()
//        {
//            return (ISession)HttpContext.Current.Session[_sessionKey];
//        }

//        public void SaveSession(ISession session)
//        {
//            HttpContext.Current.Session[_sessionKey] = session;
//        }
//    }
//}