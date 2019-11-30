namespace BaseProgram
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxFileAddress = new System.Windows.Forms.TextBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonFileBrowse = new System.Windows.Forms.Button();
            this.ButtonWriteFile = new System.Windows.Forms.Button();
            this.TextBoxOutputInfo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // addressFile
            // 
            this.TextBoxFileAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFileAddress.Location = new System.Drawing.Point(12, 12);
            this.TextBoxFileAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxFileAddress.Name = "addressFile";
            this.TextBoxFileAddress.Size = new System.Drawing.Size(655, 38);
            this.TextBoxFileAddress.TabIndex = 0;
            // 
            // textInput
            // 
            this.TextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxInput.Location = new System.Drawing.Point(12, 57);
            this.TextBoxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxInput.Name = "textInput";
            this.TextBoxInput.Size = new System.Drawing.Size(655, 38);
            this.TextBoxInput.TabIndex = 1;
            // 
            // addressFile_button
            // 
            this.ButtonFileBrowse.Location = new System.Drawing.Point(672, 12);
            this.ButtonFileBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonFileBrowse.Name = "addressFile_button";
            this.ButtonFileBrowse.Size = new System.Drawing.Size(116, 38);
            this.ButtonFileBrowse.TabIndex = 2;
            this.ButtonFileBrowse.Text = "Путь к файлу";
            this.ButtonFileBrowse.UseVisualStyleBackColor = true;
            this.ButtonFileBrowse.Click += new System.EventHandler(this.TextBoxFileAddress_Click);
            // 
            // writeFile_button
            // 
            this.ButtonWriteFile.Location = new System.Drawing.Point(672, 57);
            this.ButtonWriteFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonWriteFile.Name = "writeFile_button";
            this.ButtonWriteFile.Size = new System.Drawing.Size(116, 38);
            this.ButtonWriteFile.TabIndex = 3;
            this.ButtonWriteFile.Text = "Записать";
            this.ButtonWriteFile.UseVisualStyleBackColor = true;
            this.ButtonWriteFile.Click += new System.EventHandler(this.ButtonWriteFile_Click);
            // 
            // informationTable
            // 
            this.TextBoxOutputInfo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TextBoxOutputInfo.Location = new System.Drawing.Point(12, 101);
            this.TextBoxOutputInfo.Name = "informationTable";
            this.TextBoxOutputInfo.Size = new System.Drawing.Size(776, 340);
            this.TextBoxOutputInfo.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxOutputInfo);
            this.Controls.Add(this.ButtonWriteFile);
            this.Controls.Add(this.ButtonFileBrowse);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.TextBoxFileAddress);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Base Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonFileBrowse;
        private System.Windows.Forms.Button ButtonWriteFile;
        private System.Windows.Forms.Label TextBoxOutputInfo;
        private System.Windows.Forms.TextBox TextBoxFileAddress;
        private System.Windows.Forms.Timer timer;
    }
}

