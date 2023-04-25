using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;


namespace Seguridad
{
    public class Cifrado
    {
        // Global
        public string RutaClaves = Seguridad.Properties.Resources.RutaClavesPubPriv;



        // Contructor de Clase
        public Cifrado()
        {
            if (!File.Exists(RutaClaves))
                Crear_ClavesPubPriv();
        }


        public string Cifrar(string Datos)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string ClavesXml = Leer_ClavesPubPriv();

            rsa.FromXmlString(ClavesXml);
            byte[] TextoPlanoBytes = System.Text.Encoding.Default.GetBytes(Datos);
            byte[] TextoCifradoBytes = rsa.Encrypt(TextoPlanoBytes, false);

            string TextoCifradoString = Convert.ToBase64String(TextoCifradoBytes);

            return TextoCifradoString;
        }

        public string DeCifrar(string Datos)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string ClavesXml = Leer_ClavesPubPriv();

            rsa.FromXmlString(ClavesXml);
            byte[] TextoCifradoBytes = Convert.FromBase64String(Datos);
            byte[] TextoPlanoBytes = rsa.Decrypt(TextoCifradoBytes, false);

            string MensajeCifrado = System.Text.Encoding.UTF8.GetString(TextoPlanoBytes);

            return MensajeCifrado;
        }

        private void Crear_ClavesPubPriv()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            using (StreamWriter Escribir = new StreamWriter(RutaClaves))
            {
                string ClavesXML = RSA.ToXmlString(true);
                Escribir.Write(ClavesXML);
                Escribir.Close();
            }
        }

        private string Leer_ClavesPubPriv()
        {
            string Claves;

            using (StreamReader sr = new StreamReader(RutaClaves, System.Text.Encoding.UTF8))
            {
                Claves = sr.ReadToEnd();
                sr.Close();
            }

            return Claves;
        }

        #region [ METODOS PUBLICOS ]

        //#region [ -- ALGORITMOS DE CIFRADO -- ]

        ///// <summary>
        ///// Cifra la Contraseña utilizando SHA512, con Salt especificado e iteraciones
        ///// </summary>
        //public string CifrarContraseña(string contraseña, string salt)
        //{
        //    const int LongBytesAlgoritmoHash = 64; // SHA512 (512 bits / 8 = 64 bytes).
        //    const int Iteraciones = 1000; // Iteraciones de cifrado
        //    string ContraseñaCifrada = string.Empty;

        //    try
        //    {
        //        byte[] SaltBytes = Convert.FromBase64String(salt);

        //        // Cifrar CONTRASEÑA - Calcula Hash con SALT e iteraciones
        //        PasswordDeriveBytes pdb = new PasswordDeriveBytes(contraseña, SaltBytes, "SHA512", Iteraciones);

        //        ContraseñaCifrada = Convert.ToBase64String(pdb.GetBytes(LongBytesAlgoritmoHash));
        //    }

        //    catch
        //    {
        //    }

        //    // Retorna CONTRASEÑA
        //    return ContraseñaCifrada;
        //}

        ///// <summary>
        ///// Cifra la Contraseña utilizando SHA512, con Salt especificado e iteraciones
        ///// </summary>
        //public string CifrarContraseña(string contraseña, string salt, int iteraciones)
        //{
        //    const int LongBytesAlgoritmoHash = 64; // SHA512 (512 bits / 8 = 64 bytes).

        //    byte[] SaltBytes = Convert.FromBase64String(salt);

        //    if (iteraciones < 1) iteraciones = 1000;

        //    // Cifrar CONTRASEÑA - Calcula Hash con SALT e iteraciones
        //    PasswordDeriveBytes pdb = new PasswordDeriveBytes(contraseña, SaltBytes, "SHA512", iteraciones);

        //    string ContraseñaCifrada = Convert.ToBase64String(pdb.GetBytes(LongBytesAlgoritmoHash));

        //    // Retorna CONTRASEÑA
        //    return ContraseñaCifrada;
        //}

        ///// <summary>
        ///// Obtiene un SALT
        ///// </summary>

        //public string ObtenerSalt(int Longitud)
        //{
        //    // Crear un buffer
        //    byte[] rndSaltBytes;

        //    if (Longitud >= 1)
        //        rndSaltBytes = new byte[Longitud];
        //    else
        //        rndSaltBytes = new byte[16];

        //    // Crear un RNGCryptoServiceProvider.
        //    RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();

        //    // Llenar el buffer con bytes aleatorios.
        //    rand.GetBytes(rndSaltBytes);

        //    // Retornar bytes.
        //    return Convert.ToBase64String(rndSaltBytes);
        //}


        //#endregion


        #region [ -- ALGORITMOS HASH --]


        /// <summary>
        /// Algoritmos permitidos
        /// </summary>
        public enum AlgoritmoHash
        {
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512
        }

        public static string CalcularHash(string texto, AlgoritmoHash algoritmoHash)
        {
            // Codifico los caracteres de la frase
            byte[] strBytes = new UnicodeEncoding().GetBytes(texto);

            strBytes = ProveedorHash(algoritmoHash).ComputeHash(strBytes);

            // Retorno el Hash
            return Convert.ToBase64String(strBytes);
        }


        #endregion


        #endregion


        #region [ METODOS PRIVADOS ]

        private static HashAlgorithm ProveedorHash(AlgoritmoHash eAlgoritmoDeHash)
        {
            switch (eAlgoritmoDeHash)
            {
                case AlgoritmoHash.MD5:
                    return new MD5CryptoServiceProvider();
                case AlgoritmoHash.SHA1:
                    return new SHA1Managed();
                case AlgoritmoHash.SHA256:
                    return new SHA256Managed();
                case AlgoritmoHash.SHA384:
                    return new SHA384Managed();
                case AlgoritmoHash.SHA512:
                    return new SHA512Managed();
                default: // sino se ha encontrado un valor correspondiente en la
                    // enumeración, generamos un excepción para indicarlo.
                    throw new Exception("Proveedor Inexistente.");
            }
        }

        #endregion

    }
}
