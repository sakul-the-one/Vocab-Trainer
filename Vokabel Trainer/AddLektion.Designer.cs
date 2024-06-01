namespace Vokabel_Trainer
{
    public class Vocabulary
    {
        public string Word { get; set; }
        public string Translation { get; set; }
    }
    partial class AddLektion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.translationTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.wordLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.savedLabel = new System.Windows.Forms.Label();
            this.lektionNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 417);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(95, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(371, 34);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(181, 20);
            this.wordTextBox.TabIndex = 2;
            // 
            // translationTextBox
            // 
            this.translationTextBox.Location = new System.Drawing.Point(371, 76);
            this.translationTextBox.Name = "translationTextBox";
            this.translationTextBox.Size = new System.Drawing.Size(181, 20);
            this.translationTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(371, 134);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Vocab";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(581, 40);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(33, 13);
            this.wordLabel.TabIndex = 5;
            this.wordLabel.Text = "Word";
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Location = new System.Drawing.Point(581, 83);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(59, 13);
            this.translationLabel.TabIndex = 6;
            this.translationLabel.Text = "Translation";
            // 
            // savedLabel
            // 
            this.savedLabel.AutoSize = true;
            this.savedLabel.Location = new System.Drawing.Point(13, 15);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(38, 13);
            this.savedLabel.TabIndex = 7;
            this.savedLabel.Text = "Saved";
            // 
            // lektionNameBox
            // 
            this.lektionNameBox.Location = new System.Drawing.Point(82, 12);
            this.lektionNameBox.Name = "lektionNameBox";
            this.lektionNameBox.Size = new System.Drawing.Size(264, 20);
            this.lektionNameBox.TabIndex = 8;
            this.lektionNameBox.Text = "Lektion Name";
            this.lektionNameBox.TextChanged += new System.EventHandler(this.lektionNameBox_TextChanged);
            // 
            // AddLektion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 520);
            this.Controls.Add(this.lektionNameBox);
            this.Controls.Add(this.savedLabel);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.translationTextBox);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddLektion";
            this.Text = "AddLektion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.TextBox translationTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Label savedLabel;
        private System.Windows.Forms.TextBox lektionNameBox;
    }
}