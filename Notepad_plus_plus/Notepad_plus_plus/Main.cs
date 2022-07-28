using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_plus_plus
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public string Rename
        {
            set { tc_Notepad.SelectedTab.Text = value; }
            get { return tc_Notepad.SelectedTab.Text; }
        }

        int a = 2;

        public void tsmi_file_new_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("new" + a);
            FastColoredTextBox fctb = new FastColoredTextBox();
            fctb.Dock = DockStyle.Fill;

            tp.Controls.Add(fctb);
            tc_Notepad.TabPages.Add(tp);

            a++;
        }

        private void tsmi_file_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                fctb_notepad.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void tsmi_file_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(fctb_notepad.Text);
                sw.Close();
            }
        }

        private void tsmi_file_saveas_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(fctb_notepad.Text);
                sw.Close();
            }
        }

        private void tsmi_file_rename_Click(object sender, EventArgs e)
        {
            Rename r = new Rename(this);
            if (r.ShowDialog() == DialogResult.OK)
            {
                tc_Notepad.SelectedTab.Text = Rename;
                r.Close();
            }
        }

        private void tsmi_file_close_Click(object sender, EventArgs e)
        {
            string message = "Save File '" + tc_Notepad.SelectedTab.Text + "'? ";
            DialogResult result;

            result = MessageBox.Show(message, "Save", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text File|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine(fctb_notepad.Text);
                    sw.Close();
                }
            }
            else if(result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void tsmi_file_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(fctb_notepad.Text,new Font("Times New Roman",14,FontStyle.Regular),Brushes.Black,new PointF(100,100));
        }

        private void tsmi_file_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmi_edit_undo_Click(object sender, EventArgs e)
        {
            fctb_notepad.Undo();
        }

        private void tsmi_edit_redo_Click(object sender, EventArgs e)
        {
            fctb_notepad.Redo();
        }

        private void tsmi_edit_cut_Click(object sender, EventArgs e)
        {
            fctb_notepad.Cut();
        }

        private void tsmi_edit_copy_Click(object sender, EventArgs e)
        {
            fctb_notepad.Copy();
        }

        private void tsmi_edit_paste_Click(object sender, EventArgs e)
        {
            fctb_notepad.Paste();
        }

        private void tsmi_edit_delete_Click(object sender, EventArgs e)
        {
            fctb_notepad.Clear();
        }

        private void tsmi_edit_selectall_Click(object sender, EventArgs e)
        {
            fctb_notepad.SelectAll();
        }

        private void tsmi_edit_copyToClipboard_Click(object sender, EventArgs e)
        {
            fctb_notepad.Copy();
        }

        private void setLanguage(FastColoredTextBoxNS.Language lang)
        {
            fctb_notepad.Language = lang;
        }
        private void tsmi_language_cSharp_Click(object sender, EventArgs e)
        {
            setLanguage(FastColoredTextBoxNS.Language.CSharp);
        }

        private void tsmi_language_html_Click_1(object sender, EventArgs e)
        {
            setLanguage(FastColoredTextBoxNS.Language.HTML);
        }


        private void tsmi_language_javaScript_Click(object sender, EventArgs e)
        {
            setLanguage(FastColoredTextBoxNS.Language.JS);
        }

        private void tsmi_language_json_Click(object sender, EventArgs e)
        {
            setLanguage(FastColoredTextBoxNS.Language.JSON);
        }

        private void tsmi_language_lua_Click(object sender, EventArgs e)
        {
            setLanguage(FastColoredTextBoxNS.Language.Lua);
        }

        private void tsmi_language_php_Click(object sender, EventArgs e)
        {
            setLanguage(FastColoredTextBoxNS.Language.PHP);
        }

        private void tsmi_language_sql_Click(object sender, EventArgs e)
        {
            setLanguage(FastColoredTextBoxNS.Language.SQL);
        }

        private void tsmi_language_xml_Click(object sender, EventArgs e)
        {
            setLanguage(FastColoredTextBoxNS.Language.XML);
        }

        private void ts_new_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("new" + a);
            FastColoredTextBox fctb = new FastColoredTextBox();
            fctb.Dock = DockStyle.Fill;

            tp.Controls.Add(fctb);
            tc_Notepad.TabPages.Add(tp);

            a++;
        }

        private void ts_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                fctb_notepad.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void ts_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(fctb_notepad.Text);
                sw.Close();
            }
        }

        private void ts_saveAll_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(fctb_notepad.Text);
                sw.Close();
            }
        }

        private void ts_close_Click(object sender, EventArgs e)
        {
            string message = "Save File '" + tc_Notepad.SelectedTab.Text + "'?";
            DialogResult result;

            result = MessageBox.Show(message, "Save", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text File|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine(fctb_notepad.Text);
                    sw.Close();
                }
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void ts_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void ts_cut_Click(object sender, EventArgs e)
        {
            fctb_notepad.Cut();
        }

        private void ts_copy_Click(object sender, EventArgs e)
        {
            fctb_notepad.Copy();
        }

        private void ts_paste_Click(object sender, EventArgs e)
        {
            fctb_notepad.Paste();
        }

        private void ts_undo_Click(object sender, EventArgs e)
        {
            fctb_notepad.Undo();
        }

        private void ts_redo_Click(object sender, EventArgs e)
        {
            fctb_notepad.Redo();
        }

        private void ts_wordWrap_Click(object sender, EventArgs e)
        {
            if(ts_wordWrap.Checked == false)
            {
                ts_wordWrap.Checked = true;
                fctb_notepad.WordWrap = true;
            }
            else
            {
                ts_wordWrap.Checked = false;
                fctb_notepad.WordWrap = false;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(font_dialog.ShowDialog() == DialogResult.OK)
            {
                fctb_notepad.Font = font_dialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(color_dialog.ShowDialog() == DialogResult.OK)
            {
                fctb_notepad.ForeColor = color_dialog.Color;
            }
        }

        private void tsmi_about_Click(object sender, EventArgs e)
        {
            using (About about = new About())
            {
                about.ShowDialog();
            }
        }

        private void tsmi_view_wordWrap_Click(object sender, EventArgs e)
        {
            if (tsmi_view_wordWrap.Checked == false)
            {
                tsmi_view_wordWrap.Checked = true;
                fctb_notepad.WordWrap = true;
            }
            else
            {
                tsmi_view_wordWrap.Checked = false;
                fctb_notepad.WordWrap = false;
            }
        }
    }
}