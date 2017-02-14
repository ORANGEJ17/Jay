using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017._2._14_Workshop_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice Dice1 = new Dice();
            Console.WriteLine(Dice1.StrFaceUp);
            Console.ReadKey();
        }

    }
    class Dice
    {
        //attributes
        private int FaceUp;

        //methods 1
        public void Throw()
        {
            Random ran0 = new Random();
            int ran = ran0.Next(1, 6);
            FaceUp = ran;
        }

        //methods 2
        public int GetFaceUp()
        {
            return FaceUp;
        }

        //constructors
        public Dice()
        {
            Throw();
        }

        //properties
        public int StrFaceUp
        {
            get
            {
                if (FaceUp == 1)
                    return 1;
                else if (FaceUp == 2)
                    return 2;
                else if (FaceUp == 3)
                    return 3;
                else if (FaceUp == 4)
                    return 4;
                else if (FaceUp == 5)
                    return 5;
                else
                    return 6;
            }
        }
    }

}
