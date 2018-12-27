using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelocarEntregas
{
    class verify
    {
        private bool amount_characters(string info, int max_amount)
        {
            if (info.Length > max_amount)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool not_null(string info)
        {
            if ((info.Length <= 0)  || (info == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void trade_CommaToHyphen(string info)
        {

            info.Replace(",", "-");
        }

        public void trade_CommaToEnd(string info)
        {

            info.Replace(",", ".");
        }

        private bool NotHaveLatter(string info)
        {
            if(info.Where(c=> char.IsLetter(c)).Count() > 0)
            {
                return false;
            }else
            {
                return true;
            }
        }
        public string Txt(string info, string camp, int max_amount)
        {
            string answer = camp + " ";
            if (!amount_characters(info, max_amount))
            {
                return answer + "não pode conter mais que " + max_amount +" caractere.";
            }
            if (!not_null(info))
            {
                return answer + "não pode estar vazio.";
            }

            return "";
        }
        public string number(string info, string camp)
        {
            string answer = camp + " ";


            if (!NotHaveLatter(info))
            {
                return answer + " não pode conter letras. ";
            }
            if (!not_null(info))
            {
                return answer + "não pode estar vazio.";
            }


            return "";
        }
    }
}
