public static class Funciones
{

    public static string IngresarTexto(string Mensaje)
    {
        Console.Write(Mensaje);
        string valor = Console.ReadLine();
        return valor;
    }
    public static int IngresarNumero(string Mensaje)
    {
        bool pude = false;
        int valor;
        do
        {
            Console.Write(Mensaje);
            pude = int.TryParse(Console.ReadLine(), out valor);
        } while (!pude);
        return valor;
    }
    
    public static double IngresarNumeroConDecimales(string Mensaje)
    {
        bool pude = false;
        double valor;
        do
        {
            Console.Write(Mensaje);
            pude = double.TryParse(Console.ReadLine(), out valor);
        } while (!pude);
        return valor;
    }
    public static bool IngresarSiNo(string Mensaje)
    {
        bool pude = false;
        string valor;
        do
        {
            Console.WriteLine(Mensaje);
            valor = Console.ReadLine();
            pude = valor.ToUpper() == "SI" || valor.ToUpper() == "NO";
        } while (!pude);
        return valor.ToUpper() == "SI";
    }
}