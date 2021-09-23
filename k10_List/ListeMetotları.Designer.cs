namespace k10_List
{
    partial class ListeMetotları
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
            this.btnAvarage = new System.Windows.Forms.Button();
            this.btnConcat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Count = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnSiralama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAvarage
            // 
            this.btnAvarage.Location = new System.Drawing.Point(67, 22);
            this.btnAvarage.Name = "btnAvarage";
            this.btnAvarage.Size = new System.Drawing.Size(121, 37);
            this.btnAvarage.TabIndex = 0;
            this.btnAvarage.Text = "Avarage";
            this.btnAvarage.UseVisualStyleBackColor = true;
            this.btnAvarage.Click += new System.EventHandler(this.btnAvarage_Click);
            // 
            // btnConcat
            // 
            this.btnConcat.Location = new System.Drawing.Point(67, 70);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(121, 37);
            this.btnConcat.TabIndex = 1;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(212, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(67, 118);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(121, 37);
            this.Count.TabIndex = 3;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(67, 166);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(121, 37);
            this.btnContains.TabIndex = 4;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(67, 214);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(121, 37);
            this.btnExist.TabIndex = 5;
            this.btnExist.Text = "Exist";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(67, 262);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(121, 37);
            this.btnFirstOrDefault.TabIndex = 6;
            this.btnFirstOrDefault.Text = "First or Default";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            this.btnFirstOrDefault.Click += new System.EventHandler(this.btnFirstOrDefault_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(67, 310);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(121, 37);
            this.btnWhere.TabIndex = 7;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(67, 358);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(121, 37);
            this.btnMinMax.TabIndex = 8;
            this.btnMinMax.Text = "Min/Max";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnSiralama
            // 
            this.btnSiralama.Location = new System.Drawing.Point(67, 406);
            this.btnSiralama.Name = "btnSiralama";
            this.btnSiralama.Size = new System.Drawing.Size(121, 37);
            this.btnSiralama.TabIndex = 9;
            this.btnSiralama.Text = "Sıralama";
            this.btnSiralama.UseVisualStyleBackColor = true;
            this.btnSiralama.Click += new System.EventHandler(this.btnSiralama_Click);
            // 
            // ListeMetotları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiralama);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnFirstOrDefault);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.btnAvarage);
            this.Name = "ListeMetotları";
            this.Text = "ListeMetotları";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAvarage;
        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnFirstOrDefault;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnSiralama;
    }
}