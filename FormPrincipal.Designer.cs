namespace SimpleToPark
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelValorArrecadado = new Label();
            dataGridViewCarrosEstacionados = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonCadastrar = new Button();
            buttonConfigurar = new Button();
            labelValorHora = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrosEstacionados).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9799F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.0201F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(835, 421);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelValorArrecadado, 0, 1);
            tableLayoutPanel2.Controls.Add(dataGridViewCarrosEstacionados, 0, 0);
            tableLayoutPanel2.Location = new Point(178, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.43374F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5662651F));
            tableLayoutPanel2.Size = new Size(654, 415);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelValorArrecadado
            // 
            labelValorArrecadado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelValorArrecadado.AutoSize = true;
            labelValorArrecadado.Font = new Font("Palatino Linotype", 16F, FontStyle.Bold);
            labelValorArrecadado.Location = new Point(385, 386);
            labelValorArrecadado.Name = "labelValorArrecadado";
            labelValorArrecadado.Size = new Size(266, 29);
            labelValorArrecadado.TabIndex = 0;
            labelValorArrecadado.Text = "Valor Arrecadado R$ 0,00";
            labelValorArrecadado.TextAlign = ContentAlignment.BottomRight;
            // 
            // dataGridViewCarrosEstacionados
            // 
            dataGridViewCarrosEstacionados.AllowUserToAddRows = false;
            dataGridViewCarrosEstacionados.AllowUserToDeleteRows = false;
            dataGridViewCarrosEstacionados.AllowUserToResizeColumns = false;
            dataGridViewCarrosEstacionados.AllowUserToResizeRows = false;
            dataGridViewCarrosEstacionados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCarrosEstacionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCarrosEstacionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrosEstacionados.Location = new Point(3, 3);
            dataGridViewCarrosEstacionados.Name = "dataGridViewCarrosEstacionados";
            dataGridViewCarrosEstacionados.ReadOnly = true;
            dataGridViewCarrosEstacionados.RowHeadersVisible = false;
            dataGridViewCarrosEstacionados.Size = new Size(648, 361);
            dataGridViewCarrosEstacionados.TabIndex = 1;
            dataGridViewCarrosEstacionados.CellDoubleClick += dataGridViewCarrosEstacionados_CellDoubleClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(buttonCadastrar, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonConfigurar, 0, 2);
            tableLayoutPanel3.Controls.Add(labelValorHora, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3843288F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 77.23606F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3796072F));
            tableLayoutPanel3.Size = new Size(169, 415);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCadastrar.BackColor = Color.Khaki;
            buttonCadastrar.Location = new Point(3, 3);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(163, 41);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // buttonConfigurar
            // 
            buttonConfigurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfigurar.BackColor = Color.Khaki;
            buttonConfigurar.Location = new Point(3, 370);
            buttonConfigurar.Name = "buttonConfigurar";
            buttonConfigurar.Size = new Size(163, 42);
            buttonConfigurar.TabIndex = 1;
            buttonConfigurar.Text = "Configurar";
            buttonConfigurar.UseVisualStyleBackColor = false;
            buttonConfigurar.Click += buttonConfigurar_Click;
            // 
            // labelValorHora
            // 
            labelValorHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelValorHora.AutoSize = true;
            labelValorHora.Font = new Font("Palatino Linotype", 16F, FontStyle.Bold);
            labelValorHora.Location = new Point(3, 309);
            labelValorHora.Name = "labelValorHora";
            labelValorHora.Size = new Size(159, 58);
            labelValorHora.TabIndex = 2;
            labelValorHora.Text = "Valor da Hora R$ 0,00";
            labelValorHora.TextAlign = ContentAlignment.BottomLeft;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(859, 445);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "SimpleToPark";
            Load += FormPrincipal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrosEstacionados).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelValorArrecadado;
        private DataGridView dataGridViewCarrosEstacionados;
        private Button buttonCadastrar;
        private Button buttonConfigurar;
        private Label labelValorHora;
    }
}
