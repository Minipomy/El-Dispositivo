using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using El_Dispositivo;

namespace Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppJuegos juego1 = new AppJuegos("Super Mario Bros", SistemaOperativo.ANDROID, 20); // Lo debe agregar
            AppJuegos juego2 = new AppJuegos("Super Mario Bros", SistemaOperativo.ANDROID, 20); // No lo debe agregar, está repetido
            AppJuegos juego3 = new AppJuegos("Angry Birds", SistemaOperativo.ANDROID, 100); // Lo debe agregar
            AppJuegos juego4 = new AppJuegos("League of Legends", SistemaOperativo.IOS, 500); // No lo debe agregar, sistema operativo distinto
            AppMusical musica1 = new AppMusical("Spotify", SistemaOperativo.ANDROID, 50, // Lo agrega con las canciones. 
                new List<string>()
                {
                "Bohemian Rhapsody - Queen",
                "Billie Jean – Michael Jackson",
                "Another Brick In The Wall – Pink Floyd",
                "Romeo And Juliet – Dire Straits",
                "Where The Streets Have No Name -U2",
                "Let It Be – The Beatles",
                "Could You Be Loved – Bob Marley",
                "Every Breath You Take – The Police",
                "November Rain – Guns n Roses",
                "Crazy Train – Ozzy Osbourne",
                "Volver – Carlos Gardel",
                "En La Ciudad De La Furia – Soda Stereo",
                "Gualicho – Patricio Rey",
                "Paint It Black – Rolling Stones"
                });
            AppMusical musica2 = new AppMusical("Spotify", SistemaOperativo.ANDROID, 50); // No lo debe agregar, repetido.
            AppMusical musica3 = new AppMusical("YouTube Music", SistemaOperativo.ANDROID, 30); // Lo debe agregar.
            List<Aplicacion> listaApps = new List<Aplicacion>(){juego1 , juego2 , juego3 , juego4 , musica1 , musica2 , musica3};
            Dispositivo.InstalarApp(juego2);
            Dispositivo.InstalarApp(juego3);
            Dispositivo.InstalarApp(juego4);
            Dispositivo.InstalarApp(musica1);
            Dispositivo.InstalarApp(musica2);
            Dispositivo.InstalarApp(musica3);
            Console.WriteLine(Dispositivo.ObtenerInformacionDispositivo());
            Console.WriteLine(musica1.ObtenerInformacionApp());
            Console.WriteLine(juego4.ObtenerInformacionApp());
            Console.ReadLine();
        }
    }
}
