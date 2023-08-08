namespace BlackFridayDiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do produto:");
            if (decimal.TryParse(Console.ReadLine(), out decimal valorProduto))
            {
                decimal desconto = CalcularDesconto(valorProduto, 0.6m);
                decimal valorComDesconto = valorProduto - desconto;

                Console.WriteLine($"a) Produto custava: {valorProduto:C}");
                Console.WriteLine($"b) Valor do desconto: {desconto:C}");
                Console.WriteLine($"c) Com o desconto: {valorComDesconto:C}");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }

            Console.ReadKey();
        }

        static decimal CalcularDesconto(decimal valor, decimal descontoPercentual)
        {
            decimal desconto = valor * descontoPercentual;
            return Math.Round(desconto, 2);
        }
    }
}