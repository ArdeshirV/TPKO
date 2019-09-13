namespace BaseProgram
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
            this.addressFile = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.addressFile_button = new System.Windows.Forms.Button();
            this.writeFile_button = new System.Windows.Forms.Button();
            this.informationTable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressFile
            // 
            this.addressFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressFile.Location = new System.Drawing.Point(12, 12);
            this.addressFile.Name = "addressFile";
            this.addressFile.Size = new System.Drawing.Size(654, 38);
            this.addressFile.TabIndex = 0;
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textInput.Location = new System.Drawing.Point(12, 56);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(654, 38);
            this.textInput.TabIndex = 1;
            // 
            // addressFile_button
            // 
            this.addressFile_button.Location = new System.Drawing.Point(672, 12);
            this.addressFile_button.Name = "addressFile_button";
            this.addressFile_button.Size = new System.Drawing.Size(116, 38);
            this.addressFile_button.TabIndex = 2;
            this.addressFile_button.Text = "Путь к файлу";
            this.addressFile_button.UseVisualStyleBackColor = true;
            // 
            // writeFile_button
            // 
            this.writeFile_button.Location = new System.Drawing.Point(672, 56);
            this.writeFile_button.Name = "writeFile_button";
            this.writeFile_button.Size = new System.Drawing.Size(116, 38);
            this.writeFile_button.TabIndex = 3;
            this.writeFile_button.Text = "Записать";
            this.writeFile_button.UseVisualStyleBackColor = true;
            // 
            // informationTable
            // 
            this.informationTable.BackColor = System.Drawing.SystemColors.HighlightText;
            this.informationTable.Location = new System.Drawing.Point(12, 101);
            this.informationTable.Name = "informationTable";
            this.informationTable.Size = new System.Drawing.Size(776, 340);
            this.informationTable.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.informationTable);
            this.Controls.Add(this.writeFile_button);
            this.Controls.Add(this.addressFile_button);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.addressFile);
            this.Name = "Form1";
            this.Text = "Base Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressFile;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button addressFile_button;
        private System.Windows.Forms.Button writeFile_button;
        private System.Windows.Forms.Label informationTable;
    }
}

