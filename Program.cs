internal class Program
{
    static Celular celular = new Celular();

    private static void Main(string[] args)
    {
        int opcion;
        do
        {
            MostrarMenu();
            opcion = Funciones.IngresarNumero("Ingrese una opción: ");

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    InstalarApp();
                    break;

                case 2:
                    ActualizarApp();
                    break;

                case 3:
                    DesinstalarApp();
                    break;

                case 4:
                    MostrarAppsInstaladas();
                    break;

                case 5:
                    MostrarMemoriaDisponible();
                    break;

                case 6:
                    RestaurarDeFabrica();
                    break;

                case 7:
                    Console.WriteLine("¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
        }
        while (opcion != 7);
    }

    static void InstalarApp()
    {
        string nombre = Funciones.IngresarTexto("Nombre de la app: ");
        double peso = Funciones.IngresarNumeroConDecimales("Peso de la app (MB): ");
        App app = new App(nombre, peso);
        if (celular.InstalarApp(app))
        {
            Console.WriteLine("App instalada con éxito.");
        }
        else
        {
            Console.WriteLine("No hay suficiente memoria para instalar la app.");
        }
    }

    static void ActualizarApp()
    {
        string nombre = Funciones.IngresarTexto("Nombre de la app a actualizar: ");
        if (celular.ActualizarApp(nombre))
        {
            Console.WriteLine("App actualizada con éxito.");
        }
        else
        {
            Console.WriteLine("La app no está instalada.");
        }
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Instalar app");
        Console.WriteLine("2. Actualizar app");
        Console.WriteLine("3. Desinstalar app");
        Console.WriteLine("4. Mostrar apps instaladas");
        Console.WriteLine("5. Mostrar memoria disponible");
        Console.WriteLine("6. Restaurar de fábrica");
        Console.WriteLine("7. Salir");
        Console.WriteLine();
    }

    static void MostrarAppsInstaladas()
    {
        celular.MostrarAppsInstaladas();
    }

    static void MostrarMemoriaDisponible()
    {
        celular.MostrarMemoriaDisponible();
    }

    static void RestaurarDeFabrica()
    {
        celular.RestaurarDeFabrica();
        Console.WriteLine("Celular restaurado de fábrica.");
    }

    static void DesinstalarApp()
    {
        string nombre = Funciones.IngresarTexto("Nombre de la app a desinstalar: ");
        if (celular.DesinstalarApp(nombre))
        {
            Console.WriteLine("App desinstalada con éxito.");
        }
        else
        {
            Console.WriteLine("La app no está instalada.");
        }
    }
}