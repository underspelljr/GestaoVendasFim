namespace Gvendas.pt.com.Gvendas.VIEWS
{
    partial class FormHome
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
            this.labelHome = new System.Windows.Forms.Label();
            this.buttonManipular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(198, 38);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(154, 25);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "Página inicial";
            // 
            // buttonManipular
            // 
            this.buttonManipular.BackColor = System.Drawing.Color.Brown;
            this.buttonManipular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonManipular.FlatAppearance.BorderSize = 2;
            this.buttonManipular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManipular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManipular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonManipular.Location = new System.Drawing.Point(157, 181);
            this.buttonManipular.Name = "buttonManipular";
            this.buttonManipular.Size = new System.Drawing.Size(245, 35);
            this.buttonManipular.TabIndex = 32;
            this.buttonManipular.Text = "Gerir Dados";
            this.buttonManipular.UseVisualStyleBackColor = false;
            this.buttonManipular.Click += new System.EventHandler(this.buttonManipular_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(569, 350);
            this.Controls.Add(this.buttonManipular);
            this.Controls.Add(this.labelHome);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Button buttonManipular;
    }
}