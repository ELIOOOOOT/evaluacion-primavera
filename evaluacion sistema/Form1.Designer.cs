namespace evaluacion_sistema
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_TITULO = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_NAME = new System.Windows.Forms.Label();
            this.lbl_FECHA = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnACTUALIZAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.lblAPELLIDO = new System.Windows.Forms.Label();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_TITULO
            // 
            this.lbl_TITULO.AutoSize = true;
            this.lbl_TITULO.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TITULO.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TITULO.Location = new System.Drawing.Point(120, 23);
            this.lbl_TITULO.Name = "lbl_TITULO";
            this.lbl_TITULO.Size = new System.Drawing.Size(351, 29);
            this.lbl_TITULO.TabIndex = 0;
            this.lbl_TITULO.Text = "SISTEMA DE REGISTROS";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(88, 69);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(29, 18);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_NAME
            // 
            this.lbl_NAME.AutoSize = true;
            this.lbl_NAME.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NAME.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NAME.Location = new System.Drawing.Point(88, 96);
            this.lbl_NAME.Name = "lbl_NAME";
            this.lbl_NAME.Size = new System.Drawing.Size(82, 18);
            this.lbl_NAME.TabIndex = 2;
            this.lbl_NAME.Text = "NOMBRE";
            // 
            // lbl_FECHA
            // 
            this.lbl_FECHA.AutoSize = true;
            this.lbl_FECHA.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FECHA.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FECHA.Location = new System.Drawing.Point(88, 152);
            this.lbl_FECHA.Name = "lbl_FECHA";
            this.lbl_FECHA.Size = new System.Drawing.Size(215, 18);
            this.lbl_FECHA.TabIndex = 3;
            this.lbl_FECHA.Text = "FECHA DE NACIMIENTO";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(324, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(324, 97);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(200, 20);
            this.txtNAME.TabIndex = 5;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.White;
            this.btnAGREGAR.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGAR.Location = new System.Drawing.Point(91, 231);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(98, 35);
            this.btnAGREGAR.TabIndex = 7;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnACTUALIZAR
            // 
            this.btnACTUALIZAR.BackColor = System.Drawing.Color.White;
            this.btnACTUALIZAR.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACTUALIZAR.Location = new System.Drawing.Point(248, 231);
            this.btnACTUALIZAR.Name = "btnACTUALIZAR";
            this.btnACTUALIZAR.Size = new System.Drawing.Size(107, 35);
            this.btnACTUALIZAR.TabIndex = 8;
            this.btnACTUALIZAR.Text = "ACTUALIZAR";
            this.btnACTUALIZAR.UseVisualStyleBackColor = false;
            this.btnACTUALIZAR.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackColor = System.Drawing.Color.White;
            this.btnELIMINAR.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINAR.Location = new System.Drawing.Point(407, 231);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(98, 35);
            this.btnELIMINAR.TabIndex = 9;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(324, 152);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(200, 20);
            this.dtpFECHA.TabIndex = 11;
            // 
            // lblAPELLIDO
            // 
            this.lblAPELLIDO.AutoSize = true;
            this.lblAPELLIDO.BackColor = System.Drawing.Color.Transparent;
            this.lblAPELLIDO.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPELLIDO.Location = new System.Drawing.Point(88, 124);
            this.lblAPELLIDO.Name = "lblAPELLIDO";
            this.lblAPELLIDO.Size = new System.Drawing.Size(99, 18);
            this.lblAPELLIDO.TabIndex = 12;
            this.lblAPELLIDO.Text = "APELLIDO";
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.Location = new System.Drawing.Point(324, 124);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(200, 20);
            this.txtAPELLIDO.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::evaluacion_sistema.Properties.Resources.sakura;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.txtAPELLIDO);
            this.Controls.Add(this.lblAPELLIDO);
            this.Controls.Add(this.dtpFECHA);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnACTUALIZAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbl_FECHA);
            this.Controls.Add(this.lbl_NAME);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_TITULO);
            this.MaximumSize = new System.Drawing.Size(600, 380);
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TITULO;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_NAME;
        private System.Windows.Forms.Label lbl_FECHA;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnACTUALIZAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Label lblAPELLIDO;
        private System.Windows.Forms.TextBox txtAPELLIDO;
    }
}

