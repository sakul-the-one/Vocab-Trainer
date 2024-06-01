namespace Vokabel_Trainer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddLektion = new System.Windows.Forms.Button();
            this.editLektionButton = new System.Windows.Forms.Button();
            this.StartingPoint = new System.Windows.Forms.GroupBox();
            this.LektionAbfrage = new System.Windows.Forms.GroupBox();
            this.left = new System.Windows.Forms.Label();
            this.AAlltrys = new System.Windows.Forms.Label();
            this.AFalschLabel = new System.Windows.Forms.Label();
            this.ARichtigLabel = new System.Windows.Forms.Label();
            this.AVocabLabel = new System.Windows.Forms.Label();
            this.ANext = new System.Windows.Forms.Button();
            this.Abutton4 = new System.Windows.Forms.Button();
            this.Abutton3 = new System.Windows.Forms.Button();
            this.Abutton2 = new System.Windows.Forms.Button();
            this.Abutton1 = new System.Windows.Forms.Button();
            this.StartingPoint.SuspendLayout();
            this.LektionAbfrage.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vokabel Lektion lernen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(-3, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Console";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddLektion
            // 
            this.AddLektion.Location = new System.Drawing.Point(137, 50);
            this.AddLektion.Name = "AddLektion";
            this.AddLektion.Size = new System.Drawing.Size(110, 23);
            this.AddLektion.TabIndex = 3;
            this.AddLektion.Text = "Füge Lektion hinzu";
            this.AddLektion.UseVisualStyleBackColor = true;
            this.AddLektion.Click += new System.EventHandler(this.AddLektion_Click);
            // 
            // editLektionButton
            // 
            this.editLektionButton.Location = new System.Drawing.Point(253, 50);
            this.editLektionButton.Name = "editLektionButton";
            this.editLektionButton.Size = new System.Drawing.Size(87, 23);
            this.editLektionButton.TabIndex = 4;
            this.editLektionButton.Text = "Edit Lektion";
            this.editLektionButton.UseVisualStyleBackColor = true;
            this.editLektionButton.Click += new System.EventHandler(this.editLektionButton_Click);
            // 
            // StartingPoint
            // 
            this.StartingPoint.Controls.Add(this.comboBox1);
            this.StartingPoint.Controls.Add(this.editLektionButton);
            this.StartingPoint.Controls.Add(this.button1);
            this.StartingPoint.Controls.Add(this.AddLektion);
            this.StartingPoint.Location = new System.Drawing.Point(12, 12);
            this.StartingPoint.Name = "StartingPoint";
            this.StartingPoint.Size = new System.Drawing.Size(344, 88);
            this.StartingPoint.TabIndex = 5;
            this.StartingPoint.TabStop = false;
            // 
            // LektionAbfrage
            // 
            this.LektionAbfrage.Controls.Add(this.left);
            this.LektionAbfrage.Controls.Add(this.AAlltrys);
            this.LektionAbfrage.Controls.Add(this.AFalschLabel);
            this.LektionAbfrage.Controls.Add(this.ARichtigLabel);
            this.LektionAbfrage.Controls.Add(this.AVocabLabel);
            this.LektionAbfrage.Controls.Add(this.ANext);
            this.LektionAbfrage.Controls.Add(this.Abutton4);
            this.LektionAbfrage.Controls.Add(this.Abutton3);
            this.LektionAbfrage.Controls.Add(this.Abutton2);
            this.LektionAbfrage.Controls.Add(this.Abutton1);
            this.LektionAbfrage.Location = new System.Drawing.Point(18, 106);
            this.LektionAbfrage.Name = "LektionAbfrage";
            this.LektionAbfrage.Size = new System.Drawing.Size(334, 282);
            this.LektionAbfrage.TabIndex = 6;
            this.LektionAbfrage.TabStop = false;
            this.LektionAbfrage.Text = "Abfrage";
            this.LektionAbfrage.Visible = false;
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Location = new System.Drawing.Point(9, 220);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(63, 13);
            this.left.TabIndex = 9;
            this.left.Text = "Vocabs left:";
            // 
            // AAlltrys
            // 
            this.AAlltrys.AutoSize = true;
            this.AAlltrys.Location = new System.Drawing.Point(250, 263);
            this.AAlltrys.Name = "AAlltrys";
            this.AAlltrys.Size = new System.Drawing.Size(35, 13);
            this.AAlltrys.TabIndex = 8;
            this.AAlltrys.Text = "label1";
            // 
            // AFalschLabel
            // 
            this.AFalschLabel.AutoSize = true;
            this.AFalschLabel.Location = new System.Drawing.Point(9, 263);
            this.AFalschLabel.Name = "AFalschLabel";
            this.AFalschLabel.Size = new System.Drawing.Size(45, 13);
            this.AFalschLabel.TabIndex = 7;
            this.AFalschLabel.Text = "AFalsch";
            // 
            // ARichtigLabel
            // 
            this.ARichtigLabel.AutoSize = true;
            this.ARichtigLabel.Location = new System.Drawing.Point(9, 241);
            this.ARichtigLabel.Name = "ARichtigLabel";
            this.ARichtigLabel.Size = new System.Drawing.Size(40, 13);
            this.ARichtigLabel.TabIndex = 6;
            this.ARichtigLabel.Text = "Richtig";
            // 
            // AVocabLabel
            // 
            this.AVocabLabel.AutoSize = true;
            this.AVocabLabel.Location = new System.Drawing.Point(6, 37);
            this.AVocabLabel.Name = "AVocabLabel";
            this.AVocabLabel.Size = new System.Drawing.Size(35, 13);
            this.AVocabLabel.TabIndex = 5;
            this.AVocabLabel.Text = "label1";
            // 
            // ANext
            // 
            this.ANext.Location = new System.Drawing.Point(253, 210);
            this.ANext.Name = "ANext";
            this.ANext.Size = new System.Drawing.Size(75, 23);
            this.ANext.TabIndex = 4;
            this.ANext.Text = "Next";
            this.ANext.UseVisualStyleBackColor = true;
            this.ANext.Click += new System.EventHandler(this.ANext_Click);
            // 
            // Abutton4
            // 
            this.Abutton4.Location = new System.Drawing.Point(6, 140);
            this.Abutton4.Name = "Abutton4";
            this.Abutton4.Size = new System.Drawing.Size(322, 23);
            this.Abutton4.TabIndex = 3;
            this.Abutton4.Text = "button6";
            this.Abutton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abutton4.UseVisualStyleBackColor = true;
            this.Abutton4.Click += new System.EventHandler(this.SoulutionButtonClicked);
            // 
            // Abutton3
            // 
            this.Abutton3.Location = new System.Drawing.Point(6, 111);
            this.Abutton3.Name = "Abutton3";
            this.Abutton3.Size = new System.Drawing.Size(322, 23);
            this.Abutton3.TabIndex = 2;
            this.Abutton3.Text = "button5";
            this.Abutton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abutton3.UseVisualStyleBackColor = true;
            this.Abutton3.Click += new System.EventHandler(this.SoulutionButtonClicked);
            // 
            // Abutton2
            // 
            this.Abutton2.Location = new System.Drawing.Point(6, 82);
            this.Abutton2.Name = "Abutton2";
            this.Abutton2.Size = new System.Drawing.Size(322, 23);
            this.Abutton2.TabIndex = 1;
            this.Abutton2.Text = "button4";
            this.Abutton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abutton2.UseVisualStyleBackColor = true;
            this.Abutton2.Click += new System.EventHandler(this.SoulutionButtonClicked);
            // 
            // Abutton1
            // 
            this.Abutton1.Location = new System.Drawing.Point(6, 53);
            this.Abutton1.Name = "Abutton1";
            this.Abutton1.Size = new System.Drawing.Size(322, 23);
            this.Abutton1.TabIndex = 0;
            this.Abutton1.Text = "button3";
            this.Abutton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abutton1.UseVisualStyleBackColor = true;
            this.Abutton1.Click += new System.EventHandler(this.SoulutionButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 624);
            this.Controls.Add(this.LektionAbfrage);
            this.Controls.Add(this.StartingPoint);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StartingPoint.ResumeLayout(false);
            this.LektionAbfrage.ResumeLayout(false);
            this.LektionAbfrage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddLektion;
        private System.Windows.Forms.Button editLektionButton;
        private System.Windows.Forms.GroupBox StartingPoint;
        private System.Windows.Forms.GroupBox LektionAbfrage;
        private System.Windows.Forms.Button ANext;
        private System.Windows.Forms.Button Abutton4;
        private System.Windows.Forms.Button Abutton3;
        private System.Windows.Forms.Button Abutton2;
        private System.Windows.Forms.Button Abutton1;
        private System.Windows.Forms.Label AVocabLabel;
        private System.Windows.Forms.Label AFalschLabel;
        private System.Windows.Forms.Label ARichtigLabel;
        private System.Windows.Forms.Label AAlltrys;
        private System.Windows.Forms.Label left;
    }
}

