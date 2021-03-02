using GameStore.Business.Abstract;
using GameStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Business.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("ÜRÜN ID : " + game.Id);
            Console.WriteLine("ÜRÜN İSMİ : " + game.GameName);
            Console.WriteLine("ÜRÜN TÜRÜ : " + game.GameKind);
            Console.WriteLine("ÜRÜN FİYATI : " + game.Price);

            Console.WriteLine("ÜRÜN BİLGİSİ BAŞARIYLA EKLENDİ!");
            Console.WriteLine("----------------------------------------------------------");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("ÜRÜN ID : " + game.Id);
            Console.WriteLine("ÜRÜN İSMİ : " + game.GameName);
            Console.WriteLine("ÜRÜN TÜRÜ : " + game.GameKind);
            Console.WriteLine("ÜRÜN FİYATI : " + game.Price);

            Console.WriteLine("ÜRÜN BİLGİSİ BAŞARIYLA SİLİNDİ!");
            Console.WriteLine("----------------------------------------------------------");
        }

        public void Update(Game game)
        {
            Console.WriteLine("ÜRÜN ID : " + game.Id);
            Console.WriteLine("ÜRÜN İSMİ : " + game.GameName);
            Console.WriteLine("ÜRÜN TÜRÜ : " + game.GameKind);
            Console.WriteLine("ÜRÜN FİYATI : " + game.Price);

            Console.WriteLine("ÜRÜN BİLGİSİ BAŞARIYLA GÜNCELLENDİ!");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
