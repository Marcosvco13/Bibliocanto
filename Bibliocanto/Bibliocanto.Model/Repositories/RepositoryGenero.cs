using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliocanto.Model.Models;
using Trab_AV2.Model.Repositories;

namespace Bibliocanto.Model.Repositories
{
    public class RepositoryGenero : RepositoryBase<Genero>
    {
        public RepositoryGenero(bool saveChanges = true) : base(saveChanges)
        { 
        }
    }
}
