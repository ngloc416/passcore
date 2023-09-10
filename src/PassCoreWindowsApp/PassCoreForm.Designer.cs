using PassCoreWindowsApp.Properties;
using System.Windows.Forms;

namespace PassCoreWindowsApp
{
    partial class PassCoreForm
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
            this.TitleContainer = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.FormContainer = new System.Windows.Forms.Panel();
            this.UsernameSubTitle = new System.Windows.Forms.Label();
            this.PassStrengthBar = new System.Windows.Forms.ProgressBar();
            this.CheckPassLabel = new System.Windows.Forms.Label();
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.ReNewPassTextBox = new System.Windows.Forms.TextBox();
            this.ReNewPassLabel = new System.Windows.Forms.Label();
            this.NewPassTextBox = new System.Windows.Forms.TextBox();
            this.NewPassLabel = new System.Windows.Forms.Label();
            this.CurrPassTextBox = new System.Windows.Forms.TextBox();
            this.CurrPassLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TitleContainer.SuspendLayout();
            this.FormContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleContainer
            // 
            this.TitleContainer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleContainer.Controls.Add(this.Title);
            this.TitleContainer.Location = new System.Drawing.Point(0, 0);
            this.TitleContainer.Name = "TitleContainer";
            this.TitleContainer.Size = new System.Drawing.Size(1099, 74);
            this.TitleContainer.TabIndex = 99;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(355, 32);
            this.Title.TabIndex = 98;
            this.Title.Text = Resources.FormTitle;
            // 
            // FormContainer
            // 
            this.FormContainer.BackColor = System.Drawing.Color.White;
            this.FormContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FormContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormContainer.Controls.Add(this.UsernameSubTitle);
            this.FormContainer.Controls.Add(this.PassStrengthBar);
            this.FormContainer.Controls.Add(this.CheckPassLabel);
            this.FormContainer.Controls.Add(this.ChangePassButton);
            this.FormContainer.Controls.Add(this.ReNewPassTextBox);
            this.FormContainer.Controls.Add(this.ReNewPassLabel);
            this.FormContainer.Controls.Add(this.NewPassTextBox);
            this.FormContainer.Controls.Add(this.NewPassLabel);
            this.FormContainer.Controls.Add(this.CurrPassTextBox);
            this.FormContainer.Controls.Add(this.CurrPassLabel);
            this.FormContainer.Controls.Add(this.UsernameTextBox);
            this.FormContainer.Controls.Add(this.UsernameLabel);
            this.FormContainer.Location = new System.Drawing.Point(185, 92);
            this.FormContainer.Name = "FormContainer";
            this.FormContainer.Size = new System.Drawing.Size(710, 512);
            this.FormContainer.TabIndex = 97;
            // 
            // UsernameSubTitle
            // 
            this.UsernameSubTitle.AutoSize = true;
            this.UsernameSubTitle.ForeColor = System.Drawing.Color.Black;
            this.UsernameSubTitle.Location = new System.Drawing.Point(72, 89);
            this.UsernameSubTitle.Name = "UsernameSubTitle";
            this.UsernameSubTitle.Size = new System.Drawing.Size(210, 16);
            this.UsernameSubTitle.TabIndex = 97;
            this.UsernameSubTitle.Text = Resources.UsernameSubTitle;
            // 
            // PassStrengthBar
            // 
            this.PassStrengthBar.BackColor = System.Drawing.Color.White;
            this.PassStrengthBar.ForeColor = System.Drawing.Color.Aqua;
            this.PassStrengthBar.Location = new System.Drawing.Point(75, 263);
            this.PassStrengthBar.Maximum = 4;
            this.PassStrengthBar.Name = "PassStrengthBar";
            this.PassStrengthBar.Size = new System.Drawing.Size(541, 10);
            this.PassStrengthBar.Step = 1;
            this.PassStrengthBar.TabIndex = 96;
            // 
            // CheckPassLabel
            // 
            this.CheckPassLabel.AutoSize = true;
            this.CheckPassLabel.ForeColor = System.Drawing.Color.Red;
            this.CheckPassLabel.Location = new System.Drawing.Point(72, 352);
            this.CheckPassLabel.Name = "CheckPassLabel";
            this.CheckPassLabel.Size = new System.Drawing.Size(153, 16);
            this.CheckPassLabel.TabIndex = 95;
            this.CheckPassLabel.Text = Resources.CheckPassLabel;
            this.CheckPassLabel.Visible = false;
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ChangePassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePassButton.Enabled = false;
            this.ChangePassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChangePassButton.ForeColor = System.Drawing.Color.White;
            this.ChangePassButton.Location = new System.Drawing.Point(185, 392);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(326, 46);
            this.ChangePassButton.TabIndex = 5;
            this.ChangePassButton.Text = global::PassCoreWindowsApp.Properties.Resources.ChangePassButton;
            this.ChangePassButton.UseVisualStyleBackColor = false;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // ReNewPassTextBox
            // 
            this.ReNewPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ReNewPassTextBox.Location = new System.Drawing.Point(75, 313);
            this.ReNewPassTextBox.Name = "ReNewPassTextBox";
            this.ReNewPassTextBox.PasswordChar = '*';
            this.ReNewPassTextBox.Size = new System.Drawing.Size(541, 30);
            this.ReNewPassTextBox.TabIndex = 4;
            this.ReNewPassTextBox.TextChanged += new System.EventHandler(this.ReNewPassTextBox_TextChanged);
            this.ReNewPassTextBox.KeyDown += new KeyEventHandler(this.PressEnter);
            // 
            // ReNewPassLabel
            // 
            this.ReNewPassLabel.AutoSize = true;
            this.ReNewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ReNewPassLabel.Location = new System.Drawing.Point(71, 281);
            this.ReNewPassLabel.Name = "ReNewPassLabel";
            this.ReNewPassLabel.Size = new System.Drawing.Size(191, 20);
            this.ReNewPassLabel.TabIndex = 94;
            this.ReNewPassLabel.Text = Resources.ReNewPassLabel;
            // 
            // NewPassTextBox
            // 
            this.NewPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NewPassTextBox.Location = new System.Drawing.Point(75, 227);
            this.NewPassTextBox.Name = "NewPassTextBox";
            this.NewPassTextBox.PasswordChar = '*';
            this.NewPassTextBox.Size = new System.Drawing.Size(541, 30);
            this.NewPassTextBox.TabIndex = 3;
            this.NewPassTextBox.TextChanged += new System.EventHandler(this.NewPassTextBox_TextChanged);
            this.NewPassTextBox.KeyDown += new KeyEventHandler(this.PressEnter);
            // 
            // NewPassLabel
            // 
            this.NewPassLabel.AutoSize = true;
            this.NewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NewPassLabel.Location = new System.Drawing.Point(71, 195);
            this.NewPassLabel.Name = "NewPassLabel";
            this.NewPassLabel.Size = new System.Drawing.Size(121, 20);
            this.NewPassLabel.TabIndex = 93;
            this.NewPassLabel.Text = Resources.NewPassLabel;
            // 
            // CurrPassTextBox
            // 
            this.CurrPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CurrPassTextBox.Location = new System.Drawing.Point(75, 142);
            this.CurrPassTextBox.Name = "CurrPassTextBox";
            this.CurrPassTextBox.PasswordChar = '*';
            this.CurrPassTextBox.Size = new System.Drawing.Size(541, 30);
            this.CurrPassTextBox.TabIndex = 2;
            this.CurrPassTextBox.TextChanged += new System.EventHandler(this.CurrPassTextBox_TextChanged);
            this.CurrPassTextBox.KeyDown += new KeyEventHandler(this.PressEnter);
            // 
            // CurrPassLabel
            // 
            this.CurrPassLabel.AutoSize = true;
            this.CurrPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CurrPassLabel.Location = new System.Drawing.Point(71, 110);
            this.CurrPassLabel.Name = "CurrPassLabel";
            this.CurrPassLabel.Size = new System.Drawing.Size(144, 20);
            this.CurrPassLabel.TabIndex = 92;
            this.CurrPassLabel.Text = Resources.CurrPassLabel;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UsernameTextBox.Location = new System.Drawing.Point(75, 53);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(541, 30);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            this.UsernameTextBox.KeyDown += new KeyEventHandler(this.PressEnter);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UsernameLabel.Location = new System.Drawing.Point(71, 21);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(86, 20);
            this.UsernameLabel.TabIndex = 91;
            this.UsernameLabel.Text = Resources.UsernameLabel;
            // 
            // PassCoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 674);
            this.Controls.Add(this.FormContainer);
            this.Controls.Add(this.TitleContainer);
            this.Name = "PassCoreForm";
            this.Text = Resources.AppName;
            this.TitleContainer.ResumeLayout(false);
            this.TitleContainer.PerformLayout();
            this.FormContainer.ResumeLayout(false);
            this.FormContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        private void UsernameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel TitleContainer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel FormContainer;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox CurrPassTextBox;
        private System.Windows.Forms.Label CurrPassLabel;
        private System.Windows.Forms.TextBox ReNewPassTextBox;
        private System.Windows.Forms.Label ReNewPassLabel;
        private System.Windows.Forms.TextBox NewPassTextBox;
        private System.Windows.Forms.Label NewPassLabel;
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Label CheckPassLabel;
        private System.Windows.Forms.ProgressBar PassStrengthBar;
        private System.Windows.Forms.Label UsernameSubTitle;
    }
}

