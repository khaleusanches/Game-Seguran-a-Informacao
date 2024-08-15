using game.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game.Views
{
    public partial class PrincipalView : Form
    {
        public PrincipalView()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void PrincipalView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) 
            {
                pb_main_character.Left += 5;
            }
            else if(e.KeyCode == Keys.Left)
            {
                pb_main_character.Left -= 5;
            }
        }
    }
}
