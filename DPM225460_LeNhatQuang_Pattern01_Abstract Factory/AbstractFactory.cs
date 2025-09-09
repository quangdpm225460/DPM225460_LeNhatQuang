using System;

namespace DPM225460_LeNhatQuang_Pattern01_Abstract_Factory
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
