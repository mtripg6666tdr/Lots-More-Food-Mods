
namespace LangConverter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CollectBasicDataSettingsContainer = new System.Windows.Forms.GroupBox();
            this.TranslateLangSettingsContainer = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OriginalChooseButton = new System.Windows.Forms.Button();
            this.TranslatedChooseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ExportChooseButton = new System.Windows.Forms.Button();
            this.CollectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CollectBasicDataSettingsContainer.SuspendLayout();
            this.TranslateLangSettingsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Choose one...",
            "Collect basic data",
            "Translate lang"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CollectBasicDataSettingsContainer
            // 
            this.CollectBasicDataSettingsContainer.Controls.Add(this.CollectButton);
            this.CollectBasicDataSettingsContainer.Controls.Add(this.ExportChooseButton);
            this.CollectBasicDataSettingsContainer.Controls.Add(this.textBox3);
            this.CollectBasicDataSettingsContainer.Controls.Add(this.label3);
            this.CollectBasicDataSettingsContainer.Controls.Add(this.TranslatedChooseButton);
            this.CollectBasicDataSettingsContainer.Controls.Add(this.OriginalChooseButton);
            this.CollectBasicDataSettingsContainer.Controls.Add(this.label2);
            this.CollectBasicDataSettingsContainer.Controls.Add(this.label1);
            this.CollectBasicDataSettingsContainer.Controls.Add(this.textBox2);
            this.CollectBasicDataSettingsContainer.Controls.Add(this.textBox1);
            this.CollectBasicDataSettingsContainer.Enabled = false;
            this.CollectBasicDataSettingsContainer.Location = new System.Drawing.Point(13, 40);
            this.CollectBasicDataSettingsContainer.Name = "CollectBasicDataSettingsContainer";
            this.CollectBasicDataSettingsContainer.Size = new System.Drawing.Size(357, 123);
            this.CollectBasicDataSettingsContainer.TabIndex = 1;
            this.CollectBasicDataSettingsContainer.TabStop = false;
            this.CollectBasicDataSettingsContainer.Text = "Collect basic data";
            // 
            // TranslateLangSettingsContainer
            // 
            this.TranslateLangSettingsContainer.Controls.Add(this.checkBox1);
            this.TranslateLangSettingsContainer.Controls.Add(this.button1);
            this.TranslateLangSettingsContainer.Controls.Add(this.button4);
            this.TranslateLangSettingsContainer.Controls.Add(this.button2);
            this.TranslateLangSettingsContainer.Controls.Add(this.textBox6);
            this.TranslateLangSettingsContainer.Controls.Add(this.textBox4);
            this.TranslateLangSettingsContainer.Controls.Add(this.textBox5);
            this.TranslateLangSettingsContainer.Controls.Add(this.label4);
            this.TranslateLangSettingsContainer.Controls.Add(this.label6);
            this.TranslateLangSettingsContainer.Controls.Add(this.button3);
            this.TranslateLangSettingsContainer.Controls.Add(this.label5);
            this.TranslateLangSettingsContainer.Enabled = false;
            this.TranslateLangSettingsContainer.Location = new System.Drawing.Point(13, 169);
            this.TranslateLangSettingsContainer.Name = "TranslateLangSettingsContainer";
            this.TranslateLangSettingsContainer.Size = new System.Drawing.Size(357, 133);
            this.TranslateLangSettingsContainer.TabIndex = 2;
            this.TranslateLangSettingsContainer.TabStop = false;
            this.TranslateLangSettingsContainer.Text = "Translate lang";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 19);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(190, 19);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Translated:";
            // 
            // OriginalChooseButton
            // 
            this.OriginalChooseButton.Location = new System.Drawing.Point(276, 10);
            this.OriginalChooseButton.Name = "OriginalChooseButton";
            this.OriginalChooseButton.Size = new System.Drawing.Size(75, 23);
            this.OriginalChooseButton.TabIndex = 4;
            this.OriginalChooseButton.Text = "Choose(&O)...";
            this.OriginalChooseButton.UseVisualStyleBackColor = true;
            this.OriginalChooseButton.Click += new System.EventHandler(this.OriginalChooseButton_Click);
            // 
            // TranslatedChooseButton
            // 
            this.TranslatedChooseButton.Location = new System.Drawing.Point(276, 39);
            this.TranslatedChooseButton.Name = "TranslatedChooseButton";
            this.TranslatedChooseButton.Size = new System.Drawing.Size(75, 23);
            this.TranslatedChooseButton.TabIndex = 5;
            this.TranslatedChooseButton.Text = "Choose(&T)...";
            this.TranslatedChooseButton.UseVisualStyleBackColor = true;
            this.TranslatedChooseButton.Click += new System.EventHandler(this.TranslatedChooseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Export:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(190, 19);
            this.textBox3.TabIndex = 7;
            // 
            // ExportChooseButton
            // 
            this.ExportChooseButton.Location = new System.Drawing.Point(276, 65);
            this.ExportChooseButton.Name = "ExportChooseButton";
            this.ExportChooseButton.Size = new System.Drawing.Size(75, 23);
            this.ExportChooseButton.TabIndex = 8;
            this.ExportChooseButton.Text = "Choose(&E)...";
            this.ExportChooseButton.UseVisualStyleBackColor = true;
            this.ExportChooseButton.Click += new System.EventHandler(this.ExportChooseButton_Click);
            // 
            // CollectButton
            // 
            this.CollectButton.Location = new System.Drawing.Point(276, 94);
            this.CollectButton.Name = "CollectButton";
            this.CollectButton.Size = new System.Drawing.Size(75, 23);
            this.CollectButton.TabIndex = 9;
            this.CollectButton.Text = "Collect(&C)";
            this.CollectButton.UseVisualStyleBackColor = true;
            this.CollectButton.Click += new System.EventHandler(this.CollectButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Translate(&R)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Choose(&F)...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(190, 19);
            this.textBox4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Export:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Choose(&U)...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(276, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Choose(&P)...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Basic data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Original:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(190, 19);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(80, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(190, 19);
            this.textBox6.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 16);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Ignore unknown";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 311);
            this.Controls.Add(this.TranslateLangSettingsContainer);
            this.Controls.Add(this.CollectBasicDataSettingsContainer);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "LangConverter";
            this.CollectBasicDataSettingsContainer.ResumeLayout(false);
            this.CollectBasicDataSettingsContainer.PerformLayout();
            this.TranslateLangSettingsContainer.ResumeLayout(false);
            this.TranslateLangSettingsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox CollectBasicDataSettingsContainer;
        private System.Windows.Forms.Button CollectButton;
        private System.Windows.Forms.Button ExportChooseButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TranslatedChooseButton;
        private System.Windows.Forms.Button OriginalChooseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox TranslateLangSettingsContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

