
namespace LoP
{
    partial class partprofile
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
            this.name_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.patron_label = new System.Windows.Forms.Label();
            this.number_label = new System.Windows.Forms.Label();
            this.pos_label = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.chng_btn = new System.Windows.Forms.Button();
            this.surname_box = new System.Windows.Forms.ComboBox();
            this.patron_box = new System.Windows.Forms.ComboBox();
            this.pos_box = new System.Windows.Forms.ComboBox();
            this.org_box = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.number_box = new System.Windows.Forms.ComboBox();
            this.event_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.org_label = new System.Windows.Forms.Label();
            this.event_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(152, 44);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(40, 15);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "name";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_label.Location = new System.Drawing.Point(152, 11);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(59, 15);
            this.surname_label.TabIndex = 1;
            this.surname_label.Text = "surname";
            // 
            // patron_label
            // 
            this.patron_label.AutoSize = true;
            this.patron_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patron_label.Location = new System.Drawing.Point(152, 79);
            this.patron_label.Name = "patron_label";
            this.patron_label.Size = new System.Drawing.Size(46, 15);
            this.patron_label.TabIndex = 2;
            this.patron_label.Text = "patron";
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_label.Location = new System.Drawing.Point(152, 114);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(54, 15);
            this.number_label.TabIndex = 3;
            this.number_label.Text = "number";
            // 
            // pos_label
            // 
            this.pos_label.AutoSize = true;
            this.pos_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos_label.Location = new System.Drawing.Point(152, 151);
            this.pos_label.Name = "pos_label";
            this.pos_label.Size = new System.Drawing.Size(25, 15);
            this.pos_label.TabIndex = 4;
            this.pos_label.Text = "pos";
            // 
            // del_btn
            // 
            this.del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(6, 308);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(263, 29);
            this.del_btn.TabIndex = 11;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // chng_btn
            // 
            this.chng_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chng_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chng_btn.Location = new System.Drawing.Point(6, 261);
            this.chng_btn.Name = "chng_btn";
            this.chng_btn.Size = new System.Drawing.Size(263, 29);
            this.chng_btn.TabIndex = 12;
            this.chng_btn.Text = "Изменить данные";
            this.chng_btn.UseVisualStyleBackColor = true;
            this.chng_btn.Click += new System.EventHandler(this.chng_btn_Click);
            // 
            // surname_box
            // 
            this.surname_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.surname_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_box.FormattingEnabled = true;
            this.surname_box.Location = new System.Drawing.Point(136, 7);
            this.surname_box.Name = "surname_box";
            this.surname_box.Size = new System.Drawing.Size(133, 23);
            this.surname_box.TabIndex = 13;
            this.surname_box.SelectedIndexChanged += new System.EventHandler(this.class_box_SelectedIndexChanged);
            // 
            // patron_box
            // 
            this.patron_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.patron_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patron_box.FormattingEnabled = true;
            this.patron_box.Location = new System.Drawing.Point(136, 75);
            this.patron_box.Name = "patron_box";
            this.patron_box.Size = new System.Drawing.Size(133, 23);
            this.patron_box.TabIndex = 14;
            this.patron_box.SelectedIndexChanged += new System.EventHandler(this.vulnerability_box_SelectedIndexChanged);
            // 
            // pos_box
            // 
            this.pos_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pos_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos_box.FormattingEnabled = true;
            this.pos_box.Location = new System.Drawing.Point(136, 143);
            this.pos_box.Name = "pos_box";
            this.pos_box.Size = new System.Drawing.Size(133, 23);
            this.pos_box.TabIndex = 16;
            this.pos_box.SelectedIndexChanged += new System.EventHandler(this.type_box_SelectedIndexChanged);
            // 
            // org_box
            // 
            this.org_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.org_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.org_box.FormattingEnabled = true;
            this.org_box.Location = new System.Drawing.Point(136, 177);
            this.org_box.Name = "org_box";
            this.org_box.Size = new System.Drawing.Size(133, 23);
            this.org_box.TabIndex = 17;
            this.org_box.SelectedIndexChanged += new System.EventHandler(this.loot_box_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(6, 355);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(263, 29);
            this.back.TabIndex = 18;
            this.back.Text = "К списку участников";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // name_box
            // 
            this.name_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.name_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.FormattingEnabled = true;
            this.name_box.Location = new System.Drawing.Point(136, 41);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(133, 23);
            this.name_box.TabIndex = 15;
            this.name_box.SelectedIndexChanged += new System.EventHandler(this.name_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Должность";
            // 
            // number_box
            // 
            this.number_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.number_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_box.FormattingEnabled = true;
            this.number_box.Location = new System.Drawing.Point(136, 109);
            this.number_box.Name = "number_box";
            this.number_box.Size = new System.Drawing.Size(133, 23);
            this.number_box.TabIndex = 24;
            this.number_box.SelectedIndexChanged += new System.EventHandler(this.number_box_SelectedIndexChanged);
            // 
            // event_box
            // 
            this.event_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.event_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.event_box.FormattingEnabled = true;
            this.event_box.Location = new System.Drawing.Point(136, 211);
            this.event_box.Name = "event_box";
            this.event_box.Size = new System.Drawing.Size(133, 23);
            this.event_box.TabIndex = 25;
            this.event_box.SelectedIndexChanged += new System.EventHandler(this.event_box_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Организация/Фонд";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Событие/Акция";
            // 
            // org_label
            // 
            this.org_label.AutoSize = true;
            this.org_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.org_label.Location = new System.Drawing.Point(152, 181);
            this.org_label.Name = "org_label";
            this.org_label.Size = new System.Drawing.Size(26, 15);
            this.org_label.TabIndex = 28;
            this.org_label.Text = "org";
            // 
            // event_label
            // 
            this.event_label.AutoSize = true;
            this.event_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.event_label.Location = new System.Drawing.Point(152, 217);
            this.event_label.Name = "event_label";
            this.event_label.Size = new System.Drawing.Size(40, 15);
            this.event_label.TabIndex = 29;
            this.event_label.Text = "event";
            // 
            // partprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(279, 396);
            this.Controls.Add(this.event_label);
            this.Controls.Add(this.org_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.event_box);
            this.Controls.Add(this.number_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.org_box);
            this.Controls.Add(this.pos_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.patron_box);
            this.Controls.Add(this.surname_box);
            this.Controls.Add(this.chng_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.pos_label);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.patron_label);
            this.Controls.Add(this.surname_label);
            this.Controls.Add(this.name_label);
            this.Name = "partprofile";
            this.Text = "PartProfile";
            this.Load += new System.EventHandler(this.MonsterProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.Label patron_label;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label pos_label;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button chng_btn;
        private System.Windows.Forms.ComboBox surname_box;
        private System.Windows.Forms.ComboBox patron_box;
        private System.Windows.Forms.ComboBox pos_box;
        private System.Windows.Forms.ComboBox org_box;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox number_box;
        private System.Windows.Forms.ComboBox event_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label org_label;
        private System.Windows.Forms.Label event_label;
    }
}