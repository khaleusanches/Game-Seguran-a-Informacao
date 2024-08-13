namespace game.Views
{
    partial class PrincipalView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalView));
            pb_central = new PictureBox();
            btn_left = new Button();
            btn_right = new Button();
            lb_question = new Label();
            panel1 = new Panel();
            pn_teste = new Panel();
            panel2 = new Panel();
            pb_background = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_central).BeginInit();
            pn_teste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_background).BeginInit();
            SuspendLayout();
            // 
            // pb_central
            // 
            pb_central.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_central.BackColor = Color.White;
            pb_central.Location = new Point(71, 274);
            pb_central.Name = "pb_central";
            pb_central.Size = new Size(25, 264);
            pb_central.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_central.TabIndex = 1;
            pb_central.TabStop = false;
            // 
            // btn_left
            // 
            btn_left.Location = new Point(161, 256);
            btn_left.Name = "btn_left";
            btn_left.Size = new Size(75, 23);
            btn_left.TabIndex = 3;
            btn_left.Text = "button1";
            btn_left.UseVisualStyleBackColor = true;
            btn_left.Click += btn_left_Click;
            // 
            // btn_right
            // 
            btn_right.Location = new Point(941, 335);
            btn_right.Name = "btn_right";
            btn_right.Size = new Size(75, 23);
            btn_right.TabIndex = 4;
            btn_right.Text = "button2";
            btn_right.UseVisualStyleBackColor = true;
            btn_right.Click += btn_right_Click;
            // 
            // lb_question
            // 
            lb_question.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_question.BackColor = Color.Transparent;
            lb_question.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_question.ForeColor = Color.SeaGreen;
            lb_question.Location = new Point(6, 116);
            lb_question.Name = "lb_question";
            lb_question.Size = new Size(160, 102);
            lb_question.TabIndex = 5;
            lb_question.Text = "testetestestetestetestee";
            lb_question.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkGreen;
            panel1.Location = new Point(603, 686);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 121);
            panel1.TabIndex = 7;
            // 
            // pn_teste
            // 
            pn_teste.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pn_teste.BackColor = Color.DarkSeaGreen;
            pn_teste.Controls.Add(pb_central);
            pn_teste.Controls.Add(lb_question);
            pn_teste.Cursor = Cursors.No;
            pn_teste.Location = new Point(603, 61);
            pn_teste.Name = "pn_teste";
            pn_teste.Size = new Size(166, 695);
            pn_teste.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.DarkGreen;
            panel2.Location = new Point(603, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(166, 133);
            panel2.TabIndex = 8;
            // 
            // pb_background
            // 
            pb_background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_background.Image = (Image)resources.GetObject("pb_background.Image");
            pb_background.Location = new Point(-12, -3);
            pb_background.Name = "pb_background";
            pb_background.Size = new Size(1440, 881);
            pb_background.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_background.TabIndex = 0;
            pb_background.TabStop = false;
            // 
            // PrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 805);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_right);
            Controls.Add(btn_left);
            Controls.Add(pn_teste);
            Controls.Add(pb_background);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PrincipalView";
            Text = "PrincipalView";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pb_central).EndInit();
            pn_teste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_background).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pb_central;
        private Button btn_left;
        private Button btn_right;
        private Label lb_question;
        private Panel pn_inf;
        private Panel panel1;
        private Panel pn_teste;
        private Panel panel2;
        private PictureBox pb_background;
    }
}