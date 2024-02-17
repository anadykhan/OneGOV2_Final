using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
  
        internal class Repo
        {
            internal OneGOV2Context db;
            internal Repo()
            {
                db = new OneGOV2Context();
            }
        }
    
}
