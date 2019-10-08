namespace Lab06_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdateHistory = new System.Windows.Forms.Button();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.btnSessionGet = new System.Windows.Forms.Button();
            this.btnSessionSet = new System.Windows.Forms.Button();
            this.textBoxSessionValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateHistory
            // 
            this.btnUpdateHistory.Location = new System.Drawing.Point(289, 202);
            this.btnUpdateHistory.Name = "btnUpdateHistory";
            this.btnUpdateHistory.Size = new System.Drawing.Size(239, 23);
            this.btnUpdateHistory.TabIndex = 29;
            this.btnUpdateHistory.Text = "Update history";
            this.btnUpdateHistory.UseVisualStyleBackColor = true;
            this.btnUpdateHistory.Click += new System.EventHandler(this.btnUpdateHistory_Click);
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Location = new System.Drawing.Point(289, 36);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.Size = new System.Drawing.Size(239, 160);
            this.textBoxHistory.TabIndex = 28;
            // 
            // btnSessionGet
            // 
            this.btnSessionGet.Location = new System.Drawing.Point(109, 202);
            this.btnSessionGet.Name = "btnSessionGet";
            this.btnSessionGet.Size = new System.Drawing.Size(75, 23);
            this.btnSessionGet.TabIndex = 27;
            this.btnSessionGet.Text = "Get";
            this.btnSessionGet.UseVisualStyleBackColor = true;
            this.btnSessionGet.Click += new System.EventHandler(this.btnSessionGet_Click);
            // 
            // btnSessionSet
            // 
            this.btnSessionSet.Location = new System.Drawing.Point(28, 202);
            this.btnSessionSet.Name = "btnSessionSet";
            this.btnSessionSet.Size = new System.Drawing.Size(75, 23);
            this.btnSessionSet.TabIndex = 26;
            this.btnSessionSet.Text = "Set";
            this.btnSessionSet.UseVisualStyleBackColor = true;
            this.btnSessionSet.Click += new System.EventHandler(this.btnSessionSet_Click);
            // 
            // textBoxSessionValue
            // 
            this.textBoxSessionValue.Location = new System.Drawing.Point(102, 176);
            this.textBoxSessionValue.Name = "textBoxSessionValue";
            this.textBoxSessionValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxSessionValue.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "SessionValue";
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(190, 124);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 23;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(109, 124);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 22;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(66, 88);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(100, 20);
            this.textBoxRes.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Result:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(66, 62);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(66, 36);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "X:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 285);
            this.Controls.Add(this.btnUpdateHistory);
            this.Controls.Add(this.textBoxHistory);
            this.Controls.Add(this.btnSessionGet);
            this.Controls.Add(this.btnSessionSet);
            this.Controls.Add(this.textBoxSessionValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateHistory;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Button btnSessionGet;
        private System.Windows.Forms.Button btnSessionSet;
        private System.Windows.Forms.TextBox textBoxSessionValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label1;
    }
}

