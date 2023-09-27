using ExemploClasseMetodo.Classes;

namespace ExemploClasseMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro;
            meuCarro = new Carro("VW", "GOL");

            //migrado para o método construtor
            //meuCarro._marca = "VW";
            //meuCarro._modelo = "GOL";

            //alterado o modificador de acesso para privado
            //meuCarro._marca = "FORD";

            meuCarro.Ligar();

            Console.ReadLine();
        }
    }
}