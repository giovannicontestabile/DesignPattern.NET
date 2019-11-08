namespace gof.Creational.FactoryMethod
{
    public abstract class AbstractFactory
    {
        //costruisco la classe astratta della Facory

        internal abstract IFactoryMethod TheFactoryMethod(string param);

        public string TypeObject { set; get; }

        public string DoSomething()
        {
            var customComponent = TheFactoryMethod(this.TypeObject);

            var result = "\n... {Standard Common Implementation}\nThis is a common message.\nThen I'll show you the custom mesage from the factorized method."
                + customComponent.Operation(TypeObject);

            return result;
        }
    }
}
