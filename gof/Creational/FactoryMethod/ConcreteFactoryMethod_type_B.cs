namespace gof.Creational.FactoryMethod
{
    class ConcreteMethod_type_B : IFactoryMethod
    {
        public string Operation(string param)
        {
            var b_result = "\n{This is typeB method.I like uppercase.I'm " + this.ToString() + ". My param is " + param?.GetType() + "}";
            return b_result.ToUpper();
        }
    }
}
