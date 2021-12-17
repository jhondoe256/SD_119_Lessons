using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_Introduction.Fruits
{
    public class Banana : IFruit
    {
        public Banana()
        {

        }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
       // public string Name => "Banana";
        public string Name 
        {
            get 
            {
                return "Banana";
            }
        }
      //  public bool IsPeeled => false;
        public bool IsPeeled { get; private set; }
        
        public string Peel()
        {
            IsPeeled = true;
            return "You peel the banana.";

        }
    }

    public class Orange : IFruit
    {
        public Orange()
        {

        }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Name 
        {
            get 
            {
                return "Orange";
            }
        }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peel the orange.";
        }
        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out.";
        }
    }

    public class Grape : IFruit
    {
        public Grape()
        {

        }
        public Grape(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Name 
        {
            get 
            {
                return "Grape";
            }
        }

        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            return "Who peels grapes?";
        }
    }

    public abstract class Apple : IFruit
    {
        public string Name 
        {
            get 
            {
                return "Apple";
            }
        }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "The apple is peeled.";
        }
    }
    public class SourApple : Apple, ISour,ISeedable
    {
        public bool HasSeeds { get; set; } = false;

        public void BiteTheApple()
        {
            if (HasSeeds==true)
            {
                Console.WriteLine("Yuck, I bit a seed!!!");
            }
            else
            {
                Console.WriteLine("Yum, I love sour apples.");
            }
        }
    }
}
