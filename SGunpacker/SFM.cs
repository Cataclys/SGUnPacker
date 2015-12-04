using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

class SFM
{
    public static string BytesToString(byte[] b, string lang)
    {
        int num = 0;
        string str = "";
        for (int i = 0; i < (int)b.Length && b[i] > 0; i++)
        {
            num++;
        }
        byte[] numArray = new byte[num];
        for (int i = 0; i < num && b[i] > 0; i++)
        {
            numArray[i] = b[i];
        }
        if (lang == "Chinese")
            str = Encoding.GetEncoding("gb2312").GetString(numArray);
        else if (lang == "Korean")
            str = Encoding.GetEncoding("ks_c_5601-1987").GetString(numArray);
        else if (lang == "French" || lang == "German" || lang == "Italian" || lang == "Spanish" || lang == "Portuguese")
            str = Encoding.GetEncoding("Windows-1252").GetString(numArray);
        else if (lang == "English")
            str = Encoding.GetEncoding("ASCII").GetString(numArray);
        else if (lang == "Polish")
            str = Encoding.GetEncoding("Windows-1250").GetString(numArray);
        else if (lang == "Russian")
            str = Encoding.GetEncoding("Windows-1251").GetString(numArray);
        else if (lang == "Japanese")
            str = Encoding.GetEncoding("Shift-JIS").GetString(numArray);
        else if (lang == "Turkish")
            str = Encoding.GetEncoding("Windows-1254").GetString(numArray);

        return str;
    }

    public static string BytesToString(byte[] b)
    {
        int num = 0;
        for (int i = 0; i < (int)b.Length && b[i] > 0; i++)
        {
            num++;
        }
        byte[] numArray = new byte[num];
        for (int i = 0; i < num && b[i] > 0; i++)
        {
            numArray[i] = b[i];
        }

        return Encoding.ASCII.GetString(numArray);
    }

    public static Byte[] StringToBytes(string str, string lang)
    {
        Byte[] bytes = null;
        if (lang == "Chinese")
            bytes = Encoding.GetEncoding("CP936").GetBytes(str);
        else if (lang == "Korean")
            bytes = Encoding.GetEncoding("ks_c_5601-1987").GetBytes(str);
        else if (lang == "French" || lang == "German" || lang == "Italian" || lang == "Spanish" || lang == "Portuguese")
            bytes = Encoding.GetEncoding("Windows-1252").GetBytes(str);
        else if (lang == "English")
            bytes = Encoding.GetEncoding("ASCII").GetBytes(str);
        else if (lang == "Polish")
            bytes = Encoding.GetEncoding("Windows-1250").GetBytes(str);
        else if (lang == "Russian")
            bytes = Encoding.GetEncoding("Windows-1251").GetBytes(str);
        else if (lang == "Japanese")
            bytes = Encoding.GetEncoding("Shift-JIS").GetBytes(str);
        else if (lang == "Turkish")
            bytes = Encoding.GetEncoding("Windows-1254").GetBytes(str);

        return bytes;
    }

    public static Byte[] StringToBytes(string str)
    {
        return Encoding.ASCII.GetBytes(str);
    }

    public static Byte[] GetFileHeader()
    {
        Byte[] result = new Byte[128];
        Byte[] bTmp = Encoding.ASCII.GetBytes(string.Format("{0}{1}{2}", DateTime.Now.Year, GetDate(DateTime.Now.Month), GetDate(DateTime.Now.Day)));
        for (int iCount = 0; iCount < bTmp.Length; iCount++)
        {
            result[iCount] = bTmp[iCount];
        }
        return result;
    }

    static String GetDate(Int32 pInt)
    {
        if (pInt >= 10)
            return pInt.ToString();
        else
            return string.Format("0{0}", pInt);
    }

    public static string GetMd5Hash(string input)
    {
        byte[] keyArray;
        byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(input);

        System.Configuration.AppSettingsReader settingsReader =
                                            new System.Configuration.AppSettingsReader();

        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes("2150"));

        hashmd5.Clear();

        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

        tdes.Key = keyArray;

        tdes.Mode = CipherMode.ECB;

        tdes.Padding = PaddingMode.PKCS7;

        ICryptoTransform cTransform = tdes.CreateEncryptor();

        byte[] resultArray =
          cTransform.TransformFinalBlock(toEncryptArray, 0,
          toEncryptArray.Length);

        tdes.Clear();

        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    }

    public static string GetDecryptMD5(string input)
    {
        byte[] keyArray;

        byte[] toEncryptArray = Convert.FromBase64String(input);

        System.Configuration.AppSettingsReader settingsReader =
                                            new System.Configuration.AppSettingsReader();

        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes("2150"));

        hashmd5.Clear();

        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

        tdes.Key = keyArray;

        tdes.Mode = CipherMode.ECB;

        tdes.Padding = PaddingMode.PKCS7;

        ICryptoTransform cTransform = tdes.CreateDecryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(
                             toEncryptArray, 0, toEncryptArray.Length);

        tdes.Clear();

        return UTF8Encoding.UTF8.GetString(resultArray);
    }

    public static void swapchars(ref Byte[] pHash)
    {
        if (pHash.Length > 4)
        {
            double strlength;

            strlength = (float)pHash.Length;
            double off = strlength * 0.6600000262260437;
            Byte pb = (Byte)off;
            Byte t = pHash[pb];
            pHash[pb] = pHash[0];
            pHash[0] = t;

            off = strlength * 0.3300000131130219;
            pb = (Byte)off;
            t = pHash[pb];
            pHash[pb] = pHash[1];
            pHash[1] = t;
        }
    }

    public static Byte get_add_char(Byte[] pHash, Byte[] Key)
    {
        UInt32 var1;
        UInt32 var2;

        var1 = 0;
        var2 = 0;

        Byte strlength = Convert.ToByte(pHash.Length);
        if (strlength != 0)
        {
            while (var2 < strlength)
            {
                var1 += (Byte)pHash[var2]; var2++;
            }
        }

        Byte index = Convert.ToByte(var1 % 84);
        return Key[index];
    }

    public static Byte getXorIndex(Byte val, Byte[] Key)
    {
        for (int i = 0; i < Key.Length; ++i)
        {
            if (Key[i] == val)
                return (Byte)i;
        }
        return 0xff;
    }
}