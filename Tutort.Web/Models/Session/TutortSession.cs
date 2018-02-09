using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutort.Web.Models.Session
{
    public class TutortSession : ISession
    {
        public string SessionId { get; set; }
    }
}