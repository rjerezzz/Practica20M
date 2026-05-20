/*Crear una aplicacion que guarde los registro de notas de 25 estudiantes.

debe  presentar un menu:

1. Agregar
2. mostrar
3. mostrar los 3 primeros lugares
4. mostrar las notas en orden descendente
5. salir
*/

int[] notas = new int[25];

/*Agregar*/

for (int i = 0; i < notas.Length; i++)
{
    bool valido = false;
    do {
        Console.Write($"Ingrese la nota del estudiante {i + 1} (0-100): ");
        if (int.TryParse(Console.ReadLine(), out notas[i]))
        {
            valido = true;
        }

    }while(!valido);



}

/*Mostrar*/

/*Mostrar los 3 primeros lugares*/

/*Mostrar las notas en orden descendente*/