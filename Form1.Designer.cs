namespace KeyboardTypeRacer
{
    partial class KeyboardTyper
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.timerResult = new System.Windows.Forms.Timer(this.components);
            this.btnStore = new System.Windows.Forms.Button();
            this.btnFruits = new System.Windows.Forms.Button();
            this.btnVegetables = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInput.ForeColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(331, 204);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 30);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(139, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(589, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome to Samir\'s Typer Improver";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWord.ForeColor = System.Drawing.Color.White;
            this.lblWord.Location = new System.Drawing.Point(328, 151);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 36);
            this.lblWord.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(328, 108);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(319, 282);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 64);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(547, 91);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 29);
            this.lblTime.TabIndex = 7;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(513, 282);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(149, 64);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // timerResult
            // 
            this.timerResult.Tick += new System.EventHandler(this.timerResult_Tick);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStore.ForeColor = System.Drawing.Color.White;
            this.btnStore.Location = new System.Drawing.Point(72, 282);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(118, 66);
            this.btnStore.TabIndex = 9;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnFruits
            // 
            this.btnFruits.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFruits.ForeColor = System.Drawing.Color.White;
            this.btnFruits.Location = new System.Drawing.Point(196, 281);
            this.btnFruits.Name = "btnFruits";
            this.btnFruits.Size = new System.Drawing.Size(132, 64);
            this.btnFruits.TabIndex = 10;
            this.btnFruits.Text = "Fruits";
            this.btnFruits.UseVisualStyleBackColor = false;
            this.btnFruits.Click += new System.EventHandler(this.btnFruits_Click);
            // 
            // btnVegetables
            // 
            this.btnVegetables.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVegetables.ForeColor = System.Drawing.Color.White;
            this.btnVegetables.Location = new System.Drawing.Point(409, 282);
            this.btnVegetables.Name = "btnVegetables";
            this.btnVegetables.Size = new System.Drawing.Size(127, 64);
            this.btnVegetables.TabIndex = 11;
            this.btnVegetables.Text = "Vegetables";
            this.btnVegetables.UseVisualStyleBackColor = false;
            this.btnVegetables.Click += new System.EventHandler(this.btnVegetables_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWarning.ForeColor = System.Drawing.Color.White;
            this.lblWarning.Location = new System.Drawing.Point(12, 77);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(302, 25);
            this.lblWarning.TabIndex = 12;
            this.lblWarning.Text = "Capitilization and Spaces Count!!";
            // 
            // KeyboardTyper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnVegetables);
            this.Controls.Add(this.btnFruits);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtInput);
            this.Name = "KeyboardTyper";
            this.Text = "Samir\'s Typer Improver ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Timer timerResult;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnFruits;
        private System.Windows.Forms.Button btnVegetables;
        private System.Windows.Forms.Label lblWarning;
    }
}

