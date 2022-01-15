
namespace CsForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Afficher = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.Label();
            this.Villes = new System.Windows.Forms.ListBox();
            this.Femme = new System.Windows.Forms.RadioButton();
            this.Homme = new System.Windows.Forms.RadioButton();
            this.CS = new System.Windows.Forms.CheckBox();
            this.Java = new System.Windows.Forms.CheckBox();
            this.cpp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // Afficher
            // 
            this.Afficher.Location = new System.Drawing.Point(637, 315);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(75, 23);
            this.Afficher.TabIndex = 2;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(198, 64);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(156, 22);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(198, 104);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(156, 22);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(106, 155);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(60, 17);
            this.Adresse.TabIndex = 5;
            this.Adresse.Text = "Adresse";
            // 
            // Villes
            // 
            this.Villes.FormattingEnabled = true;
            this.Villes.ItemHeight = 16;
            this.Villes.Items.AddRange(new object[] {
            "Casa",
            "Rabat",
            "Mohamedia"});
            this.Villes.Location = new System.Drawing.Point(198, 155);
            this.Villes.Name = "Villes";
            this.Villes.Size = new System.Drawing.Size(156, 84);
            this.Villes.TabIndex = 7;
            // 
            // Femme
            // 
            this.Femme.AutoSize = true;
            this.Femme.Location = new System.Drawing.Point(619, 63);
            this.Femme.Name = "Femme";
            this.Femme.Size = new System.Drawing.Size(75, 21);
            this.Femme.TabIndex = 8;
            this.Femme.TabStop = true;
            this.Femme.Text = "Femme";
            this.Femme.UseVisualStyleBackColor = true;
            this.Femme.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Homme
            // 
            this.Homme.AutoSize = true;
            this.Homme.Location = new System.Drawing.Point(619, 91);
            this.Homme.Name = "Homme";
            this.Homme.Size = new System.Drawing.Size(77, 21);
            this.Homme.TabIndex = 9;
            this.Homme.TabStop = true;
            this.Homme.Text = "Homme";
            this.Homme.UseVisualStyleBackColor = true;
            // 
            // CS
            // 
            this.CS.AutoSize = true;
            this.CS.Location = new System.Drawing.Point(619, 150);
            this.CS.Name = "CS";
            this.CS.Size = new System.Drawing.Size(47, 21);
            this.CS.TabIndex = 10;
            this.CS.Text = "C#";
            this.CS.UseVisualStyleBackColor = true;
            // 
            // Java
            // 
            this.Java.AutoSize = true;
            this.Java.Location = new System.Drawing.Point(619, 191);
            this.Java.Name = "Java";
            this.Java.Size = new System.Drawing.Size(64, 21);
            this.Java.TabIndex = 11;
            this.Java.Text = "JAVA";
            this.Java.UseVisualStyleBackColor = true;
            this.Java.CheckedChanged += new System.EventHandler(this.Java_CheckedChanged);
            // 
            // cpp
            // 
            this.cpp.AutoSize = true;
            this.cpp.Location = new System.Drawing.Point(619, 236);
            this.cpp.Name = "cpp";
            this.cpp.Size = new System.Drawing.Size(55, 21);
            this.cpp.TabIndex = 12;
            this.cpp.Text = "C++";
            this.cpp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpp);
            this.Controls.Add(this.Java);
            this.Controls.Add(this.CS);
            this.Controls.Add(this.Homme);
            this.Controls.Add(this.Femme);
            this.Controls.Add(this.Villes);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Afficher;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.ListBox Villes;
        private System.Windows.Forms.RadioButton Femme;
        private System.Windows.Forms.RadioButton Homme;
        private System.Windows.Forms.CheckBox CS;
        private System.Windows.Forms.CheckBox Java;
        private System.Windows.Forms.CheckBox cpp;
    }
}

