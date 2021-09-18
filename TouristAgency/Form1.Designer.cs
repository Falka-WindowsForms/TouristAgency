
namespace TouristAgency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.CountriesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countryField = new System.Windows.Forms.TextBox();
            this.addCountry_button = new System.Windows.Forms.Button();
            this.delCountry_button = new System.Windows.Forms.Button();
            this.editCountry_button = new System.Windows.Forms.Button();
            this.reset_countryButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.reset_countryButton);
            this.tabPage1.Controls.Add(this.editCountry_button);
            this.tabPage1.Controls.Add(this.delCountry_button);
            this.tabPage1.Controls.Add(this.addCountry_button);
            this.tabPage1.Controls.Add(this.countryField);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CountriesList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Страны";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(589, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Города";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(589, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отели";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(589, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Туры";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(589, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Клиенты";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(589, 424);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Продажи";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // CountriesList
            // 
            this.CountriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountriesList.FormattingEnabled = true;
            this.CountriesList.ItemHeight = 24;
            this.CountriesList.Location = new System.Drawing.Point(7, 7);
            this.CountriesList.Name = "CountriesList";
            this.CountriesList.ScrollAlwaysVisible = true;
            this.CountriesList.Size = new System.Drawing.Size(190, 388);
            this.CountriesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(204, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country name:";
            // 
            // countryField
            // 
            this.countryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryField.Location = new System.Drawing.Point(209, 35);
            this.countryField.Name = "countryField";
            this.countryField.Size = new System.Drawing.Size(361, 31);
            this.countryField.TabIndex = 2;
            // 
            // addCountry_button
            // 
            this.addCountry_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCountry_button.Location = new System.Drawing.Point(315, 72);
            this.addCountry_button.Name = "addCountry_button";
            this.addCountry_button.Size = new System.Drawing.Size(137, 34);
            this.addCountry_button.TabIndex = 3;
            this.addCountry_button.Text = "Add";
            this.addCountry_button.UseVisualStyleBackColor = true;
            this.addCountry_button.Click += new System.EventHandler(this.addCountry_button_Click);
            // 
            // delCountry_button
            // 
            this.delCountry_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delCountry_button.Location = new System.Drawing.Point(315, 112);
            this.delCountry_button.Name = "delCountry_button";
            this.delCountry_button.Size = new System.Drawing.Size(137, 34);
            this.delCountry_button.TabIndex = 4;
            this.delCountry_button.Text = "Delete";
            this.delCountry_button.UseVisualStyleBackColor = true;
            // 
            // editCountry_button
            // 
            this.editCountry_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCountry_button.Location = new System.Drawing.Point(315, 152);
            this.editCountry_button.Name = "editCountry_button";
            this.editCountry_button.Size = new System.Drawing.Size(137, 34);
            this.editCountry_button.TabIndex = 5;
            this.editCountry_button.Text = "Edit";
            this.editCountry_button.UseVisualStyleBackColor = true;
            // 
            // reset_countryButton
            // 
            this.reset_countryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset_countryButton.Location = new System.Drawing.Point(315, 192);
            this.reset_countryButton.Name = "reset_countryButton";
            this.reset_countryButton.Size = new System.Drawing.Size(137, 34);
            this.reset_countryButton.TabIndex = 6;
            this.reset_countryButton.Text = "Reset";
            this.reset_countryButton.UseVisualStyleBackColor = true;
            this.reset_countryButton.Click += new System.EventHandler(this.reset_countryButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TouristAgency.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(209, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(589, 424);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Категории";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reset_countryButton;
        private System.Windows.Forms.Button editCountry_button;
        private System.Windows.Forms.Button delCountry_button;
        private System.Windows.Forms.Button addCountry_button;
        private System.Windows.Forms.TextBox countryField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CountriesList;
        private System.Windows.Forms.TabPage tabPage7;
    }
}

