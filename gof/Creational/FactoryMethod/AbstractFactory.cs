namespace gof.Creational.FactoryMethod
{
    public abstract class AbstractFactory
    {
        //costruisco la classe astratta della Facory

        internal abstract IFactoryMethod TheFactoryMethod();

        public string TypeObject { set; get; }

        public string DoSomething()
        {
            var customComponent = TheFactoryMethod();

            var result = "\n... {Standard Common Implementation}\nThis is a common message.\nThen I'll show you the custom mesage from the factorized method."
                + customComponent.Operation(this.TypeObject);

            return result;
        }
    }
}
