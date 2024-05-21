using System.Windows.Forms;

namespace Lab10
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
            this.RepeatBubbleInt = new System.Windows.Forms.Button();
            this.PartlySortedBubbleInt = new System.Windows.Forms.Button();
            this.ChaotBubbleInt = new System.Windows.Forms.Button();
            this.RepeatQuickInt = new System.Windows.Forms.Button();
            this.PartlySortedQuickInt = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RepeatBubbleInt
            // 
            this.RepeatBubbleInt.BackColor = System.Drawing.Color.MediumPurple;
            this.RepeatBubbleInt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RepeatBubbleInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RepeatBubbleInt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RepeatBubbleInt.Location = new System.Drawing.Point(58, 292);
            this.RepeatBubbleInt.Name = "RepeatBubbleInt";
            this.RepeatBubbleInt.Size = new System.Drawing.Size(199, 55);
            this.RepeatBubbleInt.TabIndex = 12;
            this.RepeatBubbleInt.Text = "Скарби з повторами";
            this.RepeatBubbleInt.UseVisualStyleBackColor = false;
            this.RepeatBubbleInt.Click += new System.EventHandler(this.Duplicates_Click);
            // 
            // PartlySortedBubbleInt
            // 
            this.PartlySortedBubbleInt.BackColor = System.Drawing.Color.MediumPurple;
            this.PartlySortedBubbleInt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PartlySortedBubbleInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PartlySortedBubbleInt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PartlySortedBubbleInt.Location = new System.Drawing.Point(58, 199);
            this.PartlySortedBubbleInt.Name = "PartlySortedBubbleInt";
            this.PartlySortedBubbleInt.Size = new System.Drawing.Size(199, 55);
            this.PartlySortedBubbleInt.TabIndex = 11;
            this.PartlySortedBubbleInt.Text = "Частково відсортовані скарби";
            this.PartlySortedBubbleInt.UseVisualStyleBackColor = false;
            this.PartlySortedBubbleInt.Click += new System.EventHandler(this.PartiallySorted_Click);
            // 
            // ChaotBubbleInt
            // 
            this.ChaotBubbleInt.BackColor = System.Drawing.Color.MediumPurple;
            this.ChaotBubbleInt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChaotBubbleInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ChaotBubbleInt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChaotBubbleInt.Location = new System.Drawing.Point(58, 112);
            this.ChaotBubbleInt.Name = "ChaotBubbleInt";
            this.ChaotBubbleInt.Size = new System.Drawing.Size(199, 55);
            this.ChaotBubbleInt.TabIndex = 10;
            this.ChaotBubbleInt.Text = "Хаотичний перелік скарбів";
            this.ChaotBubbleInt.UseVisualStyleBackColor = false;
            this.ChaotBubbleInt.Click += new System.EventHandler(this.Chaotic_Click);
            // 
            // RepeatQuickInt
            // 
            this.RepeatQuickInt.BackColor = System.Drawing.Color.MediumPurple;
            this.RepeatQuickInt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RepeatQuickInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RepeatQuickInt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RepeatQuickInt.Location = new System.Drawing.Point(416, 554);
            this.RepeatQuickInt.Name = "RepeatQuickInt";
            this.RepeatQuickInt.Size = new System.Drawing.Size(174, 55);
            this.RepeatQuickInt.TabIndex = 14;
            this.RepeatQuickInt.Text = "Швидке сортування";
            this.RepeatQuickInt.UseVisualStyleBackColor = false;
            this.RepeatQuickInt.Click += new System.EventHandler(this.Quick_Click);
            // 
            // PartlySortedQuickInt
            // 
            this.PartlySortedQuickInt.BackColor = System.Drawing.Color.MediumPurple;
            this.PartlySortedQuickInt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PartlySortedQuickInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PartlySortedQuickInt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PartlySortedQuickInt.Location = new System.Drawing.Point(649, 554);
            this.PartlySortedQuickInt.Name = "PartlySortedQuickInt";
            this.PartlySortedQuickInt.Size = new System.Drawing.Size(174, 55);
            this.PartlySortedQuickInt.TabIndex = 13;
            this.PartlySortedQuickInt.Text = "Сортування бульбашкою";
            this.PartlySortedQuickInt.UseVisualStyleBackColor = false;
            this.PartlySortedQuickInt.Click += new System.EventHandler(this.Bubble_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(58, 401);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 29);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(537, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Список скарбів";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 82);
            this.label2.TabIndex = 18;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 86);
            this.label3.TabIndex = 19;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(331, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(605, 404);
            this.listBox1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(68, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = " Кількість скарбів   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 747);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.RepeatQuickInt);
            this.Controls.Add(this.PartlySortedQuickInt);
            this.Controls.Add(this.RepeatBubbleInt);
            this.Controls.Add(this.PartlySortedBubbleInt);
            this.Controls.Add(this.ChaotBubbleInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RepeatBubbleInt;
        private System.Windows.Forms.Button PartlySortedBubbleInt;
        private System.Windows.Forms.Button ChaotBubbleInt;
        private System.Windows.Forms.Button RepeatQuickInt;
        private System.Windows.Forms.Button PartlySortedQuickInt;
        private System.Windows.Forms.TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
    }
}

