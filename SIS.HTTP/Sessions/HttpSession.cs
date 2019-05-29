using SIS.HTTP.Common;
using SIS.HTTP.Sessions.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.HTTP.Sessions
{
    public class HttpSession : IHttpSession
    {
        private Dictionary<string, object> sessionParametars;
        public HttpSession(string id)
        {
            this.Id = id;
            this.sessionParametars = new Dictionary<string, object>();
        }
        public string Id { get; }

        public void AddParametar(string name, object parametar)
        {
            CoreValidator.ThrowIfNullOrEmpty(name, nameof(name));
            CoreValidator.ThrowIfNull(parametar, nameof(parametar));
            this.sessionParametars[name] = parametar;
        }

        public void ClearParametars()
        {
            this.sessionParametars.Clear();
        }

        public bool ContainsParametar(string name)
        {
            CoreValidator.ThrowIfNullOrEmpty(name, nameof(name));
            return this.sessionParametars.ContainsKey(name);
        }

        public object GetParametar(string name)
        {
            CoreValidator.ThrowIfNullOrEmpty(name, nameof(name));
            return this.sessionParametars[name];
        }
    }
}
