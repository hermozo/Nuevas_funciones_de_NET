class Program {
    record Usuario(int Id, string Name, string Descripcion, int Edad);
    static void Main(string[] args)
    {
        // funcion IS
        Usuario usuario = new Usuario(1, "", "", 23);
        if (usuario.Descripcion is null) 
        { 
            Console.WriteLine("Descripcion es null"); 
        }
        Console.WriteLine(usuario.ToString());

        // switch case con clases
        Perro animal = new Perro();
        switch (animal)
        {
            case null: 
                Console.WriteLine("es una clase Null...");
                break;
            case Animal:
                Console.WriteLine("Es de la clase animal...");
                break;
        }

        //  funciona y procedimientos locales
        int x = 10;
        int y = 40;
        void Suma() {
            Console.WriteLine(x + y);
        }
        Suma();

        int Sumar()
        {
            return x + y;
        }
        Console.WriteLine(Sumar());

        Func<int, int, int> add = delegate (int x, int y)
        {
            return x + y;
        };
        Console.WriteLine(add(3, 4));


        Action<string> greet = delegate (string name)
        {
            string greeting = "Hola, " + name;
            Console.WriteLine(greeting);
        };
        greet("Mundo");
    }
}

class Animal
{
    public int Id { set; get; }
    public string Color { set; get; }
    public string Descripcion { set; get; } 
}
class Perro : Animal 
{
   public string Nombre { set; get; }
}


