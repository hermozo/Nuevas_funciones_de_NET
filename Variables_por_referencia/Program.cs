class Program
{
    static void Main(string[] args)
    {
        // valores definidos como paramtros de salida
        Cambiar(out int valor);
        Console.WriteLine(valor);

        // Retorno locales por referencia
        string[] colores = { "negro", "blanco", "azul", "verde" };
        ref string color = ref BuscarOroReferencia(0, colores);
        color = "Violeta";
        Console.WriteLine(colores[0]);

    }

    static ref string BuscarOroReferencia(int position, string[] cols)
    {
        if (cols.Length > 0) {
            return ref cols[position];
        }
        throw new IndexOutOfRangeException("No existe el index");
    }

    static void Cambiar(out int valor)
    {
        int i = 100;
        valor = i * 500;
    }
}