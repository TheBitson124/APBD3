using System;

using cwiczenia3.Exceptions;
namespace cwiczenia3.Containers
{
    public abstract class Container : Interfaces.IContainer
    {
        public double _cargoWeight { get; set; }
        protected int _height { get; set; }
        protected int _selfWeight { get; set; }
        protected int _depth { get; set; }
        protected string _serialNumber { get; set; }
        protected int _maxCargoWeight { get; set; }
        protected char _type { get; set; }
        protected int _containerNumber { get; set; }
        private static int _number = 0;

        public Container(double _cargoWeight, int _height, int _selfWeight, int _depth, char _type, int _maxCargoWeight)
        {
            _cargoWeight = _cargoWeight;
            _height = _height;
            _selfWeight = _selfWeight;
            _depth = _depth;
            _type = _type;
            _maxCargoWeight = _maxCargoWeight;
            _containerNumber = _number;
            _serialNumber = "KON-" + _type + "-" + _number;
            _number++;
        }

        public virtual double Unload()
        {
            double temp = _cargoWeight;
            _cargoWeight = 0;
            return temp;
        }
        public virtual void Load(double cargoWeight)

        {
            _cargoWeight += cargoWeight;
            if (_cargoWeight > _maxCargoWeight)
            {
                _cargoWeight -= cargoWeight;
                throw new OverfillException();
            }
        }
    }
}

