using System;
using System.Net;
using Tutort.SocialNetworks.Http;
using Tutort.SocialNetworks.Instagram.Models;

namespace Tutort.SocialNetworks.Instagram.Exceptions
{
    public class InstagramException : Exception
    {
        public ExceptionData Details { get; set; }

        public InstagramException()
        {
        }

        public InstagramException(string message)
            : base(message)
        {
        }

        public InstagramException(WebException exception)
            : base(exception.Message, exception)
        {
            if (exception.Response != null)
            {
                var stream = exception.Response.GetResponseStream();
                this.Details = TutortHttpClient.DeserializeFromStream<ExceptionData>(stream);
            }
        }
    }
}
