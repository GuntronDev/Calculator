namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.TextBoxOperation = new System.Windows.Forms.TextBox();
            this.TextBoxLastNumber = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonPeriod = new System.Windows.Forms.Button();
            this.ButtonEquels = new System.Windows.Forms.Button();
            this.TextBoxCredits = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonTimes = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonDevide = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.TextBoxResult.Location = new System.Drawing.Point(12, 12);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(269, 53);
            this.TextBoxResult.TabIndex = 0;
            // 
            // TextBoxOperation
            // 
            this.TextBoxOperation.Location = new System.Drawing.Point(9, 70);
            this.TextBoxOperation.Name = "TextBoxOperation";
            this.TextBoxOperation.ReadOnly = true;
            this.TextBoxOperation.Size = new System.Drawing.Size(20, 20);
            this.TextBoxOperation.TabIndex = 16;
            // 
            // TextBoxLastNumber
            // 
            this.TextBoxLastNumber.Location = new System.Drawing.Point(35, 70);
            this.TextBoxLastNumber.Name = "TextBoxLastNumber";
            this.TextBoxLastNumber.ReadOnly = true;
            this.TextBoxLastNumber.Size = new System.Drawing.Size(245, 20);
            this.TextBoxLastNumber.TabIndex = 17;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button1.Location = new System.Drawing.Point(11, 96);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(60, 60);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button2.Location = new System.Drawing.Point(77, 96);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(60, 60);
            this.Button2.TabIndex = 18;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button3.Location = new System.Drawing.Point(143, 96);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(60, 60);
            this.Button3.TabIndex = 19;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button4.Location = new System.Drawing.Point(12, 162);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(60, 60);
            this.Button4.TabIndex = 20;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button5.Location = new System.Drawing.Point(78, 162);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(60, 60);
            this.Button5.TabIndex = 21;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button6.Location = new System.Drawing.Point(143, 162);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(60, 60);
            this.Button6.TabIndex = 22;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button7.Location = new System.Drawing.Point(12, 228);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(60, 60);
            this.Button7.TabIndex = 23;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button8.Location = new System.Drawing.Point(77, 228);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(60, 60);
            this.Button8.TabIndex = 24;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button9.Location = new System.Drawing.Point(143, 228);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(60, 60);
            this.Button9.TabIndex = 25;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button0
            // 
            this.Button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Button0.Location = new System.Drawing.Point(12, 294);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(60, 60);
            this.Button0.TabIndex = 26;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button_Click);
            // 
            // ButtonPeriod
            // 
            this.ButtonPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ButtonPeriod.Location = new System.Drawing.Point(77, 294);
            this.ButtonPeriod.Name = "ButtonPeriod";
            this.ButtonPeriod.Size = new System.Drawing.Size(60, 60);
            this.ButtonPeriod.TabIndex = 27;
            this.ButtonPeriod.Text = ",";
            this.ButtonPeriod.UseVisualStyleBackColor = true;
            this.ButtonPeriod.Click += new System.EventHandler(this.ButtonPeriod_Click);
            // 
            // ButtonEquels
            // 
            this.ButtonEquels.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ButtonEquels.Location = new System.Drawing.Point(143, 294);
            this.ButtonEquels.Name = "ButtonEquels";
            this.ButtonEquels.Size = new System.Drawing.Size(60, 60);
            this.ButtonEquels.TabIndex = 28;
            this.ButtonEquels.Text = "=";
            this.ButtonEquels.UseVisualStyleBackColor = true;
            this.ButtonEquels.Click += new System.EventHandler(this.ButtonEquels_Click);
            // 
            // TextBoxCredits
            // 
            this.TextBoxCredits.Location = new System.Drawing.Point(9, 356);
            this.TextBoxCredits.Name = "TextBoxCredits";
            this.TextBoxCredits.ReadOnly = true;
            this.TextBoxCredits.Size = new System.Drawing.Size(262, 20);
            this.TextBoxCredits.TabIndex = 29;
            this.TextBoxCredits.Text = "Made by Filip Jozíf";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.ButtonDelete.Location = new System.Drawing.Point(207, 96);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(73, 28);
            this.ButtonDelete.TabIndex = 30;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.ButtonC.Location = new System.Drawing.Point(207, 120);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(73, 28);
            this.ButtonC.TabIndex = 31;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = true;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ButtonTimes
            // 
            this.ButtonTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ButtonTimes.Location = new System.Drawing.Point(207, 150);
            this.ButtonTimes.Name = "ButtonTimes";
            this.ButtonTimes.Size = new System.Drawing.Size(75, 44);
            this.ButtonTimes.TabIndex = 32;
            this.ButtonTimes.Text = "*";
            this.ButtonTimes.UseVisualStyleBackColor = true;
            this.ButtonTimes.Click += new System.EventHandler(this.ButtonOperation_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ButtonPlus.Location = new System.Drawing.Point(207, 200);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 44);
            this.ButtonPlus.TabIndex = 33;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonOperation_Click);
            // 
            // ButtonDevide
            // 
            this.ButtonDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ButtonDevide.Location = new System.Drawing.Point(207, 250);
            this.ButtonDevide.Name = "ButtonDevide";
            this.ButtonDevide.Size = new System.Drawing.Size(75, 44);
            this.ButtonDevide.TabIndex = 34;
            this.ButtonDevide.Text = "/";
            this.ButtonDevide.UseVisualStyleBackColor = true;
            this.ButtonDevide.Click += new System.EventHandler(this.ButtonOperation_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ButtonMinus.Location = new System.Drawing.Point(207, 300);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(75, 44);
            this.ButtonMinus.TabIndex = 35;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonOperation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 378);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonDevide);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonTimes);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.TextBoxCredits);
            this.Controls.Add(this.ButtonEquels);
            this.Controls.Add(this.ButtonPeriod);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBoxLastNumber);
            this.Controls.Add(this.TextBoxOperation);
            this.Controls.Add(this.TextBoxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.TextBox TextBoxOperation;
        private System.Windows.Forms.TextBox TextBoxLastNumber;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonPeriod;
        private System.Windows.Forms.Button ButtonEquels;
        private System.Windows.Forms.TextBox TextBoxCredits;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonTimes;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonDevide;
        private System.Windows.Forms.Button ButtonMinus;
    }
}

