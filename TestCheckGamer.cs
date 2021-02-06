using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    class TestCheckGamer : ICheckRealGamer
    {
        public bool CheckGamerInfo(Gamer gamer)
        {
            return true;
        }
    }
}
