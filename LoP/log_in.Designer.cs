
namespace LoP
{
    partial class log_in
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
            this.login_lab = new System.Windows.Forms.Label();
            this.password_lab = new System.Windows.Forms.Label();
            this.log_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.crt_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.pass_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login_lab
            // 
            this.login_lab.AutoSize = true;
            this.login_lab.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_lab.Location = new System.Drawing.Point(24, 20);
            this.login_lab.Name = "login_lab";
            this.login_lab.Size = new System.Drawing.Size(48, 15);
            this.login_lab.TabIndex = 0;
            this.login_lab.Text = "Логин:";
            // 
            // password_lab
            // 
            this.password_lab.AutoSize = true;
            this.password_lab.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_lab.Location = new System.Drawing.Point(24, 69);
            this.password_lab.Name = "password_lab";
            this.password_lab.Size = new System.Drawing.Size(56, 15);
            this.password_lab.TabIndex = 1;
            this.password_lab.Text = "Пароль:";
            // 
            // log_box
            // 
            this.log_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_box.Location = new System.Drawing.Point(27, 38);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(148, 21);
            this.log_box.TabIndex = 2;
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_box.Location = new System.Drawing.Point(27, 90);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(148, 21);
            this.pass_box.TabIndex = 3;
            this.pass_box.UseSystemPasswordChar = true;
            // 
            // crt_btn
            // 
            this.crt_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crt_btn.Location = new System.Drawing.Point(27, 150);
            this.crt_btn.Name = "crt_btn";
            this.crt_btn.Size = new System.Drawing.Size(148, 27);
            this.crt_btn.TabIndex = 4;
            this.crt_btn.Text = "Войти";
            this.crt_btn.UseVisualStyleBackColor = true;
            this.crt_btn.Click += new System.EventHandler(this.crt_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_btn.Location = new System.Drawing.Point(27, 117);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(148, 27);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Очистить поля ввода";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // pass_checkBox
            // 
            this.pass_checkBox.AutoSize = true;
            this.pass_checkBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_checkBox.Location = new System.Drawing.Point(86, 68);
            this.pass_checkBox.Name = "pass_checkBox";
            this.pass_checkBox.Size = new System.Drawing.Size(82, 19);
            this.pass_checkBox.TabIndex = 7;
            this.pass_checkBox.Text = "Показать";
            this.pass_checkBox.UseVisualStyleBackColor = true;
            this.pass_checkBox.CheckedChanged += new System.EventHandler(this.pass_checkBox_CheckedChanged);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(199, 201);
            this.Controls.Add(this.pass_checkBox);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.crt_btn);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.log_box);
            this.Controls.Add(this.password_lab);
            this.Controls.Add(this.login_lab);
            this.Name = "log_in";
            this.Text = "Log_in";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_lab;
        private System.Windows.Forms.Label password_lab;
        private System.Windows.Forms.TextBox log_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Button crt_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.CheckBox pass_checkBox;
    }
}