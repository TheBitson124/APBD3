using System;
using cwiczenia3.Exceptions;

namespace cwiczenia3.Containers
{
    public class CoolingContainer : Container
    {
        protected PossibleProducts _product { get; set; }
        protected double _temperatue { get; set; }
        public CoolingContainer(double _cargoWeight, int _height, int _selfWeight, int _depth, char _type, int _maxCargoWeight, PossibleProducts product, double tempereature) : base(_cargoWeight, _height, _selfWeight, _depth, _type, _maxCargoWeight)
        {
            _product = product;
            _temperatue = tempereature;
        }
        public void Load(double cargoWeight, PossibleProducts product)
        {
            if (product != _product)
            {
                throw new WrongProductException();
            }
            if (_temperatue > ((double)_product) / 10)
            {
                throw new WrongTemperatureException();
            }
            base.Load(cargoWeight);
        }
    }
}
