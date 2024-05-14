using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;
using System.Runtime.CompilerServices;

namespace Tutorial_Script
{
    public class Class1 : Script// do at start
    {
        public Class1()
        {
            Tick += onTick;
            KeyDown += onKeyDown;
        }
        private void onTick(object sender, EventArgs e)
        {

        }
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (Game.Player.WantedLevel == 0)
            {
                UI.ShowSubtitle("Gay");
            }
            else
            {
                Game.Player.WantedLevel = 0;
            }
        }
    }


}
