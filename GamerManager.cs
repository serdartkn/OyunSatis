using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    class GamerManager : IGamerService
    {
        ICheckRealGamer _checkRealGamer;
        public GamerManager(ICheckRealGamer checkRealGamer)
        {
            _checkRealGamer = checkRealGamer;
        }
        public void Add(Gamer gamer)
        {
            if (_checkRealGamer.CheckGamerInfo(gamer))
            {
                Console.WriteLine("Yeni Kullanıcı Kaydı Başarıyla Oluşturuldu.\nHoşgeldin " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                throw new Exception("Kimlik Bilgileri Yanlış");
            }            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Üye Kaydı Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Bilgiler Başarıyla Güncellendi.");
        }
    }
}
