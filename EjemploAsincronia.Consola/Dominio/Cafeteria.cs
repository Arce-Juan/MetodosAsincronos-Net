using System;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploAsincronia.Consola.Dominio
{
    public class Cafeteria
    {
        #region Metodos No Asincronos
        public void PrepararCafeConLeche()
        {
            Console.WriteLine("Empecemos a realizar el desayuno.");
            Console.WriteLine(CalentarAgua());
            Console.WriteLine(CalentarLeche());
            Console.WriteLine("Preparar taza.");
            Console.WriteLine("Colocar cafe en saquito.");
            Console.WriteLine("Verter agua caliente.");
            Console.WriteLine("Verter leche caliente .");
            Console.WriteLine("Colocar azucar.");
            Console.WriteLine("Colocar preparar la mesa.");
            Console.WriteLine("Beber.");
        }

        public string CalentarAgua()
        {
            Console.WriteLine("Agua colocada en pava");
            Console.WriteLine("Calentando agua...");
            Thread.Sleep(3000);
            return "Agua caliente lista!!";
        }

        public string CalentarLeche()
        {
            Console.WriteLine("Leche colocada en micro ondas");
            Console.WriteLine("Calentando leche...");
            Thread.Sleep(5000);
            return "Leche caliente lista!!";
        }
        #endregion

        #region Metodos Asincronos
        public async Task PrepararCafeConLecheAsync()
        {
            Console.WriteLine("Empecemos a realizar el desayuno.");
            var resultadoAgua = CalentarAguaAsync();
            var resultadoLeche = CalentarLecheAsync();
            Console.WriteLine("Preparar taza.");
            Console.WriteLine("Colocar cafe en saquito.");
            Console.WriteLine(await resultadoAgua);
            Console.WriteLine(await resultadoLeche);
            Console.WriteLine("Colocar azucar.");
            Console.WriteLine("Colocar preparar la mesa.");
            Console.WriteLine("Beber.");
        }

        public async Task<string> CalentarAguaAsync()
        {
            Console.WriteLine("Agua colocada en pava");
            Console.WriteLine("Calentando agua...");
            await Task.Delay(3000);
            return "Agua caliente lista!!";
        }

        public async Task<string> CalentarLecheAsync()
        {
            Console.WriteLine("Leche colocada en micro ondas");
            Console.WriteLine("Calentando leche...");
            await Task.Delay(5000);
            return "Leche caliente lista!!";
        }
        #endregion
    }
}
