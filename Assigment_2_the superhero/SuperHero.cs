using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2_the_super_hero
{
    class SuperHero : Hero
    { //PRIVATE INSTANCE VARIABLES **************************
        private string[] _superPowers;

        //initializing object for the predefined random class
        Random powers = new Random();

        //PUBLIC PROPERTIES *******************************
        public SuperHero(string name)
            : base(name)
        {
            this._superPowers = new string[3];
            _generateRandomPowers();
        }
        //PRIVATE METHODS********************************************************
        /**
         * <summary>
         * This is method give super powers to hero's and Describe 
         * 3 super powers to the hero. The list give an array for the 
         * super powers.
         * The add atribute provide the no of powers in the list.
         * </summary>
         * @method _generateRandomPowers
         * @return {void}
         */
        private void _generateRandomPowers()
        {
            List<string> superPowersList = new List<string>();
            superPowersList.Add("Armordillo");
            superPowersList.Add("regenerability");
            superPowersList.Add("mind control");
            superPowersList.Add("super sonic: Banshee");
            superPowersList.Add("Energy Absorbing");
            superPowersList.Add("teleportability");
            superPowersList.Add("thunder control");
            superPowersList.Add("transformability");


            for (int i = 0; i < 3; i++)
            {
                int randomPower = powers.Next(0, superPowersList.Count);
                _superPowers[i] = superPowersList.ElementAt(randomPower);
                superPowersList.RemoveAt(randomPower);
            }
        }
        //PUBLIC METHODS *********************************
        /**
         * <summary>
         * This method provide the super powers of the hero
         * to  console
         * </summary>
         * @method ShowPowers
         * @return {void}
         */
        public void ShowPowers()
        {
            Console.WriteLine("The Super Hero {0} has the following super powers.", base.Name);
            Console.WriteLine("-------------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(_superPowers[i]);
            }
            Console.WriteLine("-------------------");
        }
    }
}
