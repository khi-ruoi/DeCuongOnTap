using System;
using System.Security.Cryptography;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;

namespace DeCuongOnTap.Classes
{
    public class AutoGenData
    {

        public string GenData(GridView gv,string s)
        {
            string vl = gv.GetRowCellValue(gv.FocusedRowHandle, s).ToString();

            return vl;
        }
        // Chuẩn hóa xâu
        public string ChuanHoa(string s)
        {
            string Result = "";
            try
            {
                s = s.Trim().ToLower();
                while (s.IndexOf("  ") != -1)
                {
                    s = s.Replace("  ", " ");
                }
                string[] SubName = s.Split(' ');

                for (int i = 0; i < SubName.Length; i++)
                {
                    string FirstChar = SubName[i].Substring(0, 1);
                    string OtherChar = SubName[i].Substring(1);
                    SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                    Result += SubName[i] + " ";
                }
            }
            catch (Exception)
            { }
            return Result.Trim();
        }

        public string EnCode(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(Encoding.UTF8.GetBytes("x2"));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }
        public string Decode(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(Encoding.UTF8.GetBytes("x2"));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
    }
}
