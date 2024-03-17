using System;
using System.Collections.Generic;
using cwiczenia3.Containers;
namespace cwiczenia3.Ships {
    internal class Ship
    {
        private List<Container> _kontenery { get; set; }
        private double _speed { get; set; }
        private int _maxContainerNumber { get; set; }
        private int _maxWeight { get; set; }
        private int _currentWeight { get; set; }

        public Ship(double speed, int maxContainerNumber, int maxWeight)
        {
            _kontenery = new List<Container>();
            _speed = speed;
            _maxContainerNumber = maxContainerNumber;
            _maxWeight = maxWeight;
            _currentWeight = 0;
        }

        public void newLiquidContainer(int _height, int _selfWeight, int _depth, char _type, int _maxCargoWeight,
            string _cargoType)
        {
            _kontenery.Add(new LiquidContainer(0 ,_height, _selfWeight, _depth, _type,
                 _maxCargoWeight,  _cargoType));
            _currentWeight += _selfWeight;

        }

        public void newCoolingContainer(int _height, int _selfWeight, int _depth, char _type, int _maxCargoWeight,
            PossibleProducts product, double tempereature)
        {
            _kontenery.Add(new CoolingContainer(0,  _height,  _selfWeight,  _depth,  _type,
                 _maxCargoWeight, product,  tempereature));
            _currentWeight += _selfWeight;
        }

        public void newGasContainer(int _height, int _selfWeight, int _depth, char _type, int _maxCargoWeight,
            double pressure)
        {
            _kontenery.Add(new GasContainer(0,  _height,  _selfWeight,  _depth,  _type,
                _maxCargoWeight,pressure));
            _currentWeight += _selfWeight;
        }

        public void addToLiquidContainer(string serialNumber, double cargoWeight, string cargoType)
        {
            if (_currentWeight + cargoWeight > _maxWeight)
            {
                throw new NotImplementedException();
            }

            LiquidContainer container = containers.Find(c => c.get_serialNumber == serial);
            if (container != null)
            {
                throw new NotImplementedException();
            }

            container.Load(cargoWeight, cargoType);

        }

        public void addToGasContaier(string serialNumber, double cargoWeight)
        {
            if (_currentWeight + cargoWeight > _maxWeight)
            {
                throw new NotImplementedException();
            }

            GasContainer container = containers.Find(c => c.get_serialNumber == serial);
            if (container != null)
            {
                throw new NotImplementedException();
            }

            Gascontainer.Load(cargoWeight);

        }

        public void addToCoolingContaier(string serialNumber, double cargoWeight, PossibleProducts product)
        {
            if (_currentWeight + cargoWeight > _maxWeight)
            {
                throw new NotImplementedException();
            }

            CoolingContainer container = containers.Find(c => c.serialNumber == serial);
            if (container != null)
            {
                throw new NotImplementedException();
            }

            container.Load(cargoWeight, product);
        }

        public void LoadContainer(Container container)
        {
            if (container.get_weight + container.get_selfWeight + _currentWeight > _maxWeight ||
                _kontenery.Count == _maxContainerNumber)
            {
                throw new NotImplementedException();
            }

            _kontenery.add(container);
        }

        public void LoadContainerList(List<Container> kontenery)
        {
            if (_kontenery.Count + kontenery.Count > _maxContainerNumber)
            {
                throw new NotImplementedException();
            }

            double weight = 0.0;
            foreach (Container container in kontenery)
            {
                weight += container.get_weight;
            }

            if (weight + _currentWeight > _maxWeight)
            {
                throw new NotImplementedException();
            }

            _currentWeight += weight;
            _kontenery.addRange(kontenery);
        }

        public void deleteContainer(string serialNumber)
        {
            _kontenery.removeAll(c => c.serialNumber == serialNumber);

        }

        public void unloadContainer(string serialNumber)
        {
            Container container = containers.Find(c => c.serialNumber == serialNumber);
            _currentWeight -= container.Unload() + container.get_selfWeight;
            _kontenery.remove(container);
        }

        public void swapContainer(Container addContainer, string serialNumber)
        {
            unloadContainer(serialNumber)
            LoadContainer(addContainer);
        }

        public void moveContainer(Ship ship, string serialNumber)
        {
            Container container = containers.Find(c => c.serialNumber == serialNumber);
            unloadContainer(serialNumber);
            ship.LoadContainer(container);
        }

        public void readContainer(string serialNumber)
        {
            Container container = containers.Find(c => c.serialNumber == serialNumber);
            Console.WriteLine(container.toString());
        }

        public void readShip()
        {
            this.toString();
        }

        public void ToString()
        {
            Console.WriteLine(
                "_speed = " + speed + " _maxContainerNumber" + speed "_maxWeight" + _maxWeight "_currentWeight" +
                _currentWeight
            );
        }
    }
}
