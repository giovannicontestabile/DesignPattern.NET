namespace gof.Creational.FactoryMethod
{
    class ConcreteFactory_type_B : AbstractFactory
    {
        internal override IFactoryMethod TheFactoryMethod()
        {
            init();
            return new ConcreteMethod_type_B();
        }

        void init()
        {
            this.TypeObject = "B";
        }
    }
}
