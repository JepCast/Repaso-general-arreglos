
void matriz ()
{
    string[] nombre = new string[]
    {
        "Anderson", "Brandon", "Yeimi", "Fatima", "Vivian"
    };
    
    
   foreach(string n in nombre)
   {
    Console.WriteLine("nombre=" + n);
   }

    int[] notas = new int[]
    {
        50,90,85,73,95
    };

    //int promedio = 0;
    //foreach (int n in notas)
    //{ 
    //    promedio= promedio + n;
    //};

    //promedio = promedio / notas.Length;
    //Console.WriteLine("\nEl promedio de las notas es:" + promedio);

   
    int mayor = 0;
    for (int i = 0; i < 5; i++)
    {
        if (notas > mayor)
        {
            mayor = notas;
        }
    }
    Console.WriteLine("El numero mayor es: " + mayor);
}
matriz();