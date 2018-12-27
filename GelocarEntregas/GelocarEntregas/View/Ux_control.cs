using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelocarEntregas
{
    class Ux_control
    {
        new GroupBox order = new GroupBox();
        new GroupBox client = new GroupBox();
        new GroupBox product = new GroupBox();

        
        public Ux_control(GroupBox ORDER,GroupBox CLIENT, GroupBox PRODUCT)
        {
            order = ORDER;
            client = CLIENT;
            product = PRODUCT;

            order.Dock = DockStyle.Fill;
            client.Dock = DockStyle.Fill;
            product.Dock = DockStyle.Fill;
        }


        private void HideAll()
        {
            order.Visible = false;
            client.Visible = false;
            product.Visible = false;
        }

        public void View(int op)
        {
            /*IF op:
             0=order
             1=cliente
             2= product
             visible = true
            */
            HideAll();
            switch (op)
            {
                case(0):
                    order.Visible = true;
                    break;
                case (1):
                    client.Visible = true;
                    break;
                case (2):
                    product.Visible = true;
                    break;
            }


        }

       

    }
}
