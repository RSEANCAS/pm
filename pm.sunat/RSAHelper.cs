using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pm.sunat
{
    public class RSAHelper
    {
        public static X509Certificate2 GetX509Certificate(string certPath, string password)
        {
            X509Certificate2 certificado = new X509Certificate2();
            certificado.Import(ReadFile(certPath), password, X509KeyStorageFlags.Exportable);

            return certificado;
        }

        internal static byte[] ReadFile(string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int size = (int)f.Length;
            byte[] data = new byte[size];
            size = f.Read(data, 0, size);
            f.Close();
            return data;
        }
    }
}
