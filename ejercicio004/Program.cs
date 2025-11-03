namespace ejercicio004
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            bool programaCorriendo = true;
            
            Varios varios = new Varios();

            while (programaCorriendo) 
            {
                OpcionMenu(varios, ref programaCorriendo);
            }
        }

        public static void OpcionMenu(Varios varios, ref bool programaCorriendo)
        {

            Console.WriteLine
                (
                "\nSeleccione una opción:\n" +
                "P: Imprimir primos\n" +
                "N: Imprimir no primos\n" +
                "S: Salir del programa\n"
                );

            string opcion = Console.ReadLine().ToUpper();

            switch (opcion) 
            {
                case "P":
                    varios.ImprimirPrimos();
                    break;
                case "N":
                    varios.ImprimirNoPrimos();
                    break;
                case "S":
                    programaCorriendo = false;
                    break;
                default:
                    Console.WriteLine("Error: Caracter no especificado\n");
                    break;
            }
        }
    }
}
