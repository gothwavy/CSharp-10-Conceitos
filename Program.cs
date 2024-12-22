namespace _10_AtributosMetodosEstaticos
{
    class Program()
    {
        static void Main(string[] args)
        {
            // Exibir o valor contido no atributo numero
            Console.WriteLine($"O valor e: {Calculadora.numero}");

            // Utilizando o metodo soma
            Calculadora.Soma(10, 8);

            // O metodo static faz com que um atributo ou um metodo de uma classe fique disponivel para todas as outras classes sem que voce precise instanciar um objeto.
        }
    }
}
