namespace Sudoku
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.lblMusic = new System.Windows.Forms.Label();
            this.rbtnNone = new System.Windows.Forms.RadioButton();
            this.rbtnSimple = new System.Windows.Forms.RadioButton();
            this.rbtnPou = new System.Windows.Forms.RadioButton();
            this.rbtnMaid = new System.Windows.Forms.RadioButton();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbYes = new System.Windows.Forms.CheckBox();
            this.cbNo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.BackColor = System.Drawing.Color.Wheat;
            this.lblMusic.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.Location = new System.Drawing.Point(43, 215);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(83, 26);
            this.lblMusic.TabIndex = 0;
            this.lblMusic.Text = "Music:";
            // 
            // rbtnNone
            // 
            this.rbtnNone.AutoSize = true;
            this.rbtnNone.BackColor = System.Drawing.Color.Wheat;
            this.rbtnNone.Checked = true;
            this.rbtnNone.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNone.Location = new System.Drawing.Point(157, 215);
            this.rbtnNone.Name = "rbtnNone";
            this.rbtnNone.Size = new System.Drawing.Size(60, 21);
            this.rbtnNone.TabIndex = 1;
            this.rbtnNone.TabStop = true;
            this.rbtnNone.Text = "None";
            this.rbtnNone.UseVisualStyleBackColor = false;
            // 
            // rbtnSimple
            // 
            this.rbtnSimple.AutoSize = true;
            this.rbtnSimple.BackColor = System.Drawing.Color.Wheat;
            this.rbtnSimple.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSimple.Location = new System.Drawing.Point(157, 242);
            this.rbtnSimple.Name = "rbtnSimple";
            this.rbtnSimple.Size = new System.Drawing.Size(111, 21);
            this.rbtnSimple.TabIndex = 3;
            this.rbtnSimple.Text = "Simple Music";
            this.rbtnSimple.UseVisualStyleBackColor = false;
            // 
            // rbtnPou
            // 
            this.rbtnPou.AutoSize = true;
            this.rbtnPou.BackColor = System.Drawing.Color.Wheat;
            this.rbtnPou.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPou.Location = new System.Drawing.Point(157, 269);
            this.rbtnPou.Name = "rbtnPou";
            this.rbtnPou.Size = new System.Drawing.Size(127, 21);
            this.rbtnPou.TabIndex = 4;
            this.rbtnPou.Text = "Pou Soundtrack";
            this.rbtnPou.UseVisualStyleBackColor = false;
            // 
            // rbtnMaid
            // 
            this.rbtnMaid.AutoSize = true;
            this.rbtnMaid.BackColor = System.Drawing.Color.Wheat;
            this.rbtnMaid.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMaid.Location = new System.Drawing.Point(157, 296);
            this.rbtnMaid.Name = "rbtnMaid";
            this.rbtnMaid.Size = new System.Drawing.Size(59, 21);
            this.rbtnMaid.TabIndex = 5;
            this.rbtnMaid.Text = "Maid";
            this.rbtnMaid.UseVisualStyleBackColor = false;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.Color.Wheat;
            this.lblHint.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(43, 398);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(76, 26);
            this.lblHint.TabIndex = 6;
            this.lblHint.Text = "Hints:";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Sudoku.Properties.Resources.back;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(28, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 65);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbYes
            // 
            this.cbYes.AutoSize = true;
            this.cbYes.BackColor = System.Drawing.Color.Wheat;
            this.cbYes.Checked = true;
            this.cbYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbYes.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYes.Location = new System.Drawing.Point(157, 403);
            this.cbYes.Name = "cbYes";
            this.cbYes.Size = new System.Drawing.Size(91, 21);
            this.cbYes.TabIndex = 10;
            this.cbYes.Text = "Show hint";
            this.cbYes.UseVisualStyleBackColor = false;
            // 
            // cbNo
            // 
            this.cbNo.AutoSize = true;
            this.cbNo.BackColor = System.Drawing.Color.Wheat;
            this.cbNo.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNo.Location = new System.Drawing.Point(157, 430);
            this.cbNo.Name = "cbNo";
            this.cbNo.Size = new System.Drawing.Size(87, 21);
            this.cbNo.TabIndex = 11;
            this.cbNo.Text = "Hide hint";
            this.cbNo.UseVisualStyleBackColor = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Sudoku.Properties.Resources.optionsForm;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(482, 847);
            this.Controls.Add(this.cbNo);
            this.Controls.Add(this.cbYes);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.rbtnMaid);
            this.Controls.Add(this.rbtnPou);
            this.Controls.Add(this.rbtnSimple);
            this.Controls.Add(this.rbtnNone);
            this.Controls.Add(this.lblMusic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.RadioButton rbtnNone;
        private System.Windows.Forms.RadioButton rbtnSimple;
        private System.Windows.Forms.RadioButton rbtnPou;
        private System.Windows.Forms.RadioButton rbtnMaid;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbYes;
        private System.Windows.Forms.CheckBox cbNo;
    }
}