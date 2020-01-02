namespace OttoUI
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.recordBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeIn = new System.Windows.Forms.TextBox();
            this.continousBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.rightLegIn = new System.Windows.Forms.TextBox();
            this.rightFeetIn = new System.Windows.Forms.TextBox();
            this.leftLegIn = new System.Windows.Forms.TextBox();
            this.leftFeetIn = new System.Windows.Forms.TextBox();
            this.rightLegLabel = new System.Windows.Forms.Label();
            this.rightFeetLabel = new System.Windows.Forms.Label();
            this.leftLegLabel = new System.Windows.Forms.Label();
            this.leftFeetLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.animationListBox = new System.Windows.Forms.ListBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.restBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.serialOutput = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.animationTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.loadBtn = new System.Windows.Forms.Button();
            this.savedAnimationsList = new System.Windows.Forms.ListBox();
            this.setAnimationNameText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.animationTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1059, 632);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // recordBtn
            // 
            this.recordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordBtn.Location = new System.Drawing.Point(773, 53);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(108, 44);
            this.recordBtn.TabIndex = 13;
            this.recordBtn.Text = "Record";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playBtn.Location = new System.Drawing.Point(773, 3);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(108, 44);
            this.playBtn.TabIndex = 12;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(443, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(104, 50);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "Time";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeIn
            // 
            this.timeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeIn.Location = new System.Drawing.Point(443, 53);
            this.timeIn.Name = "timeIn";
            this.timeIn.Size = new System.Drawing.Size(104, 20);
            this.timeIn.TabIndex = 10;
            // 
            // continousBtn
            // 
            this.continousBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.continousBtn.Location = new System.Drawing.Point(663, 53);
            this.continousBtn.Name = "continousBtn";
            this.continousBtn.Size = new System.Drawing.Size(104, 44);
            this.continousBtn.TabIndex = 9;
            this.continousBtn.Text = "Start Continous Send";
            this.continousBtn.UseVisualStyleBackColor = true;
            this.continousBtn.Click += new System.EventHandler(this.ContinousBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.Location = new System.Drawing.Point(663, 3);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(104, 44);
            this.sendBtn.TabIndex = 8;
            this.sendBtn.Text = "Send To Otto";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // rightLegIn
            // 
            this.rightLegIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightLegIn.Location = new System.Drawing.Point(333, 53);
            this.rightLegIn.Name = "rightLegIn";
            this.rightLegIn.Size = new System.Drawing.Size(104, 20);
            this.rightLegIn.TabIndex = 7;
            // 
            // rightFeetIn
            // 
            this.rightFeetIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightFeetIn.Location = new System.Drawing.Point(223, 53);
            this.rightFeetIn.Name = "rightFeetIn";
            this.rightFeetIn.Size = new System.Drawing.Size(104, 20);
            this.rightFeetIn.TabIndex = 6;
            // 
            // leftLegIn
            // 
            this.leftLegIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftLegIn.Location = new System.Drawing.Point(113, 53);
            this.leftLegIn.Name = "leftLegIn";
            this.leftLegIn.Size = new System.Drawing.Size(104, 20);
            this.leftLegIn.TabIndex = 5;
            // 
            // leftFeetIn
            // 
            this.leftFeetIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftFeetIn.Location = new System.Drawing.Point(3, 53);
            this.leftFeetIn.Name = "leftFeetIn";
            this.leftFeetIn.Size = new System.Drawing.Size(104, 20);
            this.leftFeetIn.TabIndex = 4;
            // 
            // rightLegLabel
            // 
            this.rightLegLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightLegLabel.AutoSize = true;
            this.rightLegLabel.Location = new System.Drawing.Point(333, 0);
            this.rightLegLabel.Name = "rightLegLabel";
            this.rightLegLabel.Size = new System.Drawing.Size(104, 50);
            this.rightLegLabel.TabIndex = 3;
            this.rightLegLabel.Text = "Right Leg";
            this.rightLegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightFeetLabel
            // 
            this.rightFeetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightFeetLabel.AutoSize = true;
            this.rightFeetLabel.Location = new System.Drawing.Point(223, 0);
            this.rightFeetLabel.Name = "rightFeetLabel";
            this.rightFeetLabel.Size = new System.Drawing.Size(104, 50);
            this.rightFeetLabel.TabIndex = 2;
            this.rightFeetLabel.Text = "Right Feet";
            this.rightFeetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftLegLabel
            // 
            this.leftLegLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftLegLabel.AutoSize = true;
            this.leftLegLabel.Location = new System.Drawing.Point(113, 0);
            this.leftLegLabel.Name = "leftLegLabel";
            this.leftLegLabel.Size = new System.Drawing.Size(104, 50);
            this.leftLegLabel.TabIndex = 1;
            this.leftLegLabel.Text = "Left Leg";
            this.leftLegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftFeetLabel
            // 
            this.leftFeetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftFeetLabel.AutoSize = true;
            this.leftFeetLabel.Location = new System.Drawing.Point(3, 0);
            this.leftFeetLabel.Name = "leftFeetLabel";
            this.leftFeetLabel.Size = new System.Drawing.Size(104, 50);
            this.leftFeetLabel.TabIndex = 0;
            this.leftFeetLabel.Text = "Left Feet";
            this.leftFeetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.leftFeetLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.leftLegLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.restBtn, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.rightFeetLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.updateBtn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.rightLegLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.leftFeetIn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.leftLegIn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rightFeetIn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rightLegIn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.timeIn, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.recordBtn, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.playBtn, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.sendBtn, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.continousBtn, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 286);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // animationListBox
            // 
            this.animationListBox.FormattingEnabled = true;
            this.animationListBox.Location = new System.Drawing.Point(665, 3);
            this.animationListBox.Name = "animationListBox";
            this.animationListBox.Size = new System.Drawing.Size(222, 277);
            this.animationListBox.TabIndex = 3;
            this.animationListBox.SelectedIndexChanged += new System.EventHandler(this.AnimationListBox_SelectedIndexChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Location = new System.Drawing.Point(553, 3);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(104, 44);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // restBtn
            // 
            this.restBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restBtn.Location = new System.Drawing.Point(553, 53);
            this.restBtn.Name = "restBtn";
            this.restBtn.Size = new System.Drawing.Size(104, 44);
            this.restBtn.TabIndex = 5;
            this.restBtn.Text = "Reset";
            this.restBtn.UseVisualStyleBackColor = true;
            this.restBtn.Click += new System.EventHandler(this.RestBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.AutoSize = true;
            this.saveBtn.Location = new System.Drawing.Point(3, 29);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(120, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save Animation";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // serialOutput
            // 
            this.serialOutput.Location = new System.Drawing.Point(3, 3);
            this.serialOutput.Name = "serialOutput";
            this.serialOutput.Size = new System.Drawing.Size(656, 277);
            this.serialOutput.TabIndex = 1;
            this.serialOutput.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.serialOutput);
            this.flowLayoutPanel1.Controls.Add(this.animationListBox);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(161, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(895, 563);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // animationTitle
            // 
            this.animationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animationTitle.AutoSize = true;
            this.animationTitle.Location = new System.Drawing.Point(161, 0);
            this.animationTitle.Name = "animationTitle";
            this.animationTitle.Size = new System.Drawing.Size(895, 63);
            this.animationTitle.TabIndex = 9;
            this.animationTitle.Text = "AnimationTitle";
            this.animationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.setAnimationNameText);
            this.flowLayoutPanel2.Controls.Add(this.saveBtn);
            this.flowLayoutPanel2.Controls.Add(this.loadBtn);
            this.flowLayoutPanel2.Controls.Add(this.savedAnimationsList);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 66);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(152, 563);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadBtn.Location = new System.Drawing.Point(3, 58);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(120, 23);
            this.loadBtn.TabIndex = 7;
            this.loadBtn.Text = "Load Animation";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // savedAnimationsList
            // 
            this.savedAnimationsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savedAnimationsList.FormattingEnabled = true;
            this.savedAnimationsList.Location = new System.Drawing.Point(3, 87);
            this.savedAnimationsList.Name = "savedAnimationsList";
            this.savedAnimationsList.Size = new System.Drawing.Size(120, 472);
            this.savedAnimationsList.TabIndex = 8;
            // 
            // setAnimationNameText
            // 
            this.setAnimationNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setAnimationNameText.Location = new System.Drawing.Point(3, 3);
            this.setAnimationNameText.Name = "setAnimationNameText";
            this.setAnimationNameText.Size = new System.Drawing.Size(120, 20);
            this.setAnimationNameText.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 632);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox serialOutput;
        private System.Windows.Forms.ListBox animationListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label leftFeetLabel;
        private System.Windows.Forms.Label leftLegLabel;
        private System.Windows.Forms.Button restBtn;
        private System.Windows.Forms.Label rightFeetLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label rightLegLabel;
        private System.Windows.Forms.TextBox leftFeetIn;
        private System.Windows.Forms.TextBox leftLegIn;
        private System.Windows.Forms.TextBox rightFeetIn;
        private System.Windows.Forms.TextBox rightLegIn;
        private System.Windows.Forms.TextBox timeIn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button continousBtn;
        private System.Windows.Forms.Label animationTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ListBox savedAnimationsList;
        private System.Windows.Forms.TextBox setAnimationNameText;
    }
}

