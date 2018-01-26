namespace P3
{
    partial class researchForm
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
            this.label_research = new System.Windows.Forms.Label();
            this.label_research_title = new System.Windows.Forms.Label();
            this.label_citations = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_research
            // 
            this.label_research.AutoSize = true;
            this.label_research.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_research.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_research.Location = new System.Drawing.Point(53, 56);
            this.label_research.Name = "label_research";
            this.label_research.Size = new System.Drawing.Size(271, 22);
            this.label_research.TabIndex = 0;
            this.label_research.Text = "Research By Domain Area:";
            // 
            // label_research_title
            // 
            this.label_research_title.AutoSize = true;
            this.label_research_title.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_research_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_research_title.Location = new System.Drawing.Point(382, 56);
            this.label_research_title.Name = "label_research_title";
            this.label_research_title.Size = new System.Drawing.Size(60, 21);
            this.label_research_title.TabIndex = 1;
            this.label_research_title.Text = "label2";
            // 
            // label_citations
            // 
            this.label_citations.Location = new System.Drawing.Point(57, 124);
            this.label_citations.Name = "label_citations";
            this.label_citations.Size = new System.Drawing.Size(874, 333);
            this.label_citations.TabIndex = 2;
            this.label_citations.Text = "";
            // 
            // researchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(953, 616);
            this.Controls.Add(this.label_citations);
            this.Controls.Add(this.label_research_title);
            this.Controls.Add(this.label_research);
            this.Name = "researchForm";
            this.Text = "researchForm";
            this.Load += new System.EventHandler(this.researchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_research;
        private System.Windows.Forms.Label label_research_title;
        private System.Windows.Forms.RichTextBox label_citations;
    }
}