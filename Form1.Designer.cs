namespace Desafio_4_Estacionamento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxPlacaCarro = new TextBox();
            buttonEntrada = new Button();
            button2 = new Button();
            labelListaVeiculosGaragem = new Label();
            label3 = new Label();
            label4 = new Label();
            listBoxVeiculosGaragem = new ListBox();
            listBoxVeiculosSaida = new ListBox();
            labelHoraAtual = new Label();
            Timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            labelValorPagar = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelValor = new Label();
            labelTempoPermanencia = new Label();
            labelPreco = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // textBoxPlacaCarro
            // 
            textBoxPlacaCarro.BackColor = SystemColors.ActiveCaption;
            textBoxPlacaCarro.CharacterCasing = CharacterCasing.Upper;
            resources.ApplyResources(textBoxPlacaCarro, "textBoxPlacaCarro");
            textBoxPlacaCarro.ForeColor = Color.Gold;
            textBoxPlacaCarro.Name = "textBoxPlacaCarro";
            // 
            // buttonEntrada
            // 
            resources.ApplyResources(buttonEntrada, "buttonEntrada");
            buttonEntrada.Name = "buttonEntrada";
            buttonEntrada.UseVisualStyleBackColor = true;
            buttonEntrada.Click += EntradaCarro;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SaidaCarro;
            // 
            // labelListaVeiculosGaragem
            // 
            resources.ApplyResources(labelListaVeiculosGaragem, "labelListaVeiculosGaragem");
            labelListaVeiculosGaragem.Name = "labelListaVeiculosGaragem";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // listBoxVeiculosGaragem
            // 
            listBoxVeiculosGaragem.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(listBoxVeiculosGaragem, "listBoxVeiculosGaragem");
            listBoxVeiculosGaragem.FormattingEnabled = true;
            listBoxVeiculosGaragem.Name = "listBoxVeiculosGaragem";
            // 
            // listBoxVeiculosSaida
            // 
            listBoxVeiculosSaida.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(listBoxVeiculosSaida, "listBoxVeiculosSaida");
            listBoxVeiculosSaida.FormattingEnabled = true;
            listBoxVeiculosSaida.Name = "listBoxVeiculosSaida";
            // 
            // labelHoraAtual
            // 
            resources.ApplyResources(labelHoraAtual, "labelHoraAtual");
            labelHoraAtual.Name = "labelHoraAtual";
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Tick += Timer1_Tick;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // labelValorPagar
            // 
            resources.ApplyResources(labelValorPagar, "labelValorPagar");
            labelValorPagar.Name = "labelValorPagar";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // labelValor
            // 
            labelValor.ForeColor = Color.OliveDrab;
            resources.ApplyResources(labelValor, "labelValor");
            labelValor.Name = "labelValor";
            // 
            // labelTempoPermanencia
            // 
            resources.ApplyResources(labelTempoPermanencia, "labelTempoPermanencia");
            labelTempoPermanencia.ForeColor = Color.IndianRed;
            labelTempoPermanencia.Name = "labelTempoPermanencia";
            // 
            // labelPreco
            // 
            labelPreco.ForeColor = Color.OliveDrab;
            resources.ApplyResources(labelPreco, "labelPreco");
            labelPreco.Name = "labelPreco";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.OliveDrab;
            label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label2);
            Controls.Add(labelPreco);
            Controls.Add(labelTempoPermanencia);
            Controls.Add(labelValor);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(labelValorPagar);
            Controls.Add(pictureBox1);
            Controls.Add(labelHoraAtual);
            Controls.Add(listBoxVeiculosSaida);
            Controls.Add(listBoxVeiculosGaragem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelListaVeiculosGaragem);
            Controls.Add(button2);
            Controls.Add(buttonEntrada);
            Controls.Add(textBoxPlacaCarro);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPlacaCarro;
        private Button button2;
        private Button buttonEntrada;
        private Label labelListaVeiculosGaragem;
        private Label label3;
        private Label label4;
        private ListBox listBoxVeiculosGaragem;
        private ListBox listBoxVeiculosSaida;
        private Label labelHoraAtual;
        private System.Windows.Forms.Timer Timer1;
        private PictureBox pictureBox1;
        private Label labelValorPagar;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelValor;
        private Label labelTempoPermanencia;
        private Label labelPreco;
        private Label label2;
    }
}