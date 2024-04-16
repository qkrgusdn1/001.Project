using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Project
{
    class GiftBoxManager
    {
        public void SetInt()
        {
            GiftBox addressA = GiftBoxMaker("A 친구야 잘 지내지?", 110000, ITEM_GRADE.NORMAL);
            GiftBox addressB = GiftBoxMaker("B 친구야 잘 지내지?", 120000, ITEM_GRADE.RARE);
            GiftBox addressC = GiftBoxMaker("C 친구야 잘 지내지?", 130000, ITEM_GRADE.UNIQUE);
            Console.WriteLine($"addressC : letter : {addressC.Letter} item : {addressC.Grade}");
        }

        private GiftBox GiftBoxMaker(string letter, int money, ITEM_GRADE itemGrade)
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = letter,
                Money = money,
                Grade = itemGrade
            };

            return addressA;
        }
    }
}
