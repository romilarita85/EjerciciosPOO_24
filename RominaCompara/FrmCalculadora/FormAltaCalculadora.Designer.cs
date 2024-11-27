namespace FrmCalculadora
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btn_Suma = new Button();
            btn_Resta = new Button();
            btn_Multiplicacion = new Button();
            btn_Div = new Button();
            lbl_num1 = new Label();
            lbl_Num2 = new Label();
            btn_Igual = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(191, 58);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(182, 27);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(191, 98);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(182, 27);
            txtNum2.TabIndex = 1;
            // 
            // btn_Suma
            // 
            btn_Suma.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_Suma.Location = new Point(96, 162);
            btn_Suma.Name = "btn_Suma";
            btn_Suma.Size = new Size(67, 59);
            btn_Suma.TabIndex = 2;
            btn_Suma.Text = "+";
            btn_Suma.UseVisualStyleBackColor = true;
            btn_Suma.Click += btn_Suma_Click;
            // 
            // btn_Resta
            // 
            btn_Resta.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_Resta.Location = new Point(191, 162);
            btn_Resta.Name = "btn_Resta";
            btn_Resta.Size = new Size(67, 59);
            btn_Resta.TabIndex = 3;
            btn_Resta.Text = "-";
            btn_Resta.UseVisualStyleBackColor = true;
            btn_Resta.Click += btn_Resta_Click;
            // 
            // btn_Multiplicacion
            // 
            btn_Multiplicacion.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_Multiplicacion.Location = new Point(285, 162);
            btn_Multiplicacion.Name = "btn_Multiplicacion";
            btn_Multiplicacion.Size = new Size(67, 59);
            btn_Multiplicacion.TabIndex = 4;
            btn_Multiplicacion.Text = "*";
            btn_Multiplicacion.UseVisualStyleBackColor = true;
            btn_Multiplicacion.Click += btn_Multiplicacion_Click;
            // 
            // btn_Div
            // 
            btn_Div.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_Div.Location = new Point(372, 162);
            btn_Div.Name = "btn_Div";
            btn_Div.Size = new Size(67, 59);
            btn_Div.TabIndex = 5;
            btn_Div.Text = "/";
            btn_Div.UseVisualStyleBackColor = true;
            btn_Div.Click += btn_Div_Click;
            // 
            // lbl_num1
            // 
            lbl_num1.AutoSize = true;
            lbl_num1.Location = new Point(96, 58);
            lbl_num1.Name = "lbl_num1";
            lbl_num1.Size = new Size(75, 20);
            lbl_num1.TabIndex = 6;
            lbl_num1.Text = "Numero 1";
            // 
            // lbl_Num2
            // 
            lbl_Num2.AutoSize = true;
            lbl_Num2.Location = new Point(96, 101);
            lbl_Num2.Name = "lbl_Num2";
            lbl_Num2.Size = new Size(75, 20);
            lbl_Num2.TabIndex = 7;
            lbl_Num2.Text = "Numero 2";
            // 
            // btn_Igual
            // 
            btn_Igual.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_Igual.Location = new Point(96, 243);
            btn_Igual.Name = "btn_Igual";
            btn_Igual.Size = new Size(343, 40);
            btn_Igual.TabIndex = 8;
            btn_Igual.Text = "=";
            btn_Igual.UseVisualStyleBackColor = true;
            btn_Igual.Click += btn_Igual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 326);
            Controls.Add(btn_Igual);
            Controls.Add(lbl_Num2);
            Controls.Add(lbl_num1);
            Controls.Add(btn_Div);
            Controls.Add(btn_Multiplicacion);
            Controls.Add(btn_Resta);
            Controls.Add(btn_Suma);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btn_Suma;
        private Button btn_Resta;
        private Button btn_Multiplicacion;
        private Button btn_Div;
        private Label lbl_num1;
        private Label lbl_Num2;
        private Button btn_Igual;
    }
}
