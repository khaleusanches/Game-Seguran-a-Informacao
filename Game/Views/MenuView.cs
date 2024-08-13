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
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            Visible = false;
            new PrincipalView().Show();
        }
    }
}
