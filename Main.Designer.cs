namespace CareerGuidance
{
    partial class Main
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.treeViewDecisionTree = new System.Windows.Forms.TreeView();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRestart.Location = new System.Drawing.Point(1095, 314);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(163, 51);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "ReStart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(504, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 53);
            this.label2.TabIndex = 90;
            this.label2.Text = "So, Here You Go!!!";
            // 
            // treeViewDecisionTree
            // 
            this.treeViewDecisionTree.Location = new System.Drawing.Point(69, 119);
            this.treeViewDecisionTree.Name = "treeViewDecisionTree";
            this.treeViewDecisionTree.Size = new System.Drawing.Size(406, 220);
            this.treeViewDecisionTree.TabIndex = 91;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.White;
            this.lblQuestion.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Red;
            this.lblQuestion.Location = new System.Drawing.Point(587, 213);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(155, 53);
            this.lblQuestion.TabIndex = 92;
            this.lblQuestion.Text = "label1";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNo.Location = new System.Drawing.Point(860, 314);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(163, 51);
            this.btnNo.TabIndex = 93;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.OrangeRed;
            this.btnYes.Location = new System.Drawing.Point(643, 314);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(163, 51);
            this.btnYes.TabIndex = 94;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(50, 412);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(1335, 280);
            this.panelGraph.TabIndex = 95;
            this.panelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CareerGuidance.Properties.Resources.images__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1416, 704);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.treeViewDecisionTree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRestart);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeViewDecisionTree;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Panel panelGraph;
    }
}