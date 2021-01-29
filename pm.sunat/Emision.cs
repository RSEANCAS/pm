using System;
using Ionic.Zip;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace pm.sunat
{
    public static class Emision
    {
        static public Boolean ComprimirDocumentoZip(string Ruta, string Nombre)
        {
            try
            {
                using (ZipFile zip = new ZipFile())
                {
                    zip.AddFile(Ruta, "");

                    zip.Save(Nombre);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static bool DescromprimirZip(string ArchivoZip, string RutaGuardar)
        {

            try
            {
                using (ZipFile zip = ZipFile.Read(ArchivoZip))
                {
                    string topPath = @"D:\FACTURA ELECTRONICA\DESCOMPRIMIR";

                    Directory.Delete(topPath, true);

                    zip.ExtractAll(RutaGuardar);
                    zip.Dispose();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public static string FirmarDocumentoXML(string pathXmlDocument, string RutaCertificadoDigital, string PasswordCertificado)
        {
            XmlDocument documentXml = new XmlDocument();

            documentXml.PreserveWhitespace = true;
            documentXml.Load(pathXmlDocument);
            var nodoExtension = documentXml.GetElementsByTagName("ExtensionContent", EspacioNombres.CommonExtensionComponents).Item(0);

            if (nodoExtension == null)
            {
                throw new InvalidOperationException("No se pudo encontrar el nodo ExtensionContent en el XML");
            }

            nodoExtension.RemoveAll();

            SignedXml firmado = new SignedXml(documentXml);

            var xmlSignature = firmado.Signature;

            var cert = RSAHelper.GetX509Certificate(RutaCertificadoDigital, PasswordCertificado);
            firmado.SigningKey = (RSA)cert.PrivateKey;

            //digest info agregada en la seccion firma
            var env = new XmlDsigEnvelopedSignatureTransform();
            Reference reference = new Reference();
            reference.AddTransform(env);

            reference.Uri = "";
            firmado.AddReference(reference);
            firmado.SignedInfo.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

            reference.DigestMethod = "http://www.w3.org/2000/09/xmldsig#sha1";


            // info para la llave publica 
            KeyInfo keyInfo = new KeyInfo();
            keyInfo.AddClause(new KeyInfoX509Data(cert));

            xmlSignature.KeyInfo = keyInfo;
            xmlSignature.Id = "SignatureErickOrlando";
            firmado.ComputeSignature();


            // Recuperamos el valor Hash de la firma para este documento.
            if (reference.DigestValue != null)
            {
                ModuloDoc moduloFactura = new ModuloDoc();
                moduloFactura.DigestValue = Convert.ToBase64String(reference.DigestValue);
            }

            nodoExtension.AppendChild(firmado.GetXml());

            var settings = new XmlWriterSettings() { Encoding = Encoding.GetEncoding("ISO-8859-1") };
            string resultado = String.Empty;
            using (var memDoc = new MemoryStream())
            {

                using (var writer = XmlWriter.Create(memDoc, settings))
                {
                    documentXml.WriteTo(writer);
                }

                resultado = Convert.ToBase64String(memDoc.ToArray());

            }
            return resultado;
        }

        private static bool VerificarFirma(string pathXmlSigned, string pathCert, string passCert)
        {
            var cert = RSAHelper.GetX509Certificate(pathCert, passCert);
            var key = (RSA)cert.PrivateKey;
            XmlDocument xmlDoc = new XmlDocument();
            SignedXml signedXml = new SignedXml(xmlDoc);
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("Signature");
            signedXml.LoadXml((XmlElement)nodeList[0]);
            return signedXml.CheckSignature(key);
        }


        public static bool ExisteConexaoInternet()
        {
            WebClient client = new WebClient();
            try
            {
                using (client.OpenRead("http://www.google.com"))
                {
                }
                return true;
            }
            catch (WebException)
            {
                return false;


            }
        }



        // ----------------------------------------------------------- //

    }
}
