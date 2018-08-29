using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace fitness_capstone_4.Misc_Class
{
    public class SetCounter
    {
        int count;
        public SetCounter()
        {
            Button btn = new Button();
            btn.Text = "Sets";
            btn.Click += ButtonClicked;
            Label lab = new Label();

            //btn.Top = 20;
            //btn.Left = 20;

            //lab.Top = 50;
            //lab.left = 20;

            //this.Controls.Add(btn);
            //this.Controls.Add(lab);
        }
        
        void ButtonClicked(object sender, EventArgs e)
        {
            count++;
            //lab.Text = count.ToString();
        }
    }
}
