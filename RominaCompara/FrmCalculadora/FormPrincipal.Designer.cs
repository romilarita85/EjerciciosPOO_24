namespace FrmCalculadora
{
    partial class FormPrincipal
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
            btn_Aceptar = new Button();
            txt_resultado = new TextBox();
            lbl_resultado = new Label();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(285, 103);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(168, 51);
            btn_Aceptar.TabIndex = 0;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(142, 51);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(311, 27);
            txt_resultado.TabIndex = 1;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Location = new Point(32, 51);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(78, 20);
            lbl_resultado.TabIndex = 2;
            lbl_resultado.Text = "Resultado:";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 200);
            Controls.Add(lbl_resultado);
            Controls.Add(txt_resultado);
            Controls.Add(btn_Aceptar);
            Name = "FormPrincipal";
            Text = "Mostrar Resultado";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Aceptar;
        private TextBox txt_resultado;
        private Label lbl_resultado;
    }
}