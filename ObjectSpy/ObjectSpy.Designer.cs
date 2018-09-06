namespace ObjectSpy
{
    partial class objectSpy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(objectSpy));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkFrame = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.frameNameLocator = new System.Windows.Forms.TextBox();
            this.xpathAbsoluteLocator = new System.Windows.Forms.TextBox();
            this.cssPathLocator = new System.Windows.Forms.TextBox();
            this.frameIdLocator = new System.Windows.Forms.TextBox();
            this.linkTextLocator = new System.Windows.Forms.TextBox();
            this.tagNameLocator = new System.Windows.Forms.TextBox();
            this.idLocator = new System.Windows.Forms.TextBox();
            this.xpathRelativeLocator = new System.Windows.Forms.TextBox();
            this.cssSubPathLocator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webSite = new System.Windows.Forms.TextBox();
            this.navigate = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 138);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1008, 592);
            this.webBrowser.TabIndex = 7;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkFrame);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.frameNameLocator);
            this.groupBox1.Controls.Add(this.xpathAbsoluteLocator);
            this.groupBox1.Controls.Add(this.cssPathLocator);
            this.groupBox1.Controls.Add(this.frameIdLocator);
            this.groupBox1.Controls.Add(this.linkTextLocator);
            this.groupBox1.Controls.Add(this.tagNameLocator);
            this.groupBox1.Controls.Add(this.idLocator);
            this.groupBox1.Controls.Add(this.xpathRelativeLocator);
            this.groupBox1.Controls.Add(this.cssSubPathLocator);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebElement Locator";
            // 
            // checkFrame
            // 
            this.checkFrame.AutoSize = true;
            this.checkFrame.Location = new System.Drawing.Point(986, 21);
            this.checkFrame.Name = "checkFrame";
            this.checkFrame.Size = new System.Drawing.Size(15, 14);
            this.checkFrame.TabIndex = 26;
            this.checkFrame.UseVisualStyleBackColor = true;
            this.checkFrame.CheckedChanged += new System.EventHandler(this.checkFrame_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(814, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "-";
            // 
            // frameNameLocator
            // 
            this.frameNameLocator.Location = new System.Drawing.Point(830, 19);
            this.frameNameLocator.Name = "frameNameLocator";
            this.frameNameLocator.Size = new System.Drawing.Size(150, 20);
            this.frameNameLocator.TabIndex = 22;
            // 
            // xpathAbsoluteLocator
            // 
            this.xpathAbsoluteLocator.Location = new System.Drawing.Point(467, 45);
            this.xpathAbsoluteLocator.Name = "xpathAbsoluteLocator";
            this.xpathAbsoluteLocator.Size = new System.Drawing.Size(513, 20);
            this.xpathAbsoluteLocator.TabIndex = 21;
            // 
            // cssPathLocator
            // 
            this.cssPathLocator.Location = new System.Drawing.Point(467, 71);
            this.cssPathLocator.Name = "cssPathLocator";
            this.cssPathLocator.Size = new System.Drawing.Size(513, 20);
            this.cssPathLocator.TabIndex = 20;
            // 
            // frameIdLocator
            // 
            this.frameIdLocator.Location = new System.Drawing.Point(658, 19);
            this.frameIdLocator.Name = "frameIdLocator";
            this.frameIdLocator.Size = new System.Drawing.Size(150, 20);
            this.frameIdLocator.TabIndex = 19;
            // 
            // linkTextLocator
            // 
            this.linkTextLocator.Location = new System.Drawing.Point(408, 19);
            this.linkTextLocator.Name = "linkTextLocator";
            this.linkTextLocator.Size = new System.Drawing.Size(150, 20);
            this.linkTextLocator.TabIndex = 18;
            // 
            // tagNameLocator
            // 
            this.tagNameLocator.Location = new System.Drawing.Point(244, 19);
            this.tagNameLocator.Name = "tagNameLocator";
            this.tagNameLocator.Size = new System.Drawing.Size(100, 20);
            this.tagNameLocator.TabIndex = 17;
            // 
            // idLocator
            // 
            this.idLocator.Location = new System.Drawing.Point(28, 19);
            this.idLocator.Name = "idLocator";
            this.idLocator.Size = new System.Drawing.Size(150, 20);
            this.idLocator.TabIndex = 16;
            // 
            // xpathRelativeLocator
            // 
            this.xpathRelativeLocator.Location = new System.Drawing.Point(141, 45);
            this.xpathRelativeLocator.Name = "xpathRelativeLocator";
            this.xpathRelativeLocator.Size = new System.Drawing.Size(304, 20);
            this.xpathRelativeLocator.TabIndex = 15;
            // 
            // cssSubPathLocator
            // 
            this.cssSubPathLocator.Location = new System.Drawing.Point(141, 71);
            this.cssSubPathLocator.Name = "cssSubPathLocator";
            this.cssSubPathLocator.Size = new System.Drawing.Size(304, 20);
            this.cssSubPathLocator.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Css SubPath - Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Xpath Relative - Absolute:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TagName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "LinkText:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Frame Id - Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Web Site";
            // 
            // webSite
            // 
            this.webSite.Location = new System.Drawing.Point(63, 6);
            this.webSite.Name = "webSite";
            this.webSite.Size = new System.Drawing.Size(625, 20);
            this.webSite.TabIndex = 13;
            // 
            // navigate
            // 
            this.navigate.Location = new System.Drawing.Point(694, 3);
            this.navigate.Name = "navigate";
            this.navigate.Size = new System.Drawing.Size(35, 25);
            this.navigate.TabIndex = 14;
            this.navigate.Text = "Go";
            this.navigate.UseVisualStyleBackColor = true;
            this.navigate.Click += new System.EventHandler(this.navigate_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(735, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(35, 25);
            this.back.TabIndex = 15;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(776, 3);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(35, 25);
            this.forward.TabIndex = 16;
            this.forward.Text = ">";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // objectSpy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.navigate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "objectSpy";
            this.Text = "Object Spy";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.objectSpy_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox webSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button navigate;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox frameNameLocator;
        private System.Windows.Forms.TextBox xpathAbsoluteLocator;
        private System.Windows.Forms.TextBox cssPathLocator;
        private System.Windows.Forms.TextBox frameIdLocator;
        private System.Windows.Forms.TextBox linkTextLocator;
        private System.Windows.Forms.TextBox tagNameLocator;
        private System.Windows.Forms.TextBox idLocator;
        private System.Windows.Forms.TextBox xpathRelativeLocator;
        private System.Windows.Forms.TextBox cssSubPathLocator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkFrame;
    }
}

