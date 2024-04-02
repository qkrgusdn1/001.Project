using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace _001.Project
{
    class GiftBox
    {
        public string? Letter;
        public int Money;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBox addressA = GiftBoxMaker("A 친구야 잘 지내지?", 110000);
            GiftBox addressB = GiftBoxMaker("B 친구야 잘 지내지?", 120000);
            GiftBox addressC = GiftBoxMaker("C 친구야 잘 지내지?", 130000);

            GiftBox[] giftBoxes = new GiftBox[3];
            giftBoxes[0] = addressA;
            giftBoxes[1] = addressB;
            giftBoxes[2] = addressC;

            Console.WriteLine("giftBox Array Count : " + giftBoxes.Length);

            List<GiftBox> giftBoxList = new List<GiftBox>();
            giftBoxList.Add(addressA);
            giftBoxList.Add(addressB);
            giftBoxList.Add(addressC);

            Console.WriteLine(giftBoxList[2].Letter);
            Console.WriteLine("giftbox List Count : " + giftBoxList.Count);

            for (int i = 0; i < giftBoxList.Count; i++)
            {
                giftBoxes[i].Letter = (i + 1) + "번째 편지";
                Console.WriteLine(giftBoxList[i].Letter);
            }

            foreach(GiftBox gift in giftBoxList)
            {
                Console.WriteLine(gift.Letter);
            }

            static GiftBox GiftBoxMaker(string letter, int money)
            {
                GiftBox addressA = new GiftBox()
                {
                    Letter = "A 친구야 잘 지내지?",
                    Money = 110000
                };

                return addressA;
            }
        }
    }
}
