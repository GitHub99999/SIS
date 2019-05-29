using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.HTTP.Sessions.Contracts
{
    public interface IHttpSession
    {
         string Id { get;  }

        object GetParametar(string name);

        bool ContainsParametar(string name);

        void AddParametar(string name, object parametar);

        void ClearParametars();
    }
}
