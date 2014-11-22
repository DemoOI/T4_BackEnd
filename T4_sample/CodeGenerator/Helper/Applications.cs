using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeGenerator.Helper
{
    public class Applications
    {
        /// <summary>
        /// 判斷是否過期
        /// </summary>
        /// <returns></returns>
        public static bool IsExpired()
        {
            try
            {
                string key = ConfigurationManager.AppSettings["expiredDay"];
                if (string.IsNullOrEmpty(key)) return true;

                SymmetricMethod gen = new SymmetricMethod();
                string crykey = gen.Decrypto(key);

                return DateTime.Parse(crykey) < DateTime.Now;
            }
            catch (System.Exception)
            {
                return true;
            }

        }

        /// <summary>
        /// 判斷是否過期
        /// </summary>
        /// <returns></returns>
        public static bool IsExpired(string key)
        {

            SymmetricMethod gen = new SymmetricMethod();
            string crykey = gen.Decrypto(key);

            return DateTime.Parse(crykey) < DateTime.Now;
        }

        /// <summary>
        /// 判斷是否為金鑰的型態
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool IsKeyType(string key)
        {
            DateTime temp;
            string crykey;
            SymmetricMethod gen = new SymmetricMethod();
            try
            {
                crykey = gen.Decrypto(key);
            }
            catch (Exception)
            {

                return false;
            }


            return DateTime.TryParse(crykey, out temp);
        }
    }
}
