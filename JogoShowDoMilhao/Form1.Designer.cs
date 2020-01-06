namespace JogoShowDoMilhao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblQuestionDescription = new System.Windows.Forms.Label();
            this.rdbOption1 = new System.Windows.Forms.RadioButton();
            this.rdbOption2 = new System.Windows.Forms.RadioButton();
            this.rdbOption3 = new System.Windows.Forms.RadioButton();
            this.rdbOption4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionDescription
            // 
            this.lblQuestionDescription.AutoSize = true;
            this.lblQuestionDescription.BackColor = System.Drawing.Color.Gold;
            this.lblQuestionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionDescription.Location = new System.Drawing.Point(176, 9);
            this.lblQuestionDescription.Name = "lblQuestionDescription";
            this.lblQuestionDescription.Size = new System.Drawing.Size(389, 25);
            this.lblQuestionDescription.TabIndex = 0;
            this.lblQuestionDescription.Text = "Em qual país está a Torre de Pisa ?";
            // 
            // rdbOption1
            // 
            this.rdbOption1.AutoSize = true;
            this.rdbOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption1.Location = new System.Drawing.Point(26, 54);
            this.rdbOption1.Name = "rdbOption1";
            this.rdbOption1.Size = new System.Drawing.Size(70, 22);
            this.rdbOption1.TabIndex = 1;
            this.rdbOption1.TabStop = true;
            this.rdbOption1.Text = "Grécia";
            this.rdbOption1.UseVisualStyleBackColor = true;
            this.rdbOption1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbOption2
            // 
            this.rdbOption2.AutoSize = true;
            this.rdbOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption2.Location = new System.Drawing.Point(26, 100);
            this.rdbOption2.Name = "rdbOption2";
            this.rdbOption2.Size = new System.Drawing.Size(132, 22);
            this.rdbOption2.TabIndex = 2;
            this.rdbOption2.TabStop = true;
            this.rdbOption2.Text = "Estados Unidos";
            this.rdbOption2.UseVisualStyleBackColor = true;
            this.rdbOption2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbOption3
            // 
            this.rdbOption3.AutoSize = true;
            this.rdbOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption3.Location = new System.Drawing.Point(26, 145);
            this.rdbOption3.Name = "rdbOption3";
            this.rdbOption3.Size = new System.Drawing.Size(55, 22);
            this.rdbOption3.TabIndex = 3;
            this.rdbOption3.TabStop = true;
            this.rdbOption3.Text = "Itália";
            this.rdbOption3.UseVisualStyleBackColor = true;
            this.rdbOption3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbOption4
            // 
            this.rdbOption4.AutoSize = true;
            this.rdbOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption4.Location = new System.Drawing.Point(26, 194);
            this.rdbOption4.Name = "rdbOption4";
            this.rdbOption4.Size = new System.Drawing.Size(72, 22);
            this.rdbOption4.TabIndex = 4;
            this.rdbOption4.TabStop = true;
            this.rdbOption4.Text = "França";
            this.rdbOption4.UseVisualStyleBackColor = true;
            this.rdbOption4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "CONFERIR RESPOSTA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbOption4);
            this.Controls.Add(this.rdbOption3);
            this.Controls.Add(this.rdbOption2);
            this.Controls.Add(this.rdbOption1);
            this.Controls.Add(this.lblQuestionDescription);
            this.Name = "Form1";
            this.Text = "QUESTÃO 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionDescription;
        private System.Windows.Forms.RadioButton rdbOption1;
        private System.Windows.Forms.RadioButton rdbOption2;
        private System.Windows.Forms.RadioButton rdbOption3;
        private System.Windows.Forms.RadioButton rdbOption4;
        private System.Windows.Forms.Button button1;
    }
}

