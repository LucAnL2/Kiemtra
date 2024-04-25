namespace DoAnWin.ChildFormUser
{
    partial class FTopWorker
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowPanelContain = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbLike = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(107)))), ((int)(((byte)(196)))));
            this.guna2Panel1.Controls.Add(this.rbLike);
            this.guna2Panel1.Controls.Add(this.guna2RadioButton1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1274, 53);
            this.guna2Panel1.TabIndex = 0;
            // 
            // flowPanelContain
            // 
            this.flowPanelContain.AutoScroll = true;
            this.flowPanelContain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowPanelContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelContain.Location = new System.Drawing.Point(0, 53);
            this.flowPanelContain.Name = "flowPanelContain";
            this.flowPanelContain.Size = new System.Drawing.Size(1274, 687);
            this.flowPanelContain.TabIndex = 1;
            this.flowPanelContain.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelContain_Paint);
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Location = new System.Drawing.Point(904, 12);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(146, 20);
            this.guna2RadioButton1.TabIndex = 0;
            this.guna2RadioButton1.Text = "guna2RadioButton1";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbLike
            // 
            this.rbLike.AutoSize = true;
            this.rbLike.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLike.CheckedState.BorderThickness = 0;
            this.rbLike.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLike.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbLike.CheckedState.InnerOffset = -4;
            this.rbLike.ForeColor = System.Drawing.Color.White;
            this.rbLike.Location = new System.Drawing.Point(710, 12);
            this.rbLike.Name = "rbLike";
            this.rbLike.Size = new System.Drawing.Size(162, 20);
            this.rbLike.TabIndex = 0;
            this.rbLike.Text = "Top thợ được yêu thích";
            this.rbLike.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbLike.UncheckedState.BorderThickness = 2;
            this.rbLike.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLike.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLike.CheckedChanged += new System.EventHandler(this.rbLike_CheckedChanged);
            // 
            // FTopWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 740);
            this.Controls.Add(this.flowPanelContain);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTopWorker";
            this.Text = "FTopWorker";
            this.Load += new System.EventHandler(this.FTopWorker_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelContain;
        private Guna.UI2.WinForms.Guna2RadioButton rbLike;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
    }
}