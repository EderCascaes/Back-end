using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo.Functions
{
    public class Funcoes
    {
        public Funcoes()
        {

        }

        public string TO_DATE(DateTime? value)
        {
            var data = value.Value.ToString("yyyy/MM/dd");

            if (!String.IsNullOrEmpty(data))
                return data;

            return " NULL ";
        }




        public string GetMD5Hash(string input)
        {
            try
            {
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();

            }
            catch (Exception)
            {
                throw;
            }

        }



        public string ValidaCPF(string cpf)
        {
            try
            {
                long soma = 0, t1, t2, t3, t4, t5, t6;
                var _CPF = cpf.Replace("-", "").Replace(".", "").Replace("/", "");

                if (!string.IsNullOrEmpty(_CPF))
                {
                    var array = _CPF.ToCharArray();
                    int[] arrayInt = new int[11];

                    for (int i = 0; i < _CPF.Length; i++)
                    {
                        soma += arrayInt[i] = Convert.ToInt32(array[i] - 48);
                    }
                    t1 = (soma / 10);
                    t2 = (soma - (t1 * 10));
                    t3 = ((arrayInt[0] * 10) + (arrayInt[1] * 9) + (arrayInt[2] * 8) + (arrayInt[3] * 7) + (arrayInt[4] * 6) + (arrayInt[5] * 5) + (arrayInt[6] * 4) + (arrayInt[7] * 3) + (arrayInt[8] * 2));
                    t4 = t3 % 11;
                    if (t4 < 2)
                    {
                        t4 = 0;
                    }
                    t5 = 11 - t4;
                    t3 = ((arrayInt[0] * 11) + (arrayInt[1] * 10) + (arrayInt[2] * 9) + (arrayInt[3] * 8) + (arrayInt[4] * 7) + (arrayInt[5] * 6) + (arrayInt[6] * 5) + (arrayInt[7] * 4) + (arrayInt[8] * 3) + (t5 * 2));
                    t4 = t3 % 11;

                    if (t4 < 2)
                    {
                        t4 = 0;
                    }

                    t6 = 11 - t4;

                    if (arrayInt[9] == t5 || arrayInt[10] == t6 || t1 == t2)
                    {
                        return _CPF;
                    }

                }

                return null;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }               

    }
}
