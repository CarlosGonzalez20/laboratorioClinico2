
namespace clinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MBBus = new MaterialSkin.Controls.MaterialButton();
            this.MBmod = new MaterialSkin.Controls.MaterialButton();
            this.MTElim = new MaterialSkin.Controls.MaterialButton();
            this.MBIng = new MaterialSkin.Controls.MaterialButton();
            this.MTDir = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.MTNom = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MBBus);
            this.groupBox1.Controls.Add(this.MBmod);
            this.groupBox1.Controls.Add(this.MTElim);
            this.groupBox1.Controls.Add(this.MBIng);
            this.groupBox1.Location = new System.Drawing.Point(283, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 163);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // MBBus
            // 
            this.MBBus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MBBus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MBBus.Depth = 0;
            this.MBBus.HighEmphasis = true;
            this.MBBus.Icon = null;
            this.MBBus.Location = new System.Drawing.Point(206, 99);
            this.MBBus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MBBus.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBBus.Name = "MBBus";
            this.MBBus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MBBus.Size = new System.Drawing.Size(77, 36);
            this.MBBus.TabIndex = 3;
            this.MBBus.Text = "Buscar";
            this.MBBus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MBBus.UseAccentColor = false;
            this.MBBus.UseVisualStyleBackColor = true;
            // 
            // MBmod
            // 
            this.MBmod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MBmod.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MBmod.Depth = 0;
            this.MBmod.HighEmphasis = true;
            this.MBmod.Icon = null;
            this.MBmod.Location = new System.Drawing.Point(51, 99);
            this.MBmod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MBmod.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBmod.Name = "MBmod";
            this.MBmod.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MBmod.Size = new System.Drawing.Size(99, 36);
            this.MBmod.TabIndex = 2;
            this.MBmod.Text = "Modificar";
            this.MBmod.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MBmod.UseAccentColor = false;
            this.MBmod.UseVisualStyleBackColor = true;
            // 
            // MTElim
            // 
            this.MTElim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MTElim.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MTElim.Depth = 0;
            this.MTElim.HighEmphasis = true;
            this.MTElim.Icon = null;
            this.MTElim.Location = new System.Drawing.Point(206, 38);
            this.MTElim.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MTElim.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTElim.Name = "MTElim";
            this.MTElim.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MTElim.Size = new System.Drawing.Size(88, 36);
            this.MTElim.TabIndex = 1;
            this.MTElim.Text = "Eliminar";
            this.MTElim.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MTElim.UseAccentColor = false;
            this.MTElim.UseVisualStyleBackColor = true;
            // 
            // MBIng
            // 
            this.MBIng.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MBIng.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MBIng.Depth = 0;
            this.MBIng.HighEmphasis = true;
            this.MBIng.Icon = null;
            this.MBIng.Location = new System.Drawing.Point(51, 38);
            this.MBIng.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MBIng.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBIng.Name = "MBIng";
            this.MBIng.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MBIng.Size = new System.Drawing.Size(91, 36);
            this.MBIng.TabIndex = 0;
            this.MBIng.Text = "Ingresar";
            this.MBIng.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MBIng.UseAccentColor = false;
            this.MBIng.UseVisualStyleBackColor = true;
            // 
            // MTDir
            // 
            this.MTDir.AnimateReadOnly = false;
            this.MTDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTDir.Depth = 0;
            this.MTDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTDir.LeadingIcon = null;
            this.MTDir.Location = new System.Drawing.Point(706, 104);
            this.MTDir.MaxLength = 50;
            this.MTDir.MouseState = MaterialSkin.MouseState.OUT;
            this.MTDir.Multiline = false;
            this.MTDir.Name = "MTDir";
            this.MTDir.Size = new System.Drawing.Size(186, 50);
            this.MTDir.TabIndex = 24;
            this.MTDir.Text = "";
            this.MTDir.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(706, 370);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(186, 50);
            this.materialTextBox2.TabIndex = 23;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(543, 390);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Estado: ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(480, 306);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(209, 19);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "Descripción De Especialidad: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(706, 275);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(186, 50);
            this.materialTextBox1.TabIndex = 19;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // MTNom
            // 
            this.MTNom.AnimateReadOnly = false;
            this.MTNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTNom.Depth = 0;
            this.MTNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTNom.LeadingIcon = null;
            this.MTNom.Location = new System.Drawing.Point(706, 185);
            this.MTNom.MaxLength = 50;
            this.MTNom.MouseState = MaterialSkin.MouseState.OUT;
            this.MTNom.Multiline = false;
            this.MTNom.Name = "MTNom";
            this.MTNom.Size = new System.Drawing.Size(186, 50);
            this.MTNom.TabIndex = 18;
            this.MTNom.Text = "";
            this.MTNom.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(505, 124);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(151, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Número Especialidad";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(505, 216);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(159, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Nombre Especialidad: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 701);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MTDir);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.MTNom);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton MBBus;
        private MaterialSkin.Controls.MaterialButton MBmod;
        private MaterialSkin.Controls.MaterialButton MTElim;
        private MaterialSkin.Controls.MaterialButton MBIng;
        private MaterialSkin.Controls.MaterialTextBox MTDir;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox MTNom;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}