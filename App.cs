class App
{
    public string nombre { get; private set; }
    public double peso { get; private set; }
    public int version { get; private set; }

    public App(string nombre, double peso)
    {
        this.nombre = nombre;
        this.peso = peso;
        // Asumo que empieza en la versión 1
        this.version = 1;
    }

    public void ActualizarApp()
    {
        this.version++;
    }
}