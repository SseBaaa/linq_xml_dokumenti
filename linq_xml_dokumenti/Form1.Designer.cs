namespace linq_xml_dokumenti
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
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.buttonUcitaj = new System.Windows.Forms.Button();
            this.buttonFiltrilaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(12, 12);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(526, 84);
            this.buttonUnesi.TabIndex = 0;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // buttonUcitaj
            // 
            this.buttonUcitaj.Location = new System.Drawing.Point(12, 115);
            this.buttonUcitaj.Name = "buttonUcitaj";
            this.buttonUcitaj.Size = new System.Drawing.Size(526, 84);
            this.buttonUcitaj.TabIndex = 1;
            this.buttonUcitaj.Text = "Ucitaj";
            this.buttonUcitaj.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrilaj
            // 
            this.buttonFiltrilaj.Location = new System.Drawing.Point(12, 215);
            this.buttonFiltrilaj.Name = "buttonFiltrilaj";
            this.buttonFiltrilaj.Size = new System.Drawing.Size(526, 84);
            this.buttonFiltrilaj.TabIndex = 2;
            this.buttonFiltrilaj.Text = "Filtriraj";
            this.buttonFiltrilaj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 323);
            this.Controls.Add(this.buttonFiltrilaj);
            this.Controls.Add(this.buttonUcitaj);
            this.Controls.Add(this.buttonUnesi);
            this.Name = "Form1";
            this.Text = "Manipulacija podataka u XML-u";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.Button buttonUcitaj;
        private System.Windows.Forms.Button buttonFiltrilaj;
    }
}

