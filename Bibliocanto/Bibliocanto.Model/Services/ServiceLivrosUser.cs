using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliocanto.Model.Repositories;

namespace Bibliocanto.Model.Services
{
    public class ServiceLivrosUser
    {
        public RepositoryLivrosUser oRepositoryLivrosUser {  get; set; }
        public RepositoryGenero oRepositoryGenero { get; set; }
        public RepositorySimNao oRepositorySimNao { get; set;}

        public ServiceLivrosUser() 
        {
            oRepositoryLivrosUser = new RepositoryLivrosUser();
            oRepositoryGenero = new RepositoryGenero();
            oRepositorySimNao = new RepositorySimNao();
        }
    }
}
