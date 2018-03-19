﻿namespace QuanLyHS_THPT.GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngGiảngDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpĐiểmHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHọcSinhTheoLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.hồSơToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1179, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơGiáoViênToolStripMenuItem,
            this.hồSơHọcSinhToolStripMenuItem});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.hồSơToolStripMenuItem.Text = "Hồ Sơ ";
            // 
            // hồSơGiáoViênToolStripMenuItem
            // 
            this.hồSơGiáoViênToolStripMenuItem.Name = "hồSơGiáoViênToolStripMenuItem";
            this.hồSơGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.hồSơGiáoViênToolStripMenuItem.Text = "Hồ sơ giáo viên";
            // 
            // hồSơHọcSinhToolStripMenuItem
            // 
            this.hồSơHọcSinhToolStripMenuItem.Name = "hồSơHọcSinhToolStripMenuItem";
            this.hồSơHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.hồSơHọcSinhToolStripMenuItem.Text = "Hồ sơ học sinh";
            this.hồSơHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.hồSơHọcSinhToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânCôngGiảngDạyToolStripMenuItem,
            this.nhậpĐiểmHọcSinhToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // phânCôngGiảngDạyToolStripMenuItem
            // 
            this.phânCôngGiảngDạyToolStripMenuItem.Name = "phânCôngGiảngDạyToolStripMenuItem";
            this.phânCôngGiảngDạyToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.phânCôngGiảngDạyToolStripMenuItem.Text = "Phân công giáo viên";
            // 
            // nhậpĐiểmHọcSinhToolStripMenuItem
            // 
            this.nhậpĐiểmHọcSinhToolStripMenuItem.Name = "nhậpĐiểmHọcSinhToolStripMenuItem";
            this.nhậpĐiểmHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.nhậpĐiểmHọcSinhToolStripMenuItem.Text = "Nhập điểm học sinh";
            this.nhậpĐiểmHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.nhậpĐiểmHọcSinhToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchHọcSinhTheoLớpToolStripMenuItem,
            this.danhSáchMônHọcToolStripMenuItem,
            this.danhSáchLớpHọcToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // danhSáchHọcSinhTheoLớpToolStripMenuItem
            // 
            this.danhSáchHọcSinhTheoLớpToolStripMenuItem.Name = "danhSáchHọcSinhTheoLớpToolStripMenuItem";
            this.danhSáchHọcSinhTheoLớpToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.danhSáchHọcSinhTheoLớpToolStripMenuItem.Text = "Danh sách học sinh theo lớp";
            // 
            // danhSáchMônHọcToolStripMenuItem
            // 
            this.danhSáchMônHọcToolStripMenuItem.Name = "danhSáchMônHọcToolStripMenuItem";
            this.danhSáchMônHọcToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.danhSáchMônHọcToolStripMenuItem.Text = "Danh sách môn học";
            this.danhSáchMônHọcToolStripMenuItem.Click += new System.EventHandler(this.danhSáchMônHọcToolStripMenuItem_Click);
            // 
            // danhSáchLớpHọcToolStripMenuItem
            // 
            this.danhSáchLớpHọcToolStripMenuItem.Name = "danhSáchLớpHọcToolStripMenuItem";
            this.danhSáchLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.danhSáchLớpHọcToolStripMenuItem.Text = "Danh sách lớp học";
            this.danhSáchLớpHọcToolStripMenuItem.Click += new System.EventHandler(this.danhSáchLớpHọcToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 506);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hồSơGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hồSơHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngGiảngDạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpĐiểmHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHọcSinhTheoLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchMônHọcToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLớpHọcToolStripMenuItem;
    }
}