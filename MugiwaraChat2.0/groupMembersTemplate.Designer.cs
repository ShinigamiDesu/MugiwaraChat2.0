﻿namespace MugiwaraChat2._0
{
    partial class groupMembersTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.pic_PFP = new MugiwaraChat2._0.PictureFormat();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pic_status = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_action = new System.Windows.Forms.PictureBox();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.btn_removeAdmin = new System.Windows.Forms.Button();
            this.btn_removeGroup = new System.Windows.Forms.Button();
            this.btn_assign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_action)).BeginInit();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FullName.Location = new System.Drawing.Point(81, 46);
            this.lbl_FullName.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(137, 28);
            this.lbl_FullName.TabIndex = 19;
            this.lbl_FullName.Text = "Ryomen Sukuna";
            // 
            // pic_PFP
            // 
            this.pic_PFP.Image = global::MugiwaraChat2._0.Properties.Resources.Screenshot_2023_12_24_075037;
            this.pic_PFP.Location = new System.Drawing.Point(2, 0);
            this.pic_PFP.Margin = new System.Windows.Forms.Padding(0);
            this.pic_PFP.Name = "pic_PFP";
            this.pic_PFP.Size = new System.Drawing.Size(77, 79);
            this.pic_PFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PFP.TabIndex = 14;
            this.pic_PFP.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Poppins ExtraLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(76, 9);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 48);
            this.lbl_username.TabIndex = 18;
            this.lbl_username.Text = "Sukuna";
            // 
            // pic_status
            // 
            this.pic_status.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_status.Image = global::MugiwaraChat2._0.Properties.Resources.Green_Circle;
            this.pic_status.Location = new System.Drawing.Point(350, 25);
            this.pic_status.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pic_status.Name = "pic_status";
            this.pic_status.Size = new System.Drawing.Size(35, 35);
            this.pic_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_status.TabIndex = 17;
            this.pic_status.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(4, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 1);
            this.panel1.TabIndex = 15;
            // 
            // pic_action
            // 
            this.pic_action.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_action.Image = global::MugiwaraChat2._0.Properties.Resources.Ellipsis;
            this.pic_action.Location = new System.Drawing.Point(405, 17);
            this.pic_action.Margin = new System.Windows.Forms.Padding(120, 15, 0, 0);
            this.pic_action.Name = "pic_action";
            this.pic_action.Size = new System.Drawing.Size(43, 50);
            this.pic_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_action.TabIndex = 16;
            this.pic_action.TabStop = false;
            this.pic_action.Visible = false;
            this.pic_action.Click += new System.EventHandler(this.pic_action_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.White;
            this.adminPanel.Controls.Add(this.btn_removeAdmin);
            this.adminPanel.Controls.Add(this.btn_removeGroup);
            this.adminPanel.Controls.Add(this.btn_assign);
            this.adminPanel.Location = new System.Drawing.Point(221, 3);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(177, 100);
            this.adminPanel.TabIndex = 20;
            this.adminPanel.Visible = false;
            // 
            // btn_removeAdmin
            // 
            this.btn_removeAdmin.BackColor = System.Drawing.Color.White;
            this.btn_removeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removeAdmin.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeAdmin.Location = new System.Drawing.Point(14, 65);
            this.btn_removeAdmin.Name = "btn_removeAdmin";
            this.btn_removeAdmin.Size = new System.Drawing.Size(148, 23);
            this.btn_removeAdmin.TabIndex = 23;
            this.btn_removeAdmin.Text = "Remove admin";
            this.btn_removeAdmin.UseVisualStyleBackColor = false;
            this.btn_removeAdmin.Click += new System.EventHandler(this.btn_removeAdmin_Click);
            // 
            // btn_removeGroup
            // 
            this.btn_removeGroup.BackColor = System.Drawing.Color.White;
            this.btn_removeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removeGroup.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeGroup.Location = new System.Drawing.Point(16, 35);
            this.btn_removeGroup.Name = "btn_removeGroup";
            this.btn_removeGroup.Size = new System.Drawing.Size(148, 23);
            this.btn_removeGroup.TabIndex = 22;
            this.btn_removeGroup.Text = "Remove From Group";
            this.btn_removeGroup.UseVisualStyleBackColor = false;
            this.btn_removeGroup.Click += new System.EventHandler(this.btn_removeGroup_Click);
            // 
            // btn_assign
            // 
            this.btn_assign.BackColor = System.Drawing.Color.White;
            this.btn_assign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_assign.Font = new System.Drawing.Font("Poppins ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assign.Location = new System.Drawing.Point(16, 6);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(148, 23);
            this.btn_assign.TabIndex = 21;
            this.btn_assign.Text = "Make Admin";
            this.btn_assign.UseVisualStyleBackColor = false;
            this.btn_assign.Click += new System.EventHandler(this.btn_assign_Click);
            // 
            // groupMembersTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.pic_PFP);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pic_status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_action);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "groupMembersTemplate";
            this.Size = new System.Drawing.Size(455, 106);
            this.Load += new System.EventHandler(this.groupMembersTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_PFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_action)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FullName;
        private PictureFormat pic_PFP;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pic_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_action;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Button btn_removeGroup;
        private System.Windows.Forms.Button btn_removeAdmin;
    }
}