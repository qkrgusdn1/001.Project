using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace _001.Project
{
    

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("시작 부분");
            int aPersonMoney = 10000;
            int bPersonMoney = aPersonMoney;
            aPersonMoney = 20000;
            Console.WriteLine("aPersonMoney : " + aPersonMoney);
            Console.WriteLine("bPersonMoney : " + bPersonMoney);

            GiftBox aPersonGiftBox = new GiftBox()
            {
                Letter = "안녕",
                Money = 10000
            };

            GiftBox bPersonGiftBox = aPersonGiftBox;
            bPersonGiftBox.Money = 20000;
            Console.WriteLine("aPersonGiftBox : " + aPersonGiftBox.Money);
            Console.WriteLine("bPersonGiftBox : " + bPersonGiftBox.Money);
        }
    }
}
