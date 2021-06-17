
using System;

namespace Project_1
{
    partial class mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainfrm));
            this.table = new System.Windows.Forms.TabControl();
            this.tabmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addpage = new System.Windows.Forms.ToolStripMenuItem();
            this.deletepage = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.status = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadbar = new System.Windows.Forms.ToolStripProgressBar();
            this.loadcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.typeofsave = new System.Windows.Forms.ToolStripStatusLabel();
            this.trayicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.traymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagemenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renamepage = new System.Windows.Forms.ToolStripMenuItem();
            this.deletepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabmenu.SuspendLayout();
            this.status.SuspendLayout();
            this.traymenu.SuspendLayout();
            this.pagemenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ContextMenuStrip = this.tabmenu;
            this.table.ImageList = this.imageList1;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.SelectedIndex = 0;
            this.table.Size = new System.Drawing.Size(268, 540);
            this.table.TabIndex = 5;
            // 
            // tabmenu
            // 
            this.tabmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addpage,
            this.deletepage,
            this.settingsToolStripMenuItem1,
            this.savebtn,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.tabmenu.Name = "tabmenu";
            this.tabmenu.Size = new System.Drawing.Size(181, 136);
            // 
            // addpage
            // 
            this.addpage.Image = global::Project_1.Properties.Resources.plus;
            this.addpage.Name = "addpage";
            this.addpage.Size = new System.Drawing.Size(180, 22);
            this.addpage.Text = "Добавить страницу";
            this.addpage.Click += new System.EventHandler(this.добавитьСтраницуToolStripMenuItem_Click);
            // 
            // deletepage
            // 
            this.deletepage.Image = global::Project_1.Properties.Resources.delete_1;
            this.deletepage.Name = "deletepage";
            this.deletepage.Size = new System.Drawing.Size(180, 22);
            this.deletepage.Text = "Удалить страницу";
            this.deletepage.Click += new System.EventHandler(this.deletepage_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveasiniToolStripMenuItem,
            this.saveasxmlToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.settingsToolStripMenuItem1.Image = global::Project_1.Properties.Resources.page_settings;
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem1.Text = "Настройки";
            // 
            // saveasiniToolStripMenuItem
            // 
            this.saveasiniToolStripMenuItem.CheckOnClick = true;
            this.saveasiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToolStripMenuItem,
            this.readToolStripMenuItem});
            this.saveasiniToolStripMenuItem.Image = global::Project_1.Properties.Resources.italic;
            this.saveasiniToolStripMenuItem.Name = "saveasiniToolStripMenuItem";
            this.saveasiniToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveasiniToolStripMenuItem.Text = "Сохранять в INI";
            this.saveasiniToolStripMenuItem.Click += new System.EventHandler(this.saveasiniToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Image = global::Project_1.Properties.Resources.еxport;
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.writeToolStripMenuItem.Text = "Записать";
            this.writeToolStripMenuItem.Visible = false;
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Image = global::Project_1.Properties.Resources.import;
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.readToolStripMenuItem.Text = "Прочитать";
            this.readToolStripMenuItem.Visible = false;
            // 
            // saveasxmlToolStripMenuItem
            // 
            this.saveasxmlToolStripMenuItem.CheckOnClick = true;
            this.saveasxmlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToolStripMenuItem1,
            this.readToolStripMenuItem1});
            this.saveasxmlToolStripMenuItem.Image = global::Project_1.Properties.Resources.font_сolor;
            this.saveasxmlToolStripMenuItem.Name = "saveasxmlToolStripMenuItem";
            this.saveasxmlToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveasxmlToolStripMenuItem.Text = "Сохранять в XML";
            this.saveasxmlToolStripMenuItem.Click += new System.EventHandler(this.saveasxmlToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem1
            // 
            this.writeToolStripMenuItem1.Image = global::Project_1.Properties.Resources.еxport;
            this.writeToolStripMenuItem1.Name = "writeToolStripMenuItem1";
            this.writeToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.writeToolStripMenuItem1.Text = "Записать";
            this.writeToolStripMenuItem1.Visible = false;
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Image = global::Project_1.Properties.Resources.import;
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.readToolStripMenuItem1.Text = "Прочитать";
            this.readToolStripMenuItem1.Visible = false;
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = global::Project_1.Properties.Resources.cd_disk;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backupToolStripMenuItem.Text = "Резервная копия";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // savebtn
            // 
            this.savebtn.Image = global::Project_1.Properties.Resources.save;
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(180, 22);
            this.savebtn.Text = "Сохранить";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::Project_1.Properties.Resources.balloon;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Project_1.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel,
            this.loadbar,
            this.loadcount,
            this.typeofsave});
            this.status.Location = new System.Drawing.Point(0, 519);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(264, 22);
            this.status.TabIndex = 6;
            this.status.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(25, 17);
            this.statuslabel.Text = "123";
            // 
            // loadbar
            // 
            this.loadbar.Name = "loadbar";
            this.loadbar.Size = new System.Drawing.Size(155, 16);
            // 
            // loadcount
            // 
            this.loadcount.Name = "loadcount";
            this.loadcount.Size = new System.Drawing.Size(0, 17);
            // 
            // typeofsave
            // 
            this.typeofsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.typeofsave.Name = "typeofsave";
            this.typeofsave.Size = new System.Drawing.Size(25, 17);
            this.typeofsave.Text = "123";
            // 
            // trayicon
            // 
            this.trayicon.ContextMenuStrip = this.traymenu;
            this.trayicon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayicon.Icon")));
            this.trayicon.Text = "Twinx v3";
            this.trayicon.Visible = true;
            // 
            // traymenu
            // 
            this.traymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.traymenu.Name = "traymenu";
            this.traymenu.Size = new System.Drawing.Size(135, 92);
            this.traymenu.Opening += new System.ComponentModel.CancelEventHandler(this.traymenu_Opening);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Image = global::Project_1.Properties.Resources.down;
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.downToolStripMenuItem.Text = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Project_1.Properties.Resources.page_settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Project_1.Properties.Resources.balloon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::Project_1.Properties.Resources.exit;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // pagemenu
            // 
            this.pagemenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renamepage,
            this.deletepageToolStripMenuItem});
            this.pagemenu.Name = "pagemenu";
            this.pagemenu.Size = new System.Drawing.Size(162, 48);
            // 
            // renamepage
            // 
            this.renamepage.Image = global::Project_1.Properties.Resources.cancel;
            this.renamepage.Name = "renamepage";
            this.renamepage.Size = new System.Drawing.Size(161, 22);
            this.renamepage.Text = "Переименовать";
            this.renamepage.Click += new System.EventHandler(this.renamepage_Click);
            // 
            // deletepageToolStripMenuItem
            // 
            this.deletepageToolStripMenuItem.Image = global::Project_1.Properties.Resources.delete_1;
            this.deletepageToolStripMenuItem.Name = "deletepageToolStripMenuItem";
            this.deletepageToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deletepageToolStripMenuItem.Text = "Удалить";
            this.deletepageToolStripMenuItem.Click += new System.EventHandler(this.deletepageToolStripMenuItem_Click);
            // 
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(264, 541);
            this.ContextMenuStrip = this.tabmenu;
            this.Controls.Add(this.status);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainfrm";
            this.ShowInTaskbar = false;
            this.Text = "Twinx v3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabmenu.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.traymenu.ResumeLayout(false);
            this.pagemenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl table;
        private System.Windows.Forms.ContextMenuStrip tabmenu;
        private System.Windows.Forms.ToolStripMenuItem addpage;
        private System.Windows.Forms.ToolStripMenuItem savebtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem deletepage;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.NotifyIcon trayicon;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.ContextMenuStrip traymenu;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveasiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveasxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip pagemenu;
        private System.Windows.Forms.ToolStripMenuItem renamepage;
        private System.Windows.Forms.ToolStripMenuItem deletepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel typeofsave;
        private System.Windows.Forms.ToolStripStatusLabel loadcount;
        public System.Windows.Forms.ToolStripProgressBar loadbar;
    }
}

