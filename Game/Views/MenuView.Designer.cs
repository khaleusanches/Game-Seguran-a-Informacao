namespace game.Views
{
    partial class MenuView
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
            btn_iniciar = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btn_iniciar
            // 
            btn_iniciar.Location = new Point(362, 134);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(74, 35);
            btn_iniciar.TabIndex = 0;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(362, 192);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 1;
            button4.Text = "button2";
            button4.UseVisualStyleBackColor = true;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(btn_iniciar);
            Name = "MenuView";
            Text = "MenuView";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_iniciar;
        private Button button4;
    }
}