using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToParent();
            panelBoja.BackColor = Color.FromArgb(0,0,0);
        }

        
         int crvena=0;
         int zelena=0;
         int plava=0;
         Color boja;


         private static String HexConverter(System.Drawing.Color c)
         {
             String rtn = String.Empty;
             try
             {
                 rtn = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK,MessageBoxIcon.Error);
             }

             return rtn;
         }

         public void PromeniBoju()
         {
             boja = Color.FromArgb(crvena, zelena, plava);
             panelBoja.BackColor = boja;
             string hex = HexConverter(boja);
             textBoxHex.Text = hex;
         }

         private void trackBarCrvena_Scroll(object sender, EventArgs e)
         {
             crvena = trackBarCrvena.Value;
             numericUpDownCrvena.Text = crvena.ToString();
             PromeniBoju();
         }

         

         private void numericUpDownCrvena_ValueChanged(object sender, EventArgs e)
         {
             crvena =(int) numericUpDownCrvena.Value;
             trackBarCrvena.Value = crvena;
             PromeniBoju();
         }

         private void trackBarZelena_Scroll(object sender, EventArgs e)
         {
             zelena = trackBarZelena.Value;
             numericUpDownZelena.Text = zelena.ToString();
             PromeniBoju();
         }

         private void trackBarPlava_Scroll(object sender, EventArgs e)
         {
             plava = trackBarPlava.Value;
             numericUpDownPlava.Text = plava.ToString();
             PromeniBoju();
         }

         private void numericUpDownZelena_ValueChanged(object sender, EventArgs e)
         {
             zelena = (int)numericUpDownZelena.Value;
             trackBarZelena.Value = zelena;
             PromeniBoju();
         }

         private void numericUpDownPlava_ValueChanged(object sender, EventArgs e)
         {
             plava = (int)numericUpDownPlava.Value;
             trackBarPlava.Value = plava;
             PromeniBoju();
         }
    }
}
