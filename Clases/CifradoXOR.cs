using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Clases
{
    public class CifradoXOR
    {
        private static string clave = "IlKaPoInt2026"; //PASS

        public static string Cifrar(string text)
        {
            StringBuilder resultado = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                //Aplicamos XOR entre cada caracter del text y la clave
                char crifrado = (char)(text[i] ^ clave[i % clave.Length]);
                resultado.Append(crifrado);
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(resultado.ToString()));
        }

        public static string Decifrar(string textCifrado)
        {
            string text = Encoding.UTF8.GetString(Convert.FromBase64String(textCifrado));
            StringBuilder resultado = new StringBuilder();
            for (int i = 0;i < text.Length; i++)
            {
                char descifrado = (char)(text[i] ^ clave[i % clave.Length]);
                resultado.Append(descifrado);
            }
            return resultado.ToString();
        }
    }
}
