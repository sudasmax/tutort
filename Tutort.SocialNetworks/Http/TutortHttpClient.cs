using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Tutort.Core.Helpers;
using Tutort.SocialNetworks.Instagram.Exceptions;

namespace Tutort.SocialNetworks.Http
{
    public class TutortHttpClient
    {
        public static void GetResponse<T>(string url, Action<T> callback) where T : class
        {
            Guard.ArgumentNotNull(url, "url");
            Guard.ArgumentNotNull(callback, "callback");

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.OpenReadCompleted += (o, a) =>
                    {
                        if (callback != null)
                        {
                            T data = DeserializeFromStream<T>(a.Result);
                            callback(data);
                        }
                    };

                    webClient.OpenReadAsync(new Uri(url));
                }
            }
            catch (WebException ex)
            {
                throw new InstagramException(ex);
            }
        }

        public static T GetResponse<T>(string url) where T : class
        {
            Guard.ArgumentNotNull(url, "url");

            try
            {
                using (WebClient webClient = new WebClient())
                using (var stream = webClient.OpenRead(new Uri(url)))
                {
                    T result = DeserializeFromStream<T>(stream);

                    return result;
                }
            }
            catch (WebException ex)
            {
                throw new InstagramException(ex);
            }
        }

        public static T GetPostResponse<T>(string url, NameValueCollection parameters) where T : class
        {
            Guard.ArgumentNotNull(url, "url");
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    var data = webClient.UploadValues(new Uri(url), parameters);
                    T result = DeserializeFromData<T>(data);

                    return result;
                }
            }
            catch (WebException ex)
            {
                throw new InstagramException(ex);
            }
        }

        public static T DeserializeFromStream<T>(Stream stream)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<T>(jsonTextReader);
            }
        }

        public static T DeserializeFromData<T>(byte[] data)
        {
            var json = Encoding.Default.GetString(data);
            return (T)JsonConvert.DeserializeObject(json, typeof(T));
        }
    }
}
