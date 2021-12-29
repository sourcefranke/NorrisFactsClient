
namespace JokeGEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnjoke = new System.Windows.Forms.Button();
            this.textBoxJoke = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelST = new System.Windows.Forms.Label();
            this.labelJI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCTG = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnjoke
            // 
            this.btnjoke.Location = new System.Drawing.Point(12, 123);
            this.btnjoke.Name = "btnjoke";
            this.btnjoke.Size = new System.Drawing.Size(351, 33);
            this.btnjoke.TabIndex = 0;
            this.btnjoke.Text = "Get New Joke";
            this.btnjoke.UseVisualStyleBackColor = true;
            this.btnjoke.Click += new System.EventHandler(this.btnjoke_Click);
            // 
            // textBoxJoke
            // 
            this.textBoxJoke.Location = new System.Drawing.Point(12, 74);
            this.textBoxJoke.Multiline = true;
            this.textBoxJoke.Name = "textBoxJoke";
            this.textBoxJoke.Size = new System.Drawing.Size(351, 43);
            this.textBoxJoke.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(2, 11);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(117, 11);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(47, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "Joke ID:";
            // 
            // labelST
            // 
            this.labelST.AutoSize = true;
            this.labelST.Location = new System.Drawing.Point(43, 11);
            this.labelST.Name = "labelST";
            this.labelST.Size = new System.Drawing.Size(59, 13);
            this.labelST.TabIndex = 4;
            this.labelST.Text = "labelStatus";
            // 
            // labelJI
            // 
            this.labelJI.AutoSize = true;
            this.labelJI.Location = new System.Drawing.Point(161, 11);
            this.labelJI.Name = "labelJI";
            this.labelJI.Size = new System.Drawing.Size(40, 13);
            this.labelJI.TabIndex = 5;
            this.labelJI.Text = "labelID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categories:";
            // 
            // labelCTG
            // 
            this.labelCTG.AutoSize = true;
            this.labelCTG.Location = new System.Drawing.Point(269, 11);
            this.labelCTG.Name = "labelCTG";
            this.labelCTG.Size = new System.Drawing.Size(79, 13);
            this.labelCTG.TabIndex = 5;
            this.labelCTG.Text = "labelCategories";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelJI);
            this.panel1.Controls.Add(this.labelCTG);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.labelST);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 31);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Joke Infos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JokeGEN.Properties.Resources.d493apq_a426254b_dd9c_445d_9649_2cb9f26613df;
            this.pictureBox1.Location = new System.Drawing.Point(366, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 165);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxJoke);
            this.Controls.Add(this.btnjoke);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chuck Norris Joke Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnjoke;
        private System.Windows.Forms.TextBox textBoxJoke;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelST;
        private System.Windows.Forms.Label labelJI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCTG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

