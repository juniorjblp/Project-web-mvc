using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.svc
{
    public class LoginSvc
    {
        public bool loginVendedor(string username, string senha)
        {
            if(username == "root" && senha == "root"){
                return true;
            }
            return false;
        }

        public bool loginCliente(string user, string senha)
        {
            if(loginVendedor(user, senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
