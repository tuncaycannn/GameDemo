using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.Name=="Tuncay" && gamer.Surname=="CAN" && gamer.TcNo=="55555455455" && gamer.Birthday=="01.01.1998")
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
