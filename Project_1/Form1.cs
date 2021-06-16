using datas;
using IniFiles;
using PWDSAVER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace Project_1
{
    [Serializable]
    public partial class mainfrm : Form
    {
        //Создание коллекций контролов
        List<TabPage> pages = new List<TabPage>();
        List<TextBox> logins = new List<TextBox>();
        List<TextBox> passwords = new List<TextBox>();
        List<Label> names = new List<Label>();

        Datas list = new Datas();
        TextBox[] log;
        Label[] nam;
        TextBox[] pass;
        TabPage[] newtab;
        const string Progname = "Twinx v3";
        private bool hide;
        string savingfile;
        string backup;
        int pos;

        int n = 12;
        int space = 0;
        int a = 1;
        int cnt = 1;
        int x = 1;

        DateTime DTN;
        string t = " ";

        public mainfrm()
        {
            InitializeComponent();
        }

        public void ApplicationExit()
        {
            var settings = new IniFile(@"settings.ini");
            savingfile = settings.Read("ext", "Settings");
            //сохранение данных при закрытии приложения            
            //if (savingfile == "xml")
            //{
            //    saveasxmlToolStripMenuItem.Checked = true;
            //    saveasiniToolStripMenuItem.Checked = false;
            //    //Загрузка данных из XML
            //    File.Delete(@"data.xml");
            //    saveasxml();
            //    Application.Exit();
            //}
            //if (savingfile == "ini")
            //{
            //    saveasiniToolStripMenuItem.Checked = true;
            //    saveasxmlToolStripMenuItem.Checked = false;
            //    //Загрузка данных из INI
            //    File.Delete(@"data.ini");
            //    saveasini();
            //    Application.Exit();
            //}
            Application.Exit();
        }

        public void loadfromxml()
        {
            try
            {
                list.LoadListOfDatas("data.xml");

                for (int i = 0; i < list.Count(); i++)
                {
                    names[i].Text = list.ReturnDatas(i).Name;
                    logins[i].Text = list.ReturnDatas(i).Login;
                    passwords[i].Text = list.ReturnDatas(i).Password;
                }
            }
            catch (Exception err1)
            {
                MessageBox.Show(list.Count().ToString());
            }

        }

        public void saveasxml()
        {
            var settings = new IniFile(@"settings.ini");
            cnt = Convert.ToInt32(settings.Read("Pages", "Settings"));

            try
            {
                for (int j = 0; j < cnt; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Account data = new Account();
                        data.Name = names[i].Text;
                        data.Login = logins[i].Text;
                        data.Password = passwords[i].Text;
                        list.AddData(data);
                    }
                    list.SaveListOfDatas("data.xml");
                }
            }
            catch (Exception err2)
            {
                MessageBox.Show(names.Count.ToString());
            }
        }

        public void saveasini()
        {
            try
            {
                var data = new IniFile(@"data.ini");
                var settings = new IniFile(@"settings.ini");
                //сохранение настроек при закрытии приложения
                settings.Write("Pages", Convert.ToString(table.TabPages.Count), "Settings");

                //сохранение данных при закрытии приложения            
                var allpages = pages.ToArray();
                foreach (TabPage page in allpages)
                {
                    data.Write(page.Name, page.Text, "Pages");
                }

                var allnames = names.ToArray();
                foreach (var name in allnames)
                {
                    data.Write(name.Name, name.Text, "Names");
                }

                var alllogins = logins.ToArray();
                foreach (var login in alllogins)
                {
                    data.Write(login.Name, login.Text, "Logins");
                }

                var allpass = passwords.ToArray();
                foreach (var pass in allpass)
                {
                    data.Write(pass.Name, pass.Text, "Passwords");
                }
            }
            catch (Exception err2)
            {
                MessageBox.Show(names.Count.ToString());
            }
        }

        public void loadfromini()
        {
            try
            {
                var data = new IniFile(@"data.ini");
                var settings = new IniFile(@"settings.ini");

                var allpages = table.TabPages.Cast<TabPage>().ToArray();
                foreach (TabPage page in allpages)
                {
                    page.Text = data.Read(page.Name, "Pages");
                }

                var allnames = names.ToArray();
                for (int i = 0; i < allnames.Length; i++)
                {
                    Label name = allnames[i];
                    name.Text = data.Read(name.Name, "Names");
                }

                var alllogins = logins.ToArray();
                for (int i = 0; i < alllogins.Length; i++)
                {
                    TextBox login = alllogins[i];
                    login.Text = data.Read(login.Name, "Logins");
                }

                var allpass = passwords.ToArray();
                for (int i = 0; i < allpass.Length; i++)
                {
                    TextBox pass = allpass[i];
                    pass.Text = data.Read(pass.Name, "Passwords");
                }
            }
            catch (Exception err3)
            {
                MessageBox.Show(names.Count.ToString());
            }
        }

        private void CopyClick(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                tb.SelectAll();
                tb.Copy();
            }
        }

        private void loginclick(object sender, EventArgs e)
        {
            TextBox log = sender as TextBox;
            if (log != null)
            {
                InputBoxResult test = InputBox.Show("Введите логин:",
                         "Введите логин",
                     "", 100, 0);
                if (test.ReturnCode == DialogResult.OK)
                    log.Text = test.Text;
            }
        }

        private void nameclick(object sender, EventArgs e)
        {
            Label nam = sender as Label;
            if (nam != null)
            {
                InputBoxResult test = InputBox.Show("Введите имя:",
                         "Введите имя",
                     "", 100, 0);
                if (test.ReturnCode == DialogResult.OK)
                    nam.Text = test.Text;
            }
        }

        private void passwordclick(object sender, EventArgs e)
        {
            TextBox pass = sender as TextBox;
            if (pass != null)
            {
                InputBoxResult test = InputBox.Show("Введите пароль:",
                         "Введите пароль",
                     "", 100, 0);
                if (test.ReturnCode == DialogResult.OK)
                    pass.Text = test.Text;
            }
        }

        private void добавитьСтраницуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //добавление страницы page
            var data = new IniFile(@"data.ini");
            TabPage newtab = new TabPage();

            //вызов диалога с именем для создаваемой страницы
            InputBoxResult test = InputBox.Show("Введите подпись страницы",
                         "Введите имя",
                     "noname", 100, 0);
            if (test.ReturnCode == DialogResult.OK)
                newtab.Text = test.Text;
            newtab.Name = "page" + a;
            data.Write(newtab.Name, newtab.Text, "Pages");
            a++;
            pages.Add(newtab);              //добавляние в коллекцию pages
            table.Controls.Add(newtab);     //добавление страницы page на tabcontrol
            table.SelectedTab = newtab;     //выбор активной страницей вновь созданную

            //добавление контролов с логинами
            log = new TextBox[n];
            nam = new Label[n];
            pass = new TextBox[n];

            for (int i = 0; i < n; i++)
            {
                log[i] = new TextBox();
                log[i].Name = "log" + x;
                log[i].Text = "";
                log[i].Tag = x;
                log[i].Width = 120;
                log[i].DoubleClick += new EventHandler(loginclick);
                log[i].Click += new EventHandler(CopyClick);
                log[i].ContextMenuStrip = new ContextMenuStrip();

                nam[i] = new Label();
                nam[i].Name = "nam" + x;
                nam[i].Text = "unnamed";
                nam[i].Tag = x;
                nam[i].DoubleClick += new EventHandler(nameclick);

                pass[i] = new TextBox();
                pass[i].Name = "pass" + x;
                pass[i].Text = "";
                pass[i].Tag = x;
                pass[i].Width = 120;
                pass[i].DoubleClick += new EventHandler(passwordclick);
                pass[i].Click += new EventHandler(CopyClick);
                pass[i].ContextMenuStrip = new ContextMenuStrip();
                x++;
            }
            for (int i = 0; i < n; i++)
            {
                log[i].Visible = true;
                nam[i].Visible = true;
                pass[i].Visible = true;
                pass[i].ReadOnly = true;
                log[i].ReadOnly = true;
                log[i].Location = new Point(5, 20 + space);
                nam[i].Location = new Point(5, 5 + space);
                pass[i].Location = new Point(130, 20 + space);
                newtab.Controls.Add(log[i]);    //добавление на контрол page
                logins.Add(log[i]);             //добавление в коллекцию logins
                newtab.Controls.Add(nam[i]);    //добавление в контрол page
                names.Add(nam[i]);              //добавление в коллекцию names
                newtab.Controls.Add(pass[i]);   //добавление в контрол page
                passwords.Add(pass[i]);         //добавление в коллекцию passwords
                space += 40;
            }
            space = 0;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //Загрузка настроек приложения            
            var settings = new IniFile(@"settings.ini");
            var data = new IniFile(@"data.ini");
            savingfile = settings.Read("ext", "Settings");
            if (File.Exists("settings.ini"))
            {
                Top = Convert.ToInt32(settings.Read("Top", "Settings"));
                Left = Convert.ToInt32(settings.Read("Left", "Settings"));
            }
            else
            {
                settings.Write("ext", "ini", "Settings");
                savingfile = "ini";
                saveasiniToolStripMenuItem.Checked = true;
                this.Top = 300;
                this.Left = 600;
            }
            try
            {
                //  var settings = new IniFile(@"settings.ini");
                cnt = Convert.ToInt32(settings.Read("Pages", "Settings"));
                //добавление страницы page
                TabPage[] newtab = new TabPage[cnt];
                for (int j = 0; j < cnt; j++)
                {
                    newtab[j] = new TabPage();
                    newtab[j].Text = a.ToString();
                    newtab[j].Name = "page" + a;
                    a++;
                    pages.Add(newtab[j]);
                    table.Controls.Add(newtab[j]);
                    // cnt++;

                    //добавление контролов
                    log = new TextBox[n];
                    nam = new Label[n];
                    pass = new TextBox[n];

                    for (int i = 0; i < n; i++)
                    {
                        log[i] = new TextBox();
                        log[i].Name = "log" + x;
                        log[i].Text = "";
                        log[i].Width = 120;
                        log[i].DoubleClick += new EventHandler(loginclick);
                        log[i].Click += new EventHandler(CopyClick);
                        log[i].ContextMenuStrip = new ContextMenuStrip();

                        nam[i] = new Label();
                        nam[i].Name = "nam" + x;
                        nam[i].Text = "unnamed";
                        nam[i].DoubleClick += new EventHandler(nameclick);

                        pass[i] = new TextBox();
                        pass[i].Name = "pass" + x;
                        pass[i].Text = "";
                        pass[i].Width = 120;
                        pass[i].DoubleClick += new EventHandler(passwordclick);
                        pass[i].Click += new EventHandler(CopyClick);
                        pass[i].ContextMenuStrip = new ContextMenuStrip();

                        x++;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        log[i].Visible = true;
                        nam[i].Visible = true;
                        pass[i].Visible = true;
                        pass[i].ReadOnly = true;
                        log[i].ReadOnly = true;
                        log[i].Location = new Point(5, 20 + space);
                        nam[i].Location = new Point(5, 5 + space);
                        pass[i].Location = new Point(130, 20 + space);
                        newtab[j].Controls.Add(log[i]);
                        logins.Add(log[i]);
                        newtab[j].Controls.Add(nam[i]);
                        names.Add(nam[i]);
                        newtab[j].Controls.Add(pass[i]);
                        passwords.Add(pass[i]);
                        space += 40;


                    }
                    space = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, Progname);
                // Application.Restart();
            }
            finally
            {
                savingfile = settings.Read("ext", "Settings");
                if (savingfile == "xml")
                {
                    saveasxmlToolStripMenuItem.Checked = true;
                    saveasiniToolStripMenuItem.Checked = false;
                    //Загрузка данных из XML
                    loadfromxml();
                }
                if (savingfile == "ini")
                {
                    saveasxmlToolStripMenuItem.Checked = false;
                    saveasiniToolStripMenuItem.Checked = true;
                    //Загрузка данных из INI
                    loadfromini();
                }
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (t == " ")
                t = ":";
            else
                t = " ";
            DTN = DateTime.Now;
            typeofsave.Text = savingfile;
            statuslabel.Text = DTN.Hour.ToString().PadLeft(2, '0') + t +
                DTN.Minute.ToString().PadLeft(2, '0') + t +
                    DTN.Second.ToString().PadLeft(2, '0');

            //loadcount.Text = list.Count().ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            var settings = new IniFile(@"settings.ini");
            //сохранение настроек при закрытии приложения
            settings.Write("Pages", Convert.ToString(table.TabPages.Count), "Settings");
            settings.Write("Top", Top.ToString(), "Settings");
            settings.Write("Left", Left.ToString(), "Settings");
            savingfile = settings.Read("ext", "Settings");

            //сохранение данных при закрытии приложения            
            if (savingfile == "xml")
            {
                //Загрузка данных из XML
                if (File.Exists(@"data.xml"))
                {
                    //  File.Delete(@"data.xml");
                }
                else
                {
                    saveasxml();
                }
            }
            if (savingfile == "ini")
            {
                //Загрузка данных из INI
                if (File.Exists(@"data.ini"))
                {

                }
                else
                {
                    saveasini();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deletepage_Click(object sender, EventArgs e)
        {
            var settings = new IniFile(@"settings.ini");
            cnt = Convert.ToInt32(settings.Read("Pages", "Settings"));
            if (table.TabPages.Count != 1)
            {
                var tb = table.SelectedTab;
                table.TabPages.Remove(tb);
                MessageBox.Show(names.Count.ToString());
                names.ElementAt(table.TabIndex);
            }
            else
            {
                MessageBox.Show("Нельзя удалить", Progname);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (savingfile == "xml")
            {

                MessageBox.Show(names.Count.ToString());
                if (File.Exists(@"data.xml"))
                {
                    //
                }
                else
                {
                    saveasxml();
                }
            }

            if (savingfile == "ini")
            {
                File.Delete(@"data.ini");
                MessageBox.Show(names.Count.ToString());
                if (File.Exists(@"data.ini"))
                {
                    //
                }
                else
                {
                    saveasini();
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hide == true)
            {
                this.Show();
            }
            if (hide == false)
            {
                this.Hide();
            }
        }

        private void traymenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.Visible == true)
            {
                downToolStripMenuItem.Text = "Свернуть";
                downToolStripMenuItem.Image = Project_1.Properties.Resources.down;
                hide = false;
            }
            if (this.Visible == false)
            {
                downToolStripMenuItem.Text = "Развернуть";
                downToolStripMenuItem.Image = Project_1.Properties.Resources.up;
                hide = true;
            }
        }

        private void deletepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (table.TabPages.Count != 1)
            {
                var tb = table.SelectedTab;
                table.TabPages.Remove(tb);
                // pages.Remove(tb);
                //    tb.Controls.Remove(tb.Controls[stb]);
            }
            else
            {
                MessageBox.Show("Нельзя удалить", Progname);
            }
        }

        private void renamepage_Click(object sender, EventArgs e)
        {
            TabPage tb = sender as TabPage;
            if (tb != null)
            {
                InputBoxResult test = InputBox.Show("Введите название вкладки",
                        "Введите название",
                        "", 100, 0);
                if (test.ReturnCode == DialogResult.OK)
                    tb.Text = test.Text;
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Создание резервной копии данных
                backup = "archive.zip";

                //Архивация файла данных
                if (File.Exists("archive.zip"))
                {
                    // System.IO.File.Delete(@"archive.zip");
                    string archivePath = backup;
                    using (ZipArchive zipArchive = ZipFile.Open(archivePath, ZipArchiveMode.Create))
                    {
                        if (savingfile == "ini")
                        {
                            const string pathFileToAdd = @"data.ini";
                            const string nameFileToAdd = "data.ini";
                            zipArchive.CreateEntryFromFile(pathFileToAdd, nameFileToAdd);

                        }
                        if (savingfile == "xml")
                        {
                            const string pathFileToAdd = @"data.xml";
                            const string nameFileToAdd = "data.xml";
                            zipArchive.CreateEntryFromFile(pathFileToAdd, nameFileToAdd);
                        }

                    }
                }
                else
                {
                    const string archivePath = @"archive.zip";
                    using (ZipArchive zipArchive = ZipFile.Open(archivePath, ZipArchiveMode.Create))
                    {
                        if (savingfile == "ini")
                        {
                            const string pathFileToAdd = @"data.ini";
                            const string nameFileToAdd = "data.ini";
                            zipArchive.CreateEntryFromFile(pathFileToAdd, nameFileToAdd);

                        }
                        if (savingfile == "xml")
                        {
                            const string pathFileToAdd = @"data.xml";
                            const string nameFileToAdd = "data.xml";
                            zipArchive.CreateEntryFromFile(pathFileToAdd, nameFileToAdd);
                        }

                    }
                }
                MessageBox.Show("Резервная копия создана!", "Twinx");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
                Application.Restart();
            }
        }

        private void saveasiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сохранение данных в файл INI
            var settings = new IniFile(@"settings.ini");
            if (saveasiniToolStripMenuItem.Checked != false)
            {
                saveasiniToolStripMenuItem.Checked = true;
                saveasxmlToolStripMenuItem.Checked = false;
                settings.Write("ext", "ini", "Settings");
                savingfile = "ini";
                saveasini();
                System.IO.File.Delete(@"data.xml");
            }
            else
            {
                saveasiniToolStripMenuItem.Checked = false;
                saveasxmlToolStripMenuItem.Checked = true;
                settings.Write("ext", "xml", "Settings");
                savingfile = "xml";
            }
        }

        private void saveasxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сохранение данных в файл XML
            var settings = new IniFile(@"settings.ini");
            if (saveasxmlToolStripMenuItem.Checked != false)
            {
                saveasxmlToolStripMenuItem.Checked = true;
                saveasiniToolStripMenuItem.Checked = false;
                settings.Write("ext", "xml", "Settings");
                savingfile = "xml";
                saveasxml();
                System.IO.File.Delete(@"data.ini");
            }
            else
            {
                saveasxmlToolStripMenuItem.Checked = false;
                saveasiniToolStripMenuItem.Checked = true;
                settings.Write("ext", "ini", "Settings");
                savingfile = "ini";
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Twinx. Версия 3 \nПрограмма для хранения данных (логин, пароль)", Progname);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Twinx. Версия 3 \nПрограмма для хранения данных (логин, пароль)", Progname);
        }
    }
}
