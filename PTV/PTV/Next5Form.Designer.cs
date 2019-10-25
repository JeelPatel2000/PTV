using System.Windows.Forms;

namespace PTV
{
    partial class Next5Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.stopSearchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchResultListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search for Stop";
            // 
            // stopSearchBox
            // 
            this.stopSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stopSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stopSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopSearchBox.Location = new System.Drawing.Point(258, 34);
            this.stopSearchBox.Name = "stopSearchBox";
            this.stopSearchBox.Size = new System.Drawing.Size(388, 41);
            this.stopSearchBox.TabIndex = 1;
            this.stopSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StopSearchBox_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(48, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 348);
            this.panel1.TabIndex = 3;
            // 
            // searchResultListPanel
            // 
            this.searchResultListPanel.Location = new System.Drawing.Point(257, 75);
            this.searchResultListPanel.Name = "searchResultListPanel";
            this.searchResultListPanel.Size = new System.Drawing.Size(389, 17);
            this.searchResultListPanel.TabIndex = 4;
            // 
            // Next5Form
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 501);
            this.Controls.Add(this.searchResultListPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stopSearchBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Next5Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stopSearchBox;
        private Panel panel1;
        private Panel searchResultListPanel;
    }


}
