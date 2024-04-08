
namespace NorrisFacts
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
            this.textboxJoke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.urlLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnjoke
            // 
            this.btnjoke.Location = new System.Drawing.Point(12, 101);
            this.btnjoke.Name = "btnjoke";
            this.btnjoke.Size = new System.Drawing.Size(351, 33);
            this.btnjoke.TabIndex = 0;
            this.btnjoke.Text = "get random fact";
            this.btnjoke.UseVisualStyleBackColor = true;
            this.btnjoke.Click += new System.EventHandler(this.btnjoke_Click);
            // 
            // textboxJoke
            // 
            this.textboxJoke.Location = new System.Drawing.Point(12, 52);
            this.textboxJoke.Multiline = true;
            this.textboxJoke.Name = "textboxJoke";
            this.textboxJoke.Size = new System.Drawing.Size(351, 43);
            this.textboxJoke.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categories:";
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(69, 11);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(79, 13);
            this.categoriesLabel.TabIndex = 5;
            this.categoriesLabel.Text = "labelCategories";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categoriesLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 34);
            this.panel1.TabIndex = 6;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 146);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(18, 13);
            this.urlLabel.TabIndex = 7;
            this.urlLabel.TabStop = true;
            this.urlLabel.Text = "url";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 190);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textboxJoke);
            this.Controls.Add(this.btnjoke);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chuck Norris Facts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnjoke;
        private System.Windows.Forms.TextBox textboxJoke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel urlLabel;
    }
}

