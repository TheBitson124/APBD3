using System;
using cwiczenia3.interfaces;
using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers {

    public class GasContainer : Container, IHazardNotifier

    {
        protected double _pressure { get; set; }
        public GasContainer(double _cargoWeight, int _height, int _selfWeight, int _depth, char _type, int _maxCargoWeight, double pressure) : base(_cargoWeight, _height, _selfWeight, _depth, _type, _maxCargoWeight)
        {
            _pressure = pressure;
        }
        public double Unload()
        {
            double temp = _cargoWeight;
            _cargoWeight = _cargoWeight * 20;
            return temp - _cargoWeight;
        }
        public void Load(double cargoWeight) {
            base.Load(cargoWeight);
        }

        public void Notify(int containerNumber, string message)
        {
            throw new NotImplementedException();
        }
    }
}
