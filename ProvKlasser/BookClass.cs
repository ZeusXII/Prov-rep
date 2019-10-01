using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvKlasser
{
    class BookClass
    {
        public int price;
        private string name;
        private int rarity;
        private string catagory;
        private int actualValue;
        private bool cursed;

        Random generator = new Random();
        List<string> itemName = new List<string>();
        List<string> itemCatogory = new List<string>();





        public void Book (string name, string catogory)
        {
            itemName.Add("Book of boooo");
            itemName.Add("Book of enchanting");
            itemName.Add("Book of NTI");

            itemCatogory.Add("Physics");
            itemCatogory.Add("Nature");
            itemCatogory.Add("Language");

            int numNa = itemName.Count;
            name = itemName[generator.Next(numNa)];

            int numCat = itemCatogory.Count;
            catogory = itemCatogory[generator.Next(numCat)];


            rarity = generator.Next(0, 100);
            actualValue = generator.Next(0, 100);
            //if(cursed = generator.Next(2))



        }
        public void PrintInfo()
        {
            Console.WriteLine("Rarity: " + rarity + "\n Actual value: " + actualValue + "\n Name: " + itemName + "\n Catogory: " + itemCatogory);
        }
        /*

        public int Evaluate()
        {

        }

        public string GetCategory()
        {

        }

        public string GetName()
        {

        }
        public bool isCursed()
        {

        }
        */
    }
}
