class Celular
{
    private const double espacioMaximo = 16000;
    private double espacioOcupado = 0;

    public List<App> apps;
    public Celular()
    {
        this.apps = new List<App>();
    }

    public bool InstalarApp(App app)
    {
        bool cond = espacioOcupado + app.peso <= espacioMaximo;
        if (cond)
            this.apps.Add(app);
        return cond;
    }

    public bool ActualizarApp(string nombre)
    {
        int i = this.EncontrarApp(nombre);
        bool r = i != -1;
        if (r)
            apps[i].ActualizarApp();
        return r;
    }

    public bool DesinstalarApp(string nombre)
    {
        int i = this.EncontrarApp(nombre);
        bool r = i != -1;
        if (r)
            apps.Remove(nombre);
        return r;
    }

    public void MostrarAppsInstaladas()
    {
        foreach (App app in this.apps)
        {
            Console.WriteLine("----------");
            Console.WriteLine($"Nombre de la app: {app.nombre}");
            Console.WriteLine($"Peso de la app: {app.peso}");
            Console.WriteLine($"Version de la app: {app.version}");

        }
        Console.WriteLine("----------");
    }

    public void MostrarMemoriaDisponible()
    {
        Console.WriteLine($"Espacio disponible: {this.espacioMaximo - this.espacioOcupado}");
    }

    public void RestaurarDeFabrica()
    {
        this.espacioOcupado = 0;
        this.apps.Clear();
    }

    private int EncontrarApp(string nombre)
    {
        int i = this.apps.Count - 1;
        while (i >= 0 && this.apps[i].nombre != nombre)
            i--;
        return i;
    }
}