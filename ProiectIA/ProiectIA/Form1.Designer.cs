namespace ProiectIA
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.meniu_navigatie = new System.Windows.Forms.PictureBox();
            this.buton_nav_1 = new System.Windows.Forms.Button();
            this.buton_nav_2 = new System.Windows.Forms.Button();
            this.buton_nav_3 = new System.Windows.Forms.Button();
            this.buton_nav_4 = new System.Windows.Forms.Button();
            this.buton_nav_5 = new System.Windows.Forms.Button();
            this.buton_nav_6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titlu_logare = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.parola_label = new System.Windows.Forms.Label();
            this.parola = new System.Windows.Forms.TextBox();
            this.buton_logare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.masterDataSet = new ProiectIA.masterDataSet();
            this.museuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.museuTableAdapter = new ProiectIA.masterDataSetTableAdapters.MuseuTableAdapter();
            this.masterDataSet1 = new ProiectIA.masterDataSet1();
            this.museuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.museuTableAdapter1 = new ProiectIA.masterDataSet1TableAdapters.MuseuTableAdapter();
            this.listview = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.meniu_navigatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.museuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.museuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // meniu_navigatie
            // 
            this.meniu_navigatie.BackgroundImage = global::ProiectIA.Properties.Resources.bara_nav;
            this.meniu_navigatie.Enabled = false;
            this.meniu_navigatie.Location = new System.Drawing.Point(-1, 0);
            this.meniu_navigatie.Name = "meniu_navigatie";
            this.meniu_navigatie.Size = new System.Drawing.Size(140, 451);
            this.meniu_navigatie.TabIndex = 0;
            this.meniu_navigatie.TabStop = false;
            // 
            // buton_nav_1
            // 
            this.buton_nav_1.Location = new System.Drawing.Point(12, 144);
            this.buton_nav_1.Name = "buton_nav_1";
            this.buton_nav_1.Size = new System.Drawing.Size(118, 23);
            this.buton_nav_1.TabIndex = 1;
            this.buton_nav_1.Text = "Listare Muzee";
            this.buton_nav_1.UseVisualStyleBackColor = true;
            this.buton_nav_1.Click += new System.EventHandler(this.buton_nav_1_Click);
            // 
            // buton_nav_2
            // 
            this.buton_nav_2.Location = new System.Drawing.Point(12, 173);
            this.buton_nav_2.Name = "buton_nav_2";
            this.buton_nav_2.Size = new System.Drawing.Size(118, 23);
            this.buton_nav_2.TabIndex = 2;
            this.buton_nav_2.Text = "Adaugare Muzee";
            this.buton_nav_2.UseVisualStyleBackColor = true;
            this.buton_nav_2.Click += new System.EventHandler(this.buton_nav_2_Click);
            // 
            // buton_nav_3
            // 
            this.buton_nav_3.Location = new System.Drawing.Point(12, 202);
            this.buton_nav_3.Name = "buton_nav_3";
            this.buton_nav_3.Size = new System.Drawing.Size(118, 23);
            this.buton_nav_3.TabIndex = 3;
            this.buton_nav_3.Text = "Login";
            this.buton_nav_3.UseVisualStyleBackColor = true;
            this.buton_nav_3.Click += new System.EventHandler(this.buton_nav_3_Click);
            // 
            // buton_nav_4
            // 
            this.buton_nav_4.Location = new System.Drawing.Point(12, 231);
            this.buton_nav_4.Name = "buton_nav_4";
            this.buton_nav_4.Size = new System.Drawing.Size(118, 23);
            this.buton_nav_4.TabIndex = 4;
            this.buton_nav_4.Text = "Inregistrare";
            this.buton_nav_4.UseVisualStyleBackColor = true;
            this.buton_nav_4.Click += new System.EventHandler(this.buton_nav_4_Click);
            // 
            // buton_nav_5
            // 
            this.buton_nav_5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buton_nav_5.BackgroundImage = global::ProiectIA.Properties.Resources.buton_bara;
            this.buton_nav_5.FlatAppearance.BorderSize = 0;
            this.buton_nav_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_nav_5.Location = new System.Drawing.Point(12, 12);
            this.buton_nav_5.Name = "buton_nav_5";
            this.buton_nav_5.Size = new System.Drawing.Size(62, 47);
            this.buton_nav_5.TabIndex = 5;
            this.buton_nav_5.Text = "button1";
            this.buton_nav_5.UseVisualStyleBackColor = false;
            this.buton_nav_5.Click += new System.EventHandler(this.buton_nav_5_Click);
            // 
            // buton_nav_6
            // 
            this.buton_nav_6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buton_nav_6.BackgroundImage = global::ProiectIA.Properties.Resources.inchide_Bara;
            this.buton_nav_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_nav_6.Location = new System.Drawing.Point(98, 372);
            this.buton_nav_6.Name = "buton_nav_6";
            this.buton_nav_6.Size = new System.Drawing.Size(32, 50);
            this.buton_nav_6.TabIndex = 6;
            this.buton_nav_6.UseVisualStyleBackColor = false;
            this.buton_nav_6.Click += new System.EventHandler(this.buton_nav_6_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(336, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titlu_logare
            // 
            this.titlu_logare.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.titlu_logare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titlu_logare.Font = new System.Drawing.Font("MingLiU-ExtB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu_logare.Location = new System.Drawing.Point(317, 9);
            this.titlu_logare.Name = "titlu_logare";
            this.titlu_logare.Size = new System.Drawing.Size(165, 33);
            this.titlu_logare.TabIndex = 8;
            this.titlu_logare.Text = "Logare";
            this.titlu_logare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(416, 109);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(160, 20);
            this.username.TabIndex = 9;
            // 
            // username_label
            // 
            this.username_label.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.username_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.username_label.Font = new System.Drawing.Font("MingLiU-ExtB", 15F);
            this.username_label.Location = new System.Drawing.Point(276, 109);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(96, 20);
            this.username_label.TabIndex = 10;
            this.username_label.Text = "Username";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.username_label.UseCompatibleTextRendering = true;
            // 
            // parola_label
            // 
            this.parola_label.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.parola_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parola_label.Font = new System.Drawing.Font("MingLiU-ExtB", 15F);
            this.parola_label.Location = new System.Drawing.Point(276, 157);
            this.parola_label.Name = "parola_label";
            this.parola_label.Size = new System.Drawing.Size(96, 20);
            this.parola_label.TabIndex = 12;
            this.parola_label.Text = "Parola";
            this.parola_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.parola_label.UseCompatibleTextRendering = true;
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(416, 157);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(160, 20);
            this.parola.TabIndex = 11;
            this.parola.UseSystemPasswordChar = true;
            // 
            // buton_logare
            // 
            this.buton_logare.Location = new System.Drawing.Point(350, 230);
            this.buton_logare.Name = "buton_logare";
            this.buton_logare.Size = new System.Drawing.Size(132, 23);
            this.buton_logare.TabIndex = 13;
            this.buton_logare.Text = "Login";
            this.buton_logare.UseVisualStyleBackColor = true;
            this.buton_logare.Click += new System.EventHandler(this.buton_logare_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 52);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buna, %username%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // museuBindingSource
            // 
            this.museuBindingSource.DataMember = "Museu";
            this.museuBindingSource.DataSource = this.masterDataSet;
            // 
            // museuTableAdapter
            // 
            this.museuTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet1";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // museuBindingSource1
            // 
            this.museuBindingSource1.DataMember = "Museu";
            this.museuBindingSource1.DataSource = this.masterDataSet1;
            // 
            // museuTableAdapter1
            // 
            this.museuTableAdapter1.ClearBeforeFill = true;
            // 
            // listview
            // 
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(322, 231);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(529, 279);
            this.listview.TabIndex = 16;
            this.listview.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIA.Properties.Resources.muzee;
            this.ClientSize = new System.Drawing.Size(769, 434);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buton_logare);
            this.Controls.Add(this.parola_label);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username);
            this.Controls.Add(this.titlu_logare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buton_nav_6);
            this.Controls.Add(this.buton_nav_5);
            this.Controls.Add(this.buton_nav_4);
            this.Controls.Add(this.buton_nav_3);
            this.Controls.Add(this.buton_nav_2);
            this.Controls.Add(this.buton_nav_1);
            this.Controls.Add(this.meniu_navigatie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meniu_navigatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.museuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.museuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox meniu_navigatie;
        private System.Windows.Forms.Button buton_nav_1;
        private System.Windows.Forms.Button buton_nav_2;
        private System.Windows.Forms.Button buton_nav_3;
        private System.Windows.Forms.Button buton_nav_4;
        private System.Windows.Forms.Button buton_nav_5;
        private System.Windows.Forms.Button buton_nav_6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titlu_logare;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label parola_label;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Button buton_logare;
        private System.Windows.Forms.Label label2;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource museuBindingSource;
        private masterDataSetTableAdapters.MuseuTableAdapter museuTableAdapter;
        private masterDataSet1 masterDataSet1;
        private System.Windows.Forms.BindingSource museuBindingSource1;
        private masterDataSet1TableAdapters.MuseuTableAdapter museuTableAdapter1;
        private System.Windows.Forms.ListView listview;
    }
}

