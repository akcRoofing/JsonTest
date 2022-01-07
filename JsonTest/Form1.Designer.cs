namespace JsonTest
{
    partial class Form1
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
            this.rawJsonGroupBox = new System.Windows.Forms.GroupBox();
            this.txtRawJson = new System.Windows.Forms.TextBox();
            this.cmdDeserialise = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.debugGroupBox = new System.Windows.Forms.GroupBox();
            this.txtDebugOutput = new System.Windows.Forms.TextBox();
            this.rawJsonGroupBox.SuspendLayout();
            this.debugGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rawJsonGroupBox
            // 
            this.rawJsonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawJsonGroupBox.AutoSize = true;
            this.rawJsonGroupBox.Controls.Add(this.txtRawJson);
            this.rawJsonGroupBox.Location = new System.Drawing.Point(12, 12);
            this.rawJsonGroupBox.Name = "rawJsonGroupBox";
            this.rawJsonGroupBox.Size = new System.Drawing.Size(1061, 172);
            this.rawJsonGroupBox.TabIndex = 0;
            this.rawJsonGroupBox.TabStop = false;
            this.rawJsonGroupBox.Text = "Raw Json (Serialised String)";
            // 
            // txtRawJson
            // 
            this.txtRawJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRawJson.Location = new System.Drawing.Point(6, 20);
            this.txtRawJson.Multiline = true;
            this.txtRawJson.Name = "txtRawJson";
            this.txtRawJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRawJson.Size = new System.Drawing.Size(1048, 130);
            this.txtRawJson.TabIndex = 0;
            // 
            // cmdDeserialise
            // 
            this.cmdDeserialise.Location = new System.Drawing.Point(6, 211);
            this.cmdDeserialise.Name = "cmdDeserialise";
            this.cmdDeserialise.Size = new System.Drawing.Size(75, 23);
            this.cmdDeserialise.TabIndex = 1;
            this.cmdDeserialise.Text = "Deserialise";
            this.cmdDeserialise.UseVisualStyleBackColor = true;
            this.cmdDeserialise.Click += new System.EventHandler(this.cmdDeserialise_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(87, 211);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(133, 23);
            this.cmdClear.TabIndex = 2;
            this.cmdClear.Text = "Clear Debug";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // debugGroupBox
            // 
            this.debugGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugGroupBox.AutoSize = true;
            this.debugGroupBox.Controls.Add(this.txtDebugOutput);
            this.debugGroupBox.Location = new System.Drawing.Point(12, 255);
            this.debugGroupBox.Name = "debugGroupBox";
            this.debugGroupBox.Size = new System.Drawing.Size(1061, 173);
            this.debugGroupBox.TabIndex = 3;
            this.debugGroupBox.TabStop = false;
            this.debugGroupBox.Text = "Debug Output";
            // 
            // txtDebugOutput
            // 
            this.txtDebugOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebugOutput.Location = new System.Drawing.Point(6, 21);
            this.txtDebugOutput.Multiline = true;
            this.txtDebugOutput.Name = "txtDebugOutput";
            this.txtDebugOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebugOutput.Size = new System.Drawing.Size(1048, 130);
            this.txtDebugOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 426);
            this.Controls.Add(this.debugGroupBox);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdDeserialise);
            this.Controls.Add(this.rawJsonGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Json Parser";
            this.rawJsonGroupBox.ResumeLayout(false);
            this.rawJsonGroupBox.PerformLayout();
            this.debugGroupBox.ResumeLayout(false);
            this.debugGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox rawJsonGroupBox;
        private Button cmdDeserialise;
        private Button cmdClear;
        private GroupBox debugGroupBox;
        private TextBox txtRawJson;
        private TextBox txtDebugOutput;
    }
}