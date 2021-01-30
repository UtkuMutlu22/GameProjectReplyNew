using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectReply
{
    class GamerManager : IGamerService
    {
        IValidationService validationService;

        public GamerManager(IValidationService validationService)
        {
            this.validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if (validationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız,Kayıt Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
