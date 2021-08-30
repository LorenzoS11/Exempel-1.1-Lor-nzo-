using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel_1._1__Lorénzo_
{

    /* Gjord av Lorenzo Somi 2021-08-30 */
    public partial class frmExempel1_1 : Form
    {
        private object tbxTal2;
        private object tbxTal1;

        public frmExempel1_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Omvandla till int
            int tal1 = tbxTal1.Text;


            //Addera
            int summa = tal1 + tbxTal2.Text;


            //Omvandla summa till sträng och visa svaret
            textBox1.Text = summa.ToString();
        }

        private int ParseToInt(string text)
        {
            int tal = 0;

            //Börja med värdet av entalet
            int postionsvärde = 1;

            //"Parsa" Texten och beräkna tal  //LS fixat negativa tal ö1.1a
            for (int i = text.Length-1; i >= 0; i--)
            {
                int teckenvärde = text[i] - 48;
                tal += teckenvärde * postionsvärde;
                postionsvärde *= 10;
            }
            return tal;
        }

    }