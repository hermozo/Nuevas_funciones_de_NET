namespace net7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*******FUNCIONES GENERICAS*********/
            new FuncionesGenericas();

            /******* Struct *******/
            PersonaStruct personaStruct = new PersonaStruct();
            Console.WriteLine(personaStruct.Id);

            /******Mutiples cadenas ******/
            new MutiplesCadenas();

            /****Requeridos en una clase Data*****/
            new RequeridosEnClase("Miguel", "Angel");
        }
    }
}
