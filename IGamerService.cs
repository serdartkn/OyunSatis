using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
