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
            lb_question.Text = "testqandotestqando 12344testqando 12344testqando 12344testqando 12344testqando 12344testqando 12344testqando 12344testqando 12344 12344";
            pb_central.Image = new Bitmap("C:/Users/khaleu/Desktop/Etec/DS/seguranca/Game-Seguranca-Informacao/Game/imgs/pessoas/reigns.png");
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            pb_central.Image = new Bitmap("C:/Users/khaleu/Desktop/Etec/DS/seguranca/Game-Seguranca-Informacao/Game/imgs/pessoas/2.jpg");
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            pb_central.Image = new Bitmap("C:/Users/khaleu/Desktop/Etec/DS/seguranca/Game-Seguranca-Informacao/Game/imgs/pessoas/3.jpg");
        }
    }
}
