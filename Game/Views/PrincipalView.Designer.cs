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
            pb_main_character = new PictureBox();
            pb_floor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_main_character).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_floor).BeginInit();
            SuspendLayout();
            // 
            // pb_main_character
            // 
            pb_main_character.Image = (Image)resources.GetObject("pb_main_character.Image");
            pb_main_character.Location = new Point(21, 608);
            pb_main_character.Name = "pb_main_character";
            pb_main_character.Size = new Size(39, 70);
            pb_main_character.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_main_character.TabIndex = 0;
            pb_main_character.TabStop = false;
            // 
            // pb_floor
            // 
            pb_floor.Image = (Image)resources.GetObject("pb_floor.Image");
            pb_floor.Location = new Point(0, 672);
            pb_floor.Name = "pb_floor";
            pb_floor.Size = new Size(1387, 131);
            pb_floor.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_floor.TabIndex = 1;
            pb_floor.TabStop = false;
            // 
            // PrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 805);
            Controls.Add(pb_floor);
            Controls.Add(pb_main_character);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PrincipalView";
            Text = "PrincipalView";
            WindowState = FormWindowState.Maximized;
            KeyDown += PrincipalView_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pb_main_character).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_floor).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pn_inf;
        private PictureBox pb_main_character;
        private PictureBox pb_floor;
    }
}