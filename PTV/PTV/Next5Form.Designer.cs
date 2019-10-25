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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Next5Form));
            this.label2 = new System.Windows.Forms.Label();
            this.stopSearchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchResultListPanel = new System.Windows.Forms.Panel();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.towardsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Controls.Add(this.resultPanel);
            this.panel1.Location = new System.Drawing.Point(48, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 402);
            this.panel1.TabIndex = 3;
            // 
            // searchResultListPanel
            // 
            this.searchResultListPanel.Location = new System.Drawing.Point(257, 75);
            this.searchResultListPanel.Name = "searchResultListPanel";
            this.searchResultListPanel.Size = new System.Drawing.Size(389, 17);
            this.searchResultListPanel.TabIndex = 4;
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultPanel.Controls.Add(this.platformLabel);
            this.resultPanel.Controls.Add(this.timeLabel);
            this.resultPanel.Controls.Add(this.towardsLabel);
            this.resultPanel.Controls.Add(this.pictureBox1);
            this.resultPanel.Location = new System.Drawing.Point(10, 12);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(693, 115);
            this.resultPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // towardsLabel
            // 
            this.towardsLabel.AutoSize = true;
            this.towardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.towardsLabel.Location = new System.Drawing.Point(141, 12);
            this.towardsLabel.Name = "towardsLabel";
            this.towardsLabel.Size = new System.Drawing.Size(272, 25);
            this.towardsLabel.TabIndex = 1;
            this.towardsLabel.Text = "Towards City (Flinders Street)";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(141, 47);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(272, 25);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Towards City (Flinders Street)";
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.Location = new System.Drawing.Point(141, 82);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(272, 25);
            this.platformLabel.TabIndex = 3;
            this.platformLabel.Text = "Towards City (Flinders Street)";
            // 
            // Next5Form
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 596);
            this.Controls.Add(this.searchResultListPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stopSearchBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Next5Form";
            this.panel1.ResumeLayout(false);
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stopSearchBox;
        private Panel panel1;
        private Panel searchResultListPanel;
        private Panel resultPanel;
        private PictureBox pictureBox1;
        private Label platformLabel;
        private Label timeLabel;
        private Label towardsLabel;
    }


}
