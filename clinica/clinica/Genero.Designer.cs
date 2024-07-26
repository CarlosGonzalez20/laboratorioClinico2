
namespace clinica
{
    partial class Genero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Genero));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MBBus = new MaterialSkin.Controls.MaterialButton();
            this.MBmod = new MaterialSkin.Controls.MaterialButton();
            this.MTElim = new MaterialSkin.Controls.MaterialButton();
            this.MBIng = new MaterialSkin.Controls.MaterialButton();
            this.MTNumge = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MTEstatus = new MaterialSkin.Controls.MaterialTextBox();
            this.MTEstado = new MaterialSkin.Controls.MaterialLabel();
            this.txtNom = new MaterialSkin.Controls.MaterialTextBox();
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
            this.groupBox1.Location = new System.Drawing.Point(241, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 163);
            this.groupBox1.TabIndex = 16;
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
            // MTNumge
            // 
            this.MTNumge.AnimateReadOnly = false;
            this.MTNumge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTNumge.Depth = 0;
            this.MTNumge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTNumge.LeadingIcon = null;
            this.MTNumge.Location = new System.Drawing.Point(265, 112);
            this.MTNumge.MaxLength = 50;
            this.MTNumge.MouseState = MaterialSkin.MouseState.OUT;
            this.MTNumge.Multiline = false;
            this.MTNumge.Name = "MTNumge";
            this.MTNumge.Size = new System.Drawing.Size(176, 50);
            this.MTNumge.TabIndex = 15;
            this.MTNumge.Text = "";
            this.MTNumge.TrailingIcon = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MTEstatus
            // 
            this.MTEstatus.AnimateReadOnly = false;
            this.MTEstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTEstatus.Depth = 0;
            this.MTEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTEstatus.LeadingIcon = null;
            this.MTEstatus.Location = new System.Drawing.Point(265, 312);
            this.MTEstatus.MaxLength = 50;
            this.MTEstatus.MouseState = MaterialSkin.MouseState.OUT;
            this.MTEstatus.Multiline = false;
            this.MTEstatus.Name = "MTEstatus";
            this.MTEstatus.Size = new System.Drawing.Size(176, 50);
            this.MTEstatus.TabIndex = 13;
            this.MTEstatus.Text = "";
            this.MTEstatus.TrailingIcon = null;
            // 
            // MTEstado
            // 
            this.MTEstado.AutoSize = true;
            this.MTEstado.Depth = 0;
            this.MTEstado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTEstado.Location = new System.Drawing.Point(167, 314);
            this.MTEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTEstado.Name = "MTEstado";
            this.MTEstado.Size = new System.Drawing.Size(54, 19);
            this.MTEstado.TabIndex = 12;
            this.MTEstado.Text = "Estado:";
            // 
            // txtNom
            // 
            this.txtNom.AnimateReadOnly = false;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Depth = 0;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNom.LeadingIcon = null;
            this.txtNom.Location = new System.Drawing.Point(265, 211);
            this.txtNom.MaxLength = 50;
            this.txtNom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNom.Multiline = false;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(176, 50);
            this.txtNom.TabIndex = 11;
            this.txtNom.Text = "";
            this.txtNom.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(106, 224);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Nombre Género:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(142, 115);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "No Género:";
            // 
            // Genero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MTNumge);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MTEstatus);
            this.Controls.Add(this.MTEstado);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Genero";
            this.Text = "Genero";
            this.Load += new System.EventHandler(this.Genero_Load);
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
        private MaterialSkin.Controls.MaterialTextBox MTNumge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox MTEstatus;
        private MaterialSkin.Controls.MaterialLabel MTEstado;
        private MaterialSkin.Controls.MaterialTextBox txtNom;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}