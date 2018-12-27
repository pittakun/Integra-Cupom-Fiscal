using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelocarEntregas
{
    class BLL_client
    {
        DAL_cliente dal_client = new DAL_cliente();
        public int id { get; set; }
        public string phone { get; set; }
        public string address { get; set; }


        public string INSERT()
        {
            return dal_client.INSERT(this);
            
        }

        public List<BLL_client> SELECT()
        {
            return dal_client.SELECT(this);
        }

        public string UPDATE()
        {
            return dal_client.UPDATE(this);
        }

        public string DELETE()
        {
            return dal_client.DELETE(this);
        }

        public List<BLL_client> SELECTALL()
        {
            return dal_client.SELECTALL(this);
        }
    }
}
