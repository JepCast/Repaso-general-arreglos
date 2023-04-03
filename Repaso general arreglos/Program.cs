
void matriz ()
{

    string usn;
    ushort cn;

    Console.WriteLine("Hola, bienveni@, por favor dime cual es tu nombre:");
        usn = Console.ReadLine();

    do
    {
        Console.WriteLine($"\nHola {usn}, por favor dime la cantidad de nombres que deseas introducir:");
            cn = UInt16.Parse(Console.ReadLine());
        Console.WriteLine("\nAhora inserta a continuación los nombres:");
    } while (cn <= 0);


    string[] name = new string[cn];
    
    for (int i = 0; i < cn; i++)
    {
        Console.WriteLine("\nIngrese el nombre: ");
        name[i] = Console.ReadLine();
    }
    
    Console.WriteLine("\nLos nombres que has insertados son:");

    foreach (string n in name)
    {
        Console.WriteLine(n);
    }

    Console.WriteLine($"\nAhora por favor inserta las notas:");
    
    int[] notas = new int[cn];

    for (int i = 0; i < cn; i++)
    {
        Console.WriteLine("Ingresa la nota de " + name[i]);
        notas[i] = Convert.ToInt32(Console.ReadLine());
    }

    int mayor = 0;
    for (int i = 1; i < notas.Length; i++)
    {
        if (notas[i] > notas[mayor])
        {
            mayor = i;
        }
    }
    Console.WriteLine($"\n{usn} la nota más alta es: " + notas[mayor]);

    int menor = 0;
    for (int i = 100; i < notas.Length; i++)
    {
        if (i < notas[menor])
        {
            menor = i;
        }
    }
    Console.WriteLine($"Y la nota más baja es: " + notas[menor]);
    Console.ReadKey();
}
matriz();