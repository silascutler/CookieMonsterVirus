/*
 * Created by Silas Cutler <P1nk> 2016
 * Shouts to ZeroCool, AcidBurn, Lork Nikon, The King of Ninex, Dr Doom, Joey, Razer, Blade, Cereal, Phreak
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookieVirus
{
    public partial class CookieVirus : Form
    {
        public CookieVirus()
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        private void CookieVirus_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;

            monster0.Visible = false;
            cookie0.Visible = false;
            cookie1.Visible = false;
            chomp.Visible = false;

            starttimer.Interval = 1500;
            starttimer.Tick +=new EventHandler(starttimer_Tick);
            starttimer.Start();

            movetimer.Interval = 1;
            movetimer.Tick +=new EventHandler(movetimer_Tick);
            movetimer.Start();

        }

        private int counter = 0;


        private void movetimer_Tick(object sender, System.EventArgs e)
        {
            monster0.Left = monster0.Left + 10;
            if (counter <= 0)
                chomp.Visible = false;
            else
                counter = counter - 1;


            if (monster0.Right >= cookie0.Left)
            {
                // Move Cookie 0 Past Cookie 1
                cookie0.Left = cookie1.Right + 50;
                counter = 10;
            }
            if (monster0.Right >= cookie1.Left)
            {
                // Move Cookie 1 Past Cookie 0
                cookie1.Left = cookie0.Right + 50;
                chomp.Visible = true;
                counter = 10;
            }


            if (monster0.Left >= Bounds.Width)
            {
                monster0.Top = monster0.Top + 100;
                cookie0.Top = cookie0.Top + 100;
                cookie1.Top = cookie1.Top + 100;
                chomp.Top = chomp.Top + 100;

                monster0.Left = 0;
                cookie0.Left = 0 + monster0.Width + 50;
                cookie1.Left = 0 + monster0.Width + cookie0.Width + 50;
            }
            if (monster0.Bottom >= Bounds.Bottom)
            {
                monster0.Top = 0;
                cookie0.Top = 0;
                cookie1.Top = 0;
                chomp.Top = 100;
            }

        }
        private void starttimer_Tick(object sender, System.EventArgs e)
        {
            starttimer.Stop();
            intro0.Visible = false;
            intro1.Visible = false;
            monster0.Visible = true;
            cookie0.Visible = true;
            cookie1.Visible = true;
            chomp.Visible = false;



        }
 
    }
}
