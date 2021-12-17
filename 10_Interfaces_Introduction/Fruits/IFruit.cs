using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_Introduction.Fruits
{
    //this is a contract...
    public interface IFruit
    {
        string Name { get; }
        bool IsPeeled { get;}
        string Peel();
    }

    public interface ISour 
    {
        void BiteTheApple();
    }

    public interface ISeedable 
    {
        bool HasSeeds { get; set; }
    }
}
