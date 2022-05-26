
namespace RPGArtifactsManager
{
    partial class LoginControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_guestLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(118, 96);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(100, 20);
            this.tbx_password.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasło:";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(118, 54);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(100, 20);
            this.tbx_username.TabIndex = 6;
            this.tbx_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwa użytkownika:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(118, 136);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 23);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Zaloguj";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_guestLogin
            // 
            this.btn_guestLogin.Location = new System.Drawing.Point(12, 136);
            this.btn_guestLogin.Name = "btn_guestLogin";
            this.btn_guestLogin.Size = new System.Drawing.Size(100, 23);
            this.btn_guestLogin.TabIndex = 10;
            this.btn_guestLogin.Text = "Zaloguj jako gość";
            this.btn_guestLogin.UseVisualStyleBackColor = true;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_guestLogin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.label1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(245, 186);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_guestLogin;
        internal System.Windows.Forms.TextBox tbx_password;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox tbx_username;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btn_login;
    }
}
