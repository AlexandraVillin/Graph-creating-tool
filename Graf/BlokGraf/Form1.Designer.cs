namespace BlokGraf
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
            System.Windows.Forms.Button BFSstart;
            this.panel1 = new System.Windows.Forms.Panel();
            this.DFSstart = new System.Windows.Forms.Button();
            this.StartNode = new System.Windows.Forms.TextBox();
            this.StartText = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.rbnode = new System.Windows.Forms.RadioButton();
            this.rbedge = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            BFSstart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(BFSstart);
            this.panel1.Controls.Add(this.DFSstart);
            this.panel1.Controls.Add(this.StartNode);
            this.panel1.Controls.Add(this.StartText);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.rbnode);
            this.panel1.Controls.Add(this.rbedge);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 49);
            this.panel1.TabIndex = 0;
            // 
            // BFSstart
            // 
            BFSstart.BackColor = System.Drawing.Color.Transparent;
            BFSstart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            BFSstart.Location = new System.Drawing.Point(514, 14);
            BFSstart.Name = "BFSstart";
            BFSstart.Size = new System.Drawing.Size(75, 20);
            BFSstart.TabIndex = 8;
            BFSstart.Text = "Show BFS";
            BFSstart.UseVisualStyleBackColor = false;
            BFSstart.Click += new System.EventHandler(this.BFSstart_Click_1);
            // 
            // DFSstart
            // 
            this.DFSstart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DFSstart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DFSstart.Location = new System.Drawing.Point(595, 14);
            this.DFSstart.Name = "DFSstart";
            this.DFSstart.Size = new System.Drawing.Size(75, 20);
            this.DFSstart.TabIndex = 7;
            this.DFSstart.Text = "Show DFS";
            this.DFSstart.UseVisualStyleBackColor = true;
            this.DFSstart.Click += new System.EventHandler(this.DFSstart_Click);
            // 
            // StartNode
            // 
            this.StartNode.Location = new System.Drawing.Point(478, 14);
            this.StartNode.Name = "StartNode";
            this.StartNode.Size = new System.Drawing.Size(30, 20);
            this.StartNode.TabIndex = 6;
            // 
            // StartText
            // 
            this.StartText.AutoSize = true;
            this.StartText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartText.Location = new System.Drawing.Point(411, 17);
            this.StartText.Name = "StartText";
            this.StartText.Size = new System.Drawing.Size(61, 13);
            this.StartText.TabIndex = 5;
            this.StartText.Text = "Start Node:";
            this.StartText.Click += new System.EventHandler(this.BFSstart_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdate.Location = new System.Drawing.Point(713, 12);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "Clear";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.ClearSlate);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 14);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(37, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Mode:";
            // 
            // rbnode
            // 
            this.rbnode.AutoSize = true;
            this.rbnode.Checked = true;
            this.rbnode.Location = new System.Drawing.Point(55, 12);
            this.rbnode.Name = "rbnode";
            this.rbnode.Size = new System.Drawing.Size(51, 17);
            this.rbnode.TabIndex = 1;
            this.rbnode.TabStop = true;
            this.rbnode.Text = "Node";
            this.rbnode.UseVisualStyleBackColor = true;
            // 
            // rbedge
            // 
            this.rbedge.AutoSize = true;
            this.rbedge.Location = new System.Drawing.Point(112, 12);
            this.rbedge.Name = "rbedge";
            this.rbedge.Size = new System.Drawing.Size(50, 17);
            this.rbedge.TabIndex = 2;
            this.rbedge.Text = "Edge";
            this.rbedge.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 403);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "GraphCreator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton rbnode;
        private System.Windows.Forms.RadioButton rbedge;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox StartNode;
        private System.Windows.Forms.Label StartText;
        private System.Windows.Forms.Button DFSstart;
    }
}

