namespace gof.Creational.FactoryMethod
{
    public class ConcreteFactory_type_A : AbstractFactory
    {
        internal override IFactoryMethod TheFactoryMethod(string param)
        {
            return new ConcreteMethod_type_A();
        }
        void init()
        {
            this.TypeObject = "A";
        }
    }
}
