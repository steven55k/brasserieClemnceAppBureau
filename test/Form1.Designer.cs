namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_oui = new System.Windows.Forms.CheckBox();
            this.cb_non = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lb_qNecessaire = new System.Windows.Forms.ListBox();
            this.lesQuantite = new System.Windows.Forms.Button();
            this.tb_qBiere = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(59, 31);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cb_oui
            // 
            this.cb_oui.AutoSize = true;
            this.cb_oui.Location = new System.Drawing.Point(67, 56);
            this.cb_oui.Name = "cb_oui";
            this.cb_oui.Size = new System.Drawing.Size(40, 17);
            this.cb_oui.TabIndex = 3;
            this.cb_oui.Text = "oui";
            this.cb_oui.UseVisualStyleBackColor = true;
            this.cb_oui.CheckedChanged += new System.EventHandler(this.Cb_oui_CheckedChanged);
            // 
            // cb_non
            // 
            this.cb_non.AutoSize = true;
            this.cb_non.Location = new System.Drawing.Point(113, 57);
            this.cb_non.Name = "cb_non";
            this.cb_non.Size = new System.Drawing.Size(44, 17);
            this.cb_non.TabIndex = 4;
            this.cb_non.Text = "non";
            this.cb_non.UseVisualStyleBackColor = true;
            this.cb_non.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "est bio ?";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(15, 34);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(33, 13);
            this.nom.TabIndex = 7;
            this.nom.Text = "nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ajouter un ingrédient :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 212);
            this.listBox1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.tb_nom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_oui);
            this.panel1.Controls.Add(this.cb_non);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(21, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 307);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(21, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 304);
            this.panel2.TabIndex = 20;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(163, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Voir les ingrédients de la recette";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 74);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(145, 212);
            this.listBox2.TabIndex = 19;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ajouter une recette :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "valider";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "nom :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lb_qNecessaire);
            this.panel3.Controls.Add(this.lesQuantite);
            this.panel3.Controls.Add(this.tb_qBiere);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.listBox3);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(448, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 629);
            this.panel3.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(343, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ingrédient sélectionné";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(181, 160);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(282, 212);
            this.listBox3.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Les ingrédients de la recette:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Ingrédient à ajouter:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(306, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Ajouter ingrédient";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 26);
            this.label11.TabIndex = 6;
            this.label11.Text = "quantité en ml pour 1L:\r\n\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Date création :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Recette :";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lb_qNecessaire
            // 
            this.lb_qNecessaire.FormattingEnabled = true;
            this.lb_qNecessaire.Location = new System.Drawing.Point(52, 464);
            this.lb_qNecessaire.Name = "lb_qNecessaire";
            this.lb_qNecessaire.Size = new System.Drawing.Size(224, 121);
            this.lb_qNecessaire.TabIndex = 33;
            // 
            // lesQuantite
            // 
            this.lesQuantite.Location = new System.Drawing.Point(88, 428);
            this.lesQuantite.Name = "lesQuantite";
            this.lesQuantite.Size = new System.Drawing.Size(78, 23);
            this.lesQuantite.TabIndex = 32;
            this.lesQuantite.Text = "Voir Quantite";
            this.lesQuantite.UseVisualStyleBackColor = true;
            this.lesQuantite.Click += new System.EventHandler(this.lesQuantite_Click);
            // 
            // tb_qBiere
            // 
            this.tb_qBiere.Location = new System.Drawing.Point(52, 430);
            this.tb_qBiere.Name = "tb_qBiere";
            this.tb_qBiere.Size = new System.Drawing.Size(29, 20);
            this.tb_qBiere.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 402);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(271, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Quelle est la quantité de bière que vous voulez ? (en ml)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 685);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_oui;
        private System.Windows.Forms.CheckBox cb_non;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lb_qNecessaire;
        private System.Windows.Forms.Button lesQuantite;
        private System.Windows.Forms.TextBox tb_qBiere;
        private System.Windows.Forms.Label label15;
    }
}

