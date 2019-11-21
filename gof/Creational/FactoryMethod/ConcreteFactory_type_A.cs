namespace gof.Creational.FactoryMethod
{
    class ConcreteFactory_type_A : AbstractFactory
    {
        internal override IFactoryMethod TheFactoryMethod()
        {
            init();
            return new ConcreteMethod_type_A();
        }

        void init()
        {
            this.TypeObject = "A";
        }
    }
}
