using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar
{
    class Titanic
    {
        public int numberOfLookouts = 2;
        public int numberOfLookoutPosts = 2;
        public int numberOfIcebergs;
        public int iceDamage = 0;



        public Titanic(int numberOfLookouts, int numberOfLookoutPosts)
        {
            this.numberOfLookouts = numberOfLookouts;
            this.numberOfLookoutPosts = numberOfLookoutPosts;
            
        }
        public void lookoutOnDuty()
        {
            Console.WriteLine("Warrant Officer! Lookout Status!");
            Console.WriteLine("Ice watch One and Two on duty Sir!");

        } 


        public int checkForIcebergs(int iceDamage, int numberOfIcebergs)
        {
            this.numberOfIcebergs = numberOfIcebergs;
            this.iceDamage = iceDamage;
            Random iceberg = new Random();
            int bergCheck = iceberg.Next(iceDamage);
            return bergCheck;
            if(bergCheck <= 1)
            {
                Console.WriteLine("No ice in sight!. Full Speed ahead, Sir!");
            }
            else
            {
                Console.WriteLine("ICE dead ahead sir!");
            }

        }
    }

}

