namespace AdminProcesos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstprocesos = new System.Windows.Forms.ListBox();
            this.lstide = new System.Windows.Forms.ListBox();
            this.lstram = new System.Windows.Forms.ListBox();
            this.lstvirtual = new System.Windows.Forms.ListBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstcpu = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotalprocesos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstprocesos
            // 
            this.lstprocesos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstprocesos.FormattingEnabled = true;
            this.lstprocesos.ItemHeight = 23;
            this.lstprocesos.Location = new System.Drawing.Point(41, 44);
            this.lstprocesos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstprocesos.Name = "lstprocesos";
            this.lstprocesos.Size = new System.Drawing.Size(137, 418);
            this.lstprocesos.TabIndex = 0;
            // 
            // lstide
            // 
            this.lstide.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstide.FormattingEnabled = true;
            this.lstide.ItemHeight = 23;
            this.lstide.Location = new System.Drawing.Point(195, 44);
            this.lstide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstide.Name = "lstide";
            this.lstide.Size = new System.Drawing.Size(137, 418);
            this.lstide.TabIndex = 1;
            // 
            // lstram
            // 
            this.lstram.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstram.FormattingEnabled = true;
            this.lstram.ItemHeight = 23;
            this.lstram.Location = new System.Drawing.Point(350, 44);
            this.lstram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstram.Name = "lstram";
            this.lstram.Size = new System.Drawing.Size(137, 418);
            this.lstram.TabIndex = 2;
            // 
            // lstvirtual
            // 
            this.lstvirtual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstvirtual.FormattingEnabled = true;
            this.lstvirtual.ItemHeight = 23;
            this.lstvirtual.Location = new System.Drawing.Point(504, 44);
            this.lstvirtual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstvirtual.Name = "lstvirtual";
            this.lstvirtual.Size = new System.Drawing.Size(137, 418);
            this.lstvirtual.TabIndex = 3;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnactualizar.Location = new System.Drawing.Point(41, 492);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(86, 31);
            this.btnactualizar.TabIndex = 4;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncerrar.Location = new System.Drawing.Point(225, 492);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(86, 31);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.Location = new System.Drawing.Point(680, 492);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(86, 31);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(195, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Identificador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(350, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Memoria RAM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(502, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Memoria Virtual";
            // 
            // lstcpu
            // 
            this.lstcpu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstcpu.FormattingEnabled = true;
            this.lstcpu.ItemHeight = 23;
            this.lstcpu.Location = new System.Drawing.Point(663, 44);
            this.lstcpu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstcpu.Name = "lstcpu";
            this.lstcpu.Size = new System.Drawing.Size(137, 418);
            this.lstcpu.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(663, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Procesador";
            // 
            // lbltotalprocesos
            // 
            this.lbltotalprocesos.AutoSize = true;
            this.lbltotalprocesos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotalprocesos.Location = new System.Drawing.Point(41, 549);
            this.lbltotalprocesos.Name = "lbltotalprocesos";
            this.lbltotalprocesos.Size = new System.Drawing.Size(59, 23);
            this.lbltotalprocesos.TabIndex = 13;
            this.lbltotalprocesos.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 605);
            this.Controls.Add(this.lbltotalprocesos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstcpu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.lstvirtual);
            this.Controls.Add(this.lstram);
            this.Controls.Add(this.lstide);
            this.Controls.Add(this.lstprocesos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstprocesos;
        private ListBox lstide;
        private ListBox lstram;
        private ListBox lstvirtual;
        private Button btnactualizar;
        private Button btncerrar;
        private Button btnsalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstcpu;
        private Label label5;
        private Label lbltotalprocesos;
    }
}