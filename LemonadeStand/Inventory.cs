﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<Lemonade> Lemonades;

        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
            Lemonades = new List<Lemonade>();
            AddLemonsToInventory(20);
            AddSugarCubesToInventory(20);
            AddIceCubesToInventory(100);
            AddCupsToInventory(30);
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
        // Remove Items
        public void RemoveLemonsFromInventory(int numberOfLemons)
        {
            for (int i = 0; i < numberOfLemons; i++)
            {
                if(lemons.Count > 0)
                {
                    lemons.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("You don't lemons in your inventory");
                }
            }
        }

        public void RemoveSugarCubesFromInventory(int numberOfSugarCubes)
        {
            for (int i = 0; i < numberOfSugarCubes; i++)
                if (sugarCubes.Count > 0)
                {
                    sugarCubes.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("You don't have sugar cubes in your inventory");
                }
        }

        public void RemoveIceCubesFromInventory(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i++)
                if (iceCubes.Count > 0)
                {
                    iceCubes.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("You don't have ice cubes in your inventory");
                }
        }

        public void RemoveCupsFromInventory(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i++)
                if (cups.Count > 0)
                {
                    cups.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("You don't have cups in your inventory");
                }
        }

        public void AddLemonade(int numberOfLemonade)
        {
            for (int i = 0; i < numberOfLemonade; i++)
            {
                Lemonade lemonade = new Lemonade();  
            }
        }

        public void RemoveLemonade(int numberOfLemonade)
        {
            for (int i = 0; i < numberOfLemonade; i++)
                if (Lemonades.Count > 0)
                {
                    Lemonades.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("You don't have anymore lemonade in your inventory");
                }
        }
    }
}
