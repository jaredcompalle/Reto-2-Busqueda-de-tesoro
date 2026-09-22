namespace Reto_2_Busqueda_de_tesoro
{
    partial class FrmRutaTesoro
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
            dgvRuta = new DataGridView();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPista = new TextBox();
            numPeligro = new NumericUpDown();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeligro).BeginInit();
            SuspendLayout();
            // 
            // dgvRuta
            // 
            dgvRuta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRuta.Location = new Point(25, 12);
            dgvRuta.Name = "dgvRuta";
            dgvRuta.Size = new Size(482, 105);
            dgvRuta.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(513, 7);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(513, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtPista
            // 
            txtPista.Location = new Point(513, 65);
            txtPista.Name = "txtPista";
            txtPista.Size = new Size(100, 23);
            txtPista.TabIndex = 3;
            // 
            // numPeligro
            // 
            numPeligro.Location = new Point(513, 94);
            numPeligro.Name = "numPeligro";
            numPeligro.Size = new Size(100, 23);
            numPeligro.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(144, 123);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(225, 123);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(306, 123);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(538, 134);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(619, 10);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 9;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(619, 39);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 10;
            label2.Text = "Ubicacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 68);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 11;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(619, 96);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 12;
            label4.Text = "Peligro";
            // 
            // FrmRutaTesoro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(numPeligro);
            Controls.Add(txtPista);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(dgvRuta);
            Name = "FrmRutaTesoro";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvRuta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeligro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRuta;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPista;
        private NumericUpDown numPeligro;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnBuscar;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
