
namespace GeometriaDesktop
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
            groupBox1 = new GroupBox();
            btnConfirmarRegistro = new Button();
            btnLimpiar = new Button();
            tbArea = new TextBox();
            tbRadio = new TextBox();
            tbLargo = new TextBox();
            tbAncho = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rbCirculo = new RadioButton();
            rbRectangulo = new RadioButton();
            groupBox3 = new GroupBox();
            lvwFiguras = new ListView();
            btnEliminarRegistro = new Button();
            btnActualizar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmarRegistro);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(tbArea);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(tbLargo);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Figura";
            // 
            // btnConfirmarRegistro
            // 
            btnConfirmarRegistro.Location = new Point(379, 106);
            btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            btnConfirmarRegistro.Size = new Size(75, 44);
            btnConfirmarRegistro.TabIndex = 10;
            btnConfirmarRegistro.Text = "Confirmar Registro";
            btnConfirmarRegistro.UseVisualStyleBackColor = true;
            btnConfirmarRegistro.Click += btnConfirmarRegistro_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(379, 36);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 44);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(252, 143);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(100, 23);
            tbArea.TabIndex = 8;
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(252, 107);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(100, 23);
            tbRadio.TabIndex = 7;
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(252, 73);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(100, 23);
            tbLargo.TabIndex = 6;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(252, 36);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 23);
            tbAncho.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 145);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Área:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 110);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Radio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 73);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Largo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 39);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Ancho:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbCirculo);
            groupBox2.Controls.Add(rbRectangulo);
            groupBox2.Location = new Point(15, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(156, 111);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Figura";
            // 
            // rbCirculo
            // 
            rbCirculo.AutoSize = true;
            rbCirculo.Location = new Point(16, 71);
            rbCirculo.Name = "rbCirculo";
            rbCirculo.Size = new Size(63, 19);
            rbCirculo.TabIndex = 1;
            rbCirculo.TabStop = true;
            rbCirculo.Text = "Círculo";
            rbCirculo.UseVisualStyleBackColor = true;
            // 
            // rbRectangulo
            // 
            rbRectangulo.AutoSize = true;
            rbRectangulo.Location = new Point(16, 34);
            rbRectangulo.Name = "rbRectangulo";
            rbRectangulo.Size = new Size(85, 19);
            rbRectangulo.TabIndex = 0;
            rbRectangulo.TabStop = true;
            rbRectangulo.Text = "Rectangulo";
            rbRectangulo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lvwFiguras);
            groupBox3.Controls.Add(btnEliminarRegistro);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Location = new Point(12, 198);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 327);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Listado de Figuras";
            // 
            // lvwFiguras
            // 
            lvwFiguras.Location = new Point(15, 33);
            lvwFiguras.Name = "lvwFiguras";
            lvwFiguras.Size = new Size(337, 274);
            lvwFiguras.TabIndex = 13;
            lvwFiguras.UseCompatibleStateImageBehavior = false;
            lvwFiguras.ItemSelectionChanged += lvwFiguras_ItemSelectionChanged;
            
            // 
            // btnEliminarRegistro
            // 
            btnEliminarRegistro.Location = new Point(379, 196);
            btnEliminarRegistro.Name = "btnEliminarRegistro";
            btnEliminarRegistro.Size = new Size(75, 53);
            btnEliminarRegistro.TabIndex = 12;
            btnEliminarRegistro.Text = "Eliminar Registro";
            btnEliminarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(379, 71);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 51);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar Listado";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 537);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo de ABM";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnConfirmarRegistro;
        private Button btnLimpiar;
        private TextBox tbArea;
        private TextBox tbRadio;
        private TextBox tbLargo;
        private TextBox tbAncho;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rbCirculo;
        private RadioButton rbRectangulo;
        private GroupBox groupBox3;
        private Button btnEliminarRegistro;
        private Button btnActualizar;
        private ListView lvwFiguras;
    }
}
