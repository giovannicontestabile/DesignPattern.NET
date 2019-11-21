namespace gof.Creational.FactoryMethod
{
    class ConcreteMethod_type_A : IFactoryMethod
    {
        public string Operation(string param)
        {
            var a_result = "\n{This is typeA method.I'm " + this.ToString() + ". My param is " + param?.ToString() + "}\n\n";
            return a_result;
        }
    }
}
