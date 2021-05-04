using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface IGamerServices
    {
        void Add(Gamer gamer );
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
