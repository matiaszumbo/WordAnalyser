namespace WordAnalyzer
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
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_parrafo = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(64, 226);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(440, 379);
            this.txt_result.TabIndex = 0;
            // 
            // txt_parrafo
            // 
            this.txt_parrafo.Location = new System.Drawing.Point(64, 12);
            this.txt_parrafo.Multiline = true;
            this.txt_parrafo.Name = "txt_parrafo";
            this.txt_parrafo.Size = new System.Drawing.Size(440, 179);
            this.txt_parrafo.TabIndex = 1;
            this.txt_parrafo.Text = resources.GetString("txt_parrafo.Text");
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(550, 205);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 636);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_parrafo);
            this.Controls.Add(this.txt_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_parrafo;
        private System.Windows.Forms.Button btn_start;
    }
}

