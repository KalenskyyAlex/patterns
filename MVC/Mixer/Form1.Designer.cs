
namespace Mixer
{
    partial class View
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
            this.components = new System.ComponentModel.Container();
            this.SetBPMbtn = new System.Windows.Forms.Button();
            this.EnterBPM = new System.Windows.Forms.TextBox();
            this.DecrementBtn = new System.Windows.Forms.Button();
            this.IncrementBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.start = new System.Windows.Forms.ToolStripMenuItem();
            this.stop = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.BeatDisplay = new System.Windows.Forms.ProgressBar();
            this.BPMDisplay = new System.Windows.Forms.Label();
            this.BeatTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetBPMbtn
            // 
            this.SetBPMbtn.Location = new System.Drawing.Point(12, 81);
            this.SetBPMbtn.Name = "SetBPMbtn";
            this.SetBPMbtn.Size = new System.Drawing.Size(92, 23);
            this.SetBPMbtn.TabIndex = 2;
            this.SetBPMbtn.Text = "Set";
            this.SetBPMbtn.UseVisualStyleBackColor = true;
            this.SetBPMbtn.Click += new System.EventHandler(this.setBPM);
            // 
            // EnterBPM
            // 
            this.EnterBPM.Location = new System.Drawing.Point(12, 55);
            this.EnterBPM.Name = "EnterBPM";
            this.EnterBPM.Size = new System.Drawing.Size(92, 20);
            this.EnterBPM.TabIndex = 3;
            // 
            // DecrementBtn
            // 
            this.DecrementBtn.Location = new System.Drawing.Point(12, 110);
            this.DecrementBtn.Name = "DecrementBtn";
            this.DecrementBtn.Size = new System.Drawing.Size(44, 23);
            this.DecrementBtn.TabIndex = 4;
            this.DecrementBtn.Text = "<<";
            this.DecrementBtn.UseVisualStyleBackColor = true;
            this.DecrementBtn.Click += new System.EventHandler(this.DecrementBPM);
            // 
            // IncrementBtn
            // 
            this.IncrementBtn.Location = new System.Drawing.Point(62, 110);
            this.IncrementBtn.Name = "IncrementBtn";
            this.IncrementBtn.Size = new System.Drawing.Size(44, 23);
            this.IncrementBtn.TabIndex = 5;
            this.IncrementBtn.Text = ">>";
            this.IncrementBtn.UseVisualStyleBackColor = true;
            this.IncrementBtn.Click += new System.EventHandler(this.IncrementBPM);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(120, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "safsdf";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start,
            this.stop});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "DJConrol";
            // 
            // start
            // 
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(180, 22);
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.on);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(180, 22);
            this.stop.Text = "Stop";
            this.stop.Click += new System.EventHandler(this.off);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter BPM here";
            // 
            // BeatDisplay
            // 
            this.BeatDisplay.Location = new System.Drawing.Point(10, 193);
            this.BeatDisplay.Name = "BeatDisplay";
            this.BeatDisplay.Size = new System.Drawing.Size(100, 23);
            this.BeatDisplay.TabIndex = 8;
            // 
            // BPMDisplay
            // 
            this.BPMDisplay.AutoSize = true;
            this.BPMDisplay.Location = new System.Drawing.Point(18, 219);
            this.BPMDisplay.Name = "BPMDisplay";
            this.BPMDisplay.Size = new System.Drawing.Size(79, 13);
            this.BPMDisplay.TabIndex = 9;
            this.BPMDisplay.Text = "Current BPM: 0";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 262);
            this.Controls.Add(this.BPMDisplay);
            this.Controls.Add(this.BeatDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncrementBtn);
            this.Controls.Add(this.DecrementBtn);
            this.Controls.Add(this.EnterBPM);
            this.Controls.Add(this.SetBPMbtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "View";
            this.Text = "Control";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SetBPMbtn;
        private System.Windows.Forms.TextBox EnterBPM;
        private System.Windows.Forms.Button DecrementBtn;
        private System.Windows.Forms.Button IncrementBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem start;
        private System.Windows.Forms.ToolStripMenuItem stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar BeatDisplay;
        private System.Windows.Forms.Label BPMDisplay;
        private System.Windows.Forms.Timer BeatTimer;
    }
}

