namespace Oasis_Launcher
{
    partial class launcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(launcher));
            bypassButton = new Button();
            revertButton = new Button();
            githubButton = new LinkLabel();
            launchButton = new Button();
            label1 = new Label();
            pathTextbox = new TextBox();
            pathButton = new Button();
            SuspendLayout();
            // 
            // bypassButton
            // 
            bypassButton.Location = new Point(63, 91);
            bypassButton.Name = "bypassButton";
            bypassButton.Size = new Size(154, 39);
            bypassButton.TabIndex = 0;
            bypassButton.Text = "Bypass Steam update";
            bypassButton.UseVisualStyleBackColor = true;
            bypassButton.Click += button1_Click;
            // 
            // revertButton
            // 
            revertButton.Location = new Point(223, 91);
            revertButton.Name = "revertButton";
            revertButton.Size = new Size(152, 39);
            revertButton.TabIndex = 2;
            revertButton.Text = "Revert update bypass";
            revertButton.UseVisualStyleBackColor = true;
            revertButton.Click += button2_Click;
            // 
            // githubButton
            // 
            githubButton.AutoSize = true;
            githubButton.Location = new Point(378, 206);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(45, 15);
            githubButton.TabIndex = 3;
            githubButton.TabStop = true;
            githubButton.Text = "GitHub";
            githubButton.LinkClicked += linkLabel1_LinkClicked;
            // 
            // launchButton
            // 
            launchButton.Location = new Point(63, 46);
            launchButton.Name = "launchButton";
            launchButton.Size = new Size(312, 39);
            launchButton.TabIndex = 4;
            launchButton.Text = "Launch";
            launchButton.UseVisualStyleBackColor = true;
            launchButton.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 206);
            label1.Name = "label1";
            label1.Size = new Size(144, 13);
            label1.TabIndex = 1;
            label1.Text = "Oasis Launcher - Build v1.0";
            // 
            // pathTextbox
            // 
            pathTextbox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pathTextbox.Location = new Point(63, 136);
            pathTextbox.Multiline = true;
            pathTextbox.Name = "pathTextbox";
            pathTextbox.Size = new Size(215, 28);
            pathTextbox.TabIndex = 5;
            // 
            // pathButton
            // 
            pathButton.Location = new Point(284, 136);
            pathButton.Name = "pathButton";
            pathButton.Size = new Size(91, 28);
            pathButton.TabIndex = 6;
            pathButton.Text = "Set game path";
            pathButton.UseVisualStyleBackColor = true;
            pathButton.Click += button4_Click;
            // 
            // launcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(435, 230);
            Controls.Add(pathButton);
            Controls.Add(pathTextbox);
            Controls.Add(launchButton);
            Controls.Add(githubButton);
            Controls.Add(revertButton);
            Controls.Add(label1);
            Controls.Add(bypassButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "launcher";
            Text = "Oasis Launcher";
            Load += launcher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bypassButton;
        private Button revertButton;
        private LinkLabel githubButton;
        private Button launchButton;
        private Label label1;
        private TextBox pathTextbox;
        private Button pathButton;
    }
}
