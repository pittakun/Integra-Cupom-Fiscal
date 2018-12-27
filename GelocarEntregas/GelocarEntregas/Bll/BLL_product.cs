using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelocarEntregas
{
    class BLL_product
    {
        DAL_product dal_product = new DAL_product();
        public int id { get; set; }
        public string name { get; set; }
        public string value { get; set; }



        public string INSERT()
        {
            return dal_product.INSERT(this);

        }
        public List<BLL_product> SELECT()
        {
            return dal_product.SELECT(this);
        }

        public string UPDATE()
        {
            return dal_product.UPDATE(this);
           
        }

        public string DELETE()
        {
            return dal_product.DELETE(this);
        }

        public List<BLL_product> SELECTALL()
        {
            return dal_product.SELECTALL();
        }
    }
}
