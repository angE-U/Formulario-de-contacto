namespace Formulario_de_contacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            btnConsulta = new RadioButton();
            btnQueja = new RadioButton();
            btnSugerencia = new RadioButton();
            chkRespuesta = new CheckBox();
            btnenviar = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            confirmacion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(477, 42);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 118);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(155, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(434, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 209);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 3;
            label3.Text = "Motivo de contacto:";
            // 
            // btnConsulta
            // 
            btnConsulta.AutoSize = true;
            btnConsulta.Location = new Point(77, 244);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(72, 19);
            btnConsulta.TabIndex = 4;
            btnConsulta.TabStop = true;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnQueja
            // 
            btnQueja.AutoSize = true;
            btnQueja.Location = new Point(77, 269);
            btnQueja.Name = "btnQueja";
            btnQueja.Size = new Size(56, 19);
            btnQueja.TabIndex = 5;
            btnQueja.TabStop = true;
            btnQueja.Text = "Queja";
            btnQueja.UseVisualStyleBackColor = true;
            // 
            // btnSugerencia
            // 
            btnSugerencia.AutoSize = true;
            btnSugerencia.Location = new Point(77, 294);
            btnSugerencia.Name = "btnSugerencia";
            btnSugerencia.Size = new Size(83, 19);
            btnSugerencia.TabIndex = 6;
            btnSugerencia.TabStop = true;
            btnSugerencia.Text = "Sugerencia";
            btnSugerencia.UseVisualStyleBackColor = true;
            // 
            // chkRespuesta
            // 
            chkRespuesta.AutoSize = true;
            chkRespuesta.Location = new Point(77, 334);
            chkRespuesta.Name = "chkRespuesta";
            chkRespuesta.Size = new Size(137, 19);
            chkRespuesta.TabIndex = 7;
            chkRespuesta.Text = "Deso recibir respuesa";
            chkRespuesta.UseVisualStyleBackColor = true;
            // 
            // btnenviar
            // 
            btnenviar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnenviar.Location = new Point(77, 372);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(115, 34);
            btnenviar.TabIndex = 8;
            btnenviar.Text = "Enviar";
            btnenviar.UseVisualStyleBackColor = true;
            btnenviar.Click += btnenviar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 433);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 9;
            label4.Text = "Confirmación:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(252, 617);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(136, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ver políticade privacidad";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // confirmacion
            // 
            confirmacion.BorderStyle = BorderStyle.FixedSingle;
            confirmacion.Cursor = Cursors.SizeNS;
            confirmacion.Location = new Point(77, 472);
            confirmacion.Name = "confirmacion";
            confirmacion.Size = new Size(526, 104);
            confirmacion.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 641);
            Controls.Add(confirmacion);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(btnenviar);
            Controls.Add(chkRespuesta);
            Controls.Add(btnSugerencia);
            Controls.Add(btnQueja);
            Controls.Add(btnConsulta);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Formulario de contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private RadioButton btnConsulta;
        private RadioButton btnQueja;
        private RadioButton btnSugerencia;
        private CheckBox chkRespuesta;
        private Button btnenviar;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label confirmacion;
    }
}
