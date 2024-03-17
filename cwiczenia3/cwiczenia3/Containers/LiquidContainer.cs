using cwiczenia3.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cwiczenia3.Interfaces;
using cwiczenia3.interfaces;

namespace cwiczenia3.Containers
{
    public class LiquidContainer : Container , IHazardNotifier
    {
        protected string _cargoType { get; set; }
        public LiquidContainer( double _cargoWeight, int _height, int _selfWeight, int _depth, char _type, int _maxCargoWeight,string _cargoType) 
        : base( _cargoWeight,  _height,  _selfWeight,  _depth,  _type,  _maxCargoWeight)
        {
                _cargoType = _cargoType;
        }
        public void Load(double cargoWeight,string cargoType)
        {
            _cargoWeight += cargoWeight;
            if (cargoType.Equals("niebezpieczny"))
            {
               
                if(_cargoWeight > _maxCargoWeight /2)
                {
                    _cargoWeight -= cargoWeight;
                     Notify(
                         _containerNumber, "próba niebezpiecznej operacji");
                }
            }
            else
            {
                if (_cargoWeight > _maxCargoWeight * 9/ 10)
                {
                    _cargoWeight -= cargoWeight;
                    Notify(_containerNumber, "próba niebezpiecznej operacji");
                }
            }
            
        }
        public void Notify(int containerNumber, string message)
        {
            Console.WriteLine(containerNumber +  message);
        }
    }
}
