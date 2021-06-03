using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TourJapanX.Helper
{
    public class CypherService
    {
        public static String CifrarContenido(String contenido, String salt)
        {
            String contenidosalt = contenido + salt;

            SHA256Managed sha = new SHA256Managed();

            byte[] salida;
            salida = Encoding.UTF8.GetBytes(contenidosalt);
            for (int i = 1; i <= 69; i++)
            {
                salida = sha.ComputeHash(salida);
            }
            sha.Clear();

            String textosalida = Encoding.UTF8.GetString(salida);

            return textosalida;
        }

        public static String GetSalt()
        {
            Random random = new Random();
            String salt = "";
            for (int i = 1; i <= 50; i++)
            {
                int aleat = random.Next(0, 255);
                char letra = Convert.ToChar(aleat);
                salt += letra;
            }

            return salt;
        }

        public static bool DescifrarContenido(String password, String salt, String userPassword)
        {
            String contenidosalt = password + salt;

            SHA256Managed sha = new SHA256Managed();

            byte[] salida;
            salida = Encoding.UTF8.GetBytes(contenidosalt);
            for (int i = 1; i <= 69; i++)
            {
                salida = sha.ComputeHash(salida);
            }
            sha.Clear();

            String textosalida = Encoding.UTF8.GetString(salida);

            if (textosalida.Equals(userPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
