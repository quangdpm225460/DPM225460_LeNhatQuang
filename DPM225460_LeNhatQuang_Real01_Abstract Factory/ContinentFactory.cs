using System;

namespace DPM225460_LeNhatQuang_Real01_Abstract_Factory
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
