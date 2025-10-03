using System;
using System.Collections.Generic;
using System.Threading;

namespace Proyecto_Final_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Listas generales
            List<Usuario> usuarios = new List<Usuario>();
            List<Artista> artistas = new List<Artista>();
            List<Cancion> canciones = new List<Cancion>();
            List<Playlist> playlists = new List<Playlist>();

            // Crear datos por defecto
            Artista art1 = new Artista("Bad Bunny", "Reggaeton", 50000000, 10, new List<Cancion>(), true, "Benito", "Martinez", new Fecha(10, 3, 1994), "Puerto Rico", "badbunny@mail.com", "1234", true);
            Artista art2 = new Artista("Adele", "Pop", 60000000, 8, new List<Cancion>(), true, "Adele", "Adkins", new Fecha(5, 5, 1988), "Inglaterra", "adele@mail.com", "abcd", true);
            artistas.Add(art1);
            artistas.Add(art2);

            Cancion c1 = new Cancion("Tití Me Preguntó", 3.5, "Reggaeton", "Un Verano Sin Ti", new Fecha(6, 5, 2022), art1);
            Cancion c2 = new Cancion("Ojitos Lindos", 4.2, "Reggaeton", "Un Verano Sin Ti", new Fecha(6, 5, 2022), art1);
            Cancion c3 = new Cancion("Hello", 4.5, "Pop", "25", new Fecha(23, 10, 2015), art2);
            Cancion c4 = new Cancion("Easy On Me", 3.4, "Pop", "30", new Fecha(15, 10, 2021), art2);
            art1.Canciones.Add(c1);
            art1.Canciones.Add(c2);
            art2.Canciones.Add(c3);
            art2.Canciones.Add(c4);
            canciones.Add(c1);
            canciones.Add(c2);
            canciones.Add(c3);
            canciones.Add(c4);

            Usuario usuarioActual = null;
            Artista artistaActual = null;
            ReproductorMusica reproductor = null;
            bool continuar = true; //bandera para detener el bucle

            Console.WriteLine("BIENVENIDO AL REPRODUCTOR MUSICAL");

            while (continuar)
            {
                Console.WriteLine("\nMENÚ PRINCIPAL");
                Console.WriteLine("1. Iniciar sesión como usuario");
                Console.WriteLine("2. Iniciar sesión como artista");
                Console.WriteLine("3. Registrar usuario");
                Console.WriteLine("4. Registrar artista");
                Console.WriteLine("5. Crear playlist");
                Console.WriteLine("6. Agregar canción a playlist");
                Console.WriteLine("7. Crear canción (solo artista)");
                Console.WriteLine("8. Usar reproductor");
                Console.WriteLine("9. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Correo: ");
                    string email = Console.ReadLine();
                    Console.Write("Contraseña: ");
                    string clave = Console.ReadLine();

                    foreach (Usuario u in usuarios)
                    {
                        if (u.Correo == email && u.Contraseña == clave)
                        {
                            usuarioActual = u;
                            Console.WriteLine("Inicio de sesión correcto. Bienvenido " + u.Nombre);
                        }
                    }
                    if (usuarioActual == null)
                    {
                        Console.WriteLine("No se encontró un usuario con esas credenciales.");
                    }
                }

                if (opcion == "2")
                {
                    Console.Write("Correo: ");
                    string email = Console.ReadLine();
                    Console.Write("Contraseña: ");
                    string clave = Console.ReadLine();

                    foreach (Artista a in artistas)
                    {
                        if (a.Correo == email && a.Contraseña == clave)
                        {
                            artistaActual = a;
                            Console.WriteLine("Inicio de sesión como artista: " + a.NombreArtistico);
                        }
                    }
                    if (artistaActual == null)
                    {
                        Console.WriteLine("No se encontró un artista con esas credenciales.");
                    }
                }

                if (opcion == "3")
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Día de nacimiento: ");
                    int d = int.Parse(Console.ReadLine());
                    Console.Write("Mes: ");
                    int m = int.Parse(Console.ReadLine());
                    Console.Write("Año: ");
                    int a = int.Parse(Console.ReadLine());
                    Fecha f = new Fecha(d, m, a);
                    Console.Write("País: ");
                    string pais = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Contraseña: ");
                    string clave = Console.ReadLine();

                    Usuario nuevo = new Usuario(true, nombre, apellido, f, pais, email, clave, true);
                    usuarios.Add(nuevo); //Add se utiliza en listas para añadir un nuevo elemento al final de la lista
                    Console.WriteLine("Usuario registrado correctamente");
                }

                if (opcion == "4")
                {
                    Console.Write("Nombre real: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Día de nacimiento: ");
                    int d = int.Parse(Console.ReadLine());
                    Console.Write("Mes: ");
                    int m = int.Parse(Console.ReadLine());
                    Console.Write("Año: ");
                    int a = int.Parse(Console.ReadLine());
                    Fecha f = new Fecha(d, m, a);
                    Console.Write("País: ");
                    string pais = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Contraseña: ");
                    string clave = Console.ReadLine();
                    Console.Write("Nombre artístico: ");
                    string nombreArt = Console.ReadLine();
                    Console.Write("Género musical: ");
                    string genero = Console.ReadLine();

                    Artista nuevo = new Artista(nombreArt, genero, 0, 0, new List<Cancion>(), true, nombre, apellido, f, pais, email, clave, true);
                    artistas.Add(nuevo);
                    Console.WriteLine("Artista registrado correctamente");
                }

                if (opcion == "5")
                {
                    if (usuarioActual != null)
                    {
                        Console.Write("Nombre de la playlist: ");
                        string nombrePl = Console.ReadLine();
                        Playlist pl = new Playlist(nombrePl, usuarioActual, new List<Cancion>());
                        playlists.Add(pl);
                        Console.WriteLine("Playlist creada con éxito");
                    }
                    else
                    {
                        Console.WriteLine("Debe iniciar sesión como usuario para crear playlists");
                    }
                }

                if (opcion == "6")
                {
                    if (usuarioActual != null && playlists.Count > 0)
                    {
                        Console.WriteLine("Playlists disponibles:");
                        for (int i = 0; i < playlists.Count; i++)
                            Console.WriteLine((i + 1) + ". " + playlists[i].NombrePlaylist);

                        Console.Write("Seleccione una playlist: ");
                        int introdPl = int.Parse(Console.ReadLine()) - 1;

                        Console.WriteLine("Canciones disponibles:");
                        for (int i = 0; i < canciones.Count; i++)
                            Console.WriteLine((i + 1) + ". " + canciones[i].Titulo + " - " + canciones[i].NombreArtista.NombreArtistico);

                        Console.Write("Seleccione una canción: ");
                        int introdC = int.Parse(Console.ReadLine()) - 1;

                        playlists[introdPl].AgregarCancion(canciones[introdC], usuarioActual);
                        Console.WriteLine("Canción agregada correctamente");
                    }
                    else
                    {
                        Console.WriteLine("Debe tener una cuenta de usuario y al menos una playlist");
                    }
                }

                if (opcion == "7")
                {
                    if (artistaActual != null)
                    {
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Duración (min): ");
                        double duracion = double.Parse(Console.ReadLine());
                        Console.Write("Género: ");
                        string gen = Console.ReadLine();
                        Console.Write("Álbum: ");
                        string album = Console.ReadLine();
                        Console.Write("Día lanzamiento: ");
                        int d = int.Parse(Console.ReadLine());
                        Console.Write("Mes: ");
                        int m = int.Parse(Console.ReadLine());
                        Console.Write("Año: ");
                        int a = int.Parse(Console.ReadLine());
                        Fecha f = new Fecha(d, m, a);

                        Cancion nueva = new Cancion(titulo, duracion, gen, album, f, artistaActual);
                        canciones.Add(nueva);
                        artistaActual.Canciones.Add(nueva);
                        Console.WriteLine("Canción creada correctamente");
                    }
                    else
                    {
                        Console.WriteLine("Debe iniciar sesión como artista para crear canciones");
                    }
                }

                if (opcion == "8")
                {
                    if (playlists.Count > 0)
                    {
                        Console.WriteLine("Seleccione una playlist para reproducir:");
                        for (int i = 0; i < playlists.Count; i++)
                            Console.WriteLine((i + 1) + ". " + playlists[i].NombrePlaylist);

                        int introd = int.Parse(Console.ReadLine()) - 1;
                        reproductor = new ReproductorMusica(playlists[introd]);

                        bool enReproductor = true; //Bandera para bucle interno
                        while (enReproductor)
                        {
                            Console.WriteLine("\nREPRODUCTOR");
                            Console.WriteLine("1. Reproducir");
                            Console.WriteLine("2. Pausar");
                            Console.WriteLine("3. Siguiente");
                            Console.WriteLine("4. Anterior");
                            Console.WriteLine("5. Salir");
                            Console.Write("Seleccione una opción: ");
                            string opc = Console.ReadLine();

                            if (opc == "1")
                            {
                                reproductor.reproducirCancion();
                                Cancion actual = reproductor.mostrarcancionActual();
                                Console.WriteLine("Reproduciendo: " + actual.Titulo + " - " + actual.NombreArtista.NombreArtistico);
                                Console.Write("[");

                                for (int i = 0; i < 30; i++)
                                {
                                    Console.Write("-");
                                    Thread.Sleep(100); //Pausa el programa durante 100 milisegundos (0.1 segundos) para que simule la barra de estado de la canción, en cada vuelta del bucle va sumandse una más sin saltar linea por el modo de impresión del cw
                                }

                                Console.WriteLine("]");
                            }
                            if (opc == "2") reproductor.pausarReproduccion();
                            if (opc == "3") reproductor.siguienteCancion();
                            if (opc == "4") reproductor.cancionAnterior();
                            if (opc == "5") enReproductor = false; //Cambio de estado de la bandera para salir del bucle interno
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay playlists disponibles");
                    }
                }

                if (opcion == "9")
                {
                    continuar = false; //Cambio de estado de la bandera para salir del bucle externo y finalizar programa
                    Console.WriteLine("Saliendo del programa..."); 
                }
            }
        }
    }
}
