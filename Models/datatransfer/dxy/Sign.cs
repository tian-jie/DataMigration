using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Innocellence.DXYDataTransfer.Models
{
    public static class EncryptionHelper
    {
        //public static string Encryption(string val)
        //{
        //    var StrRes = Encoding.UTF8.GetBytes(val);
        //    using (var iSHA = new SHA1CryptoServiceProvider())
        //    {
        //        StrRes = iSHA.ComputeHash(StrRes);

        //        //var t = Encoding.UTF8.GetString(StrRes);
        //        var str = BitConverter.ToString(StrRes).Replace("-", string.Empty);

        //        var lower = str.ToLower();

        //        //TODO: converter to hex string
        //        return lower;
        //    }
        //}

        //public static string Encryption(string val, string key)
        //{
        //    var keyArray = Encoding.UTF8.GetBytes(key);
        //    var toEncryptArray = Encoding.UTF8.GetBytes(val);

        //    using (var rDel = new RijndaelManaged { Key = keyArray, Mode = CipherMode.ECB, BlockSize = 128 })
        //    {
        //        var cTransform = rDel.CreateEncryptor();
        //        var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        //        var aesBase64 = Convert.ToBase64String(resultArray, 0, resultArray.Length);

        //        using (var md5 = new MD5CryptoServiceProvider())
        //        {
        //            var md5Bty = md5.ComputeHash(Encoding.UTF8.GetBytes(aesBase64));

        //            var md5String = Convert.ToBase64String(md5Bty, 0, md5Bty.Length);

        //            var md5AfterReplace = HttpUtility.UrlEncode(Replace(md5String));
        //            return md5AfterReplace;

        //        }
        //    }
        //}
        //public static string Replace(string base64String)
        //{
        //    return base64String.Replace('+', '-').Replace('/', '_').Replace("=", string.Empty);
        //}
    }
}