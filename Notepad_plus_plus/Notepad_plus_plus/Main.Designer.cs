
namespace Notepad_plus_plus
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_rename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_file_print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_edit_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit_selectall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_view = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_view_wordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language_cSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language_html = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language_j = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language_javaScript = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language_json = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language_l = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language_php = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language_sql = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_language_xml = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_font = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_coor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ts_new = new System.Windows.Forms.ToolStripButton();
            this.ts_open = new System.Windows.Forms.ToolStripButton();
            this.ts_save = new System.Windows.Forms.ToolStripButton();
            this.ts_saveAll = new System.Windows.Forms.ToolStripButton();
            this.ts_close = new System.Windows.Forms.ToolStripButton();
            this.ts_print = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Separator2_1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_cut = new System.Windows.Forms.ToolStripButton();
            this.ts_copy = new System.Windows.Forms.ToolStripButton();
            this.ts_paste = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Separator2_2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_undo = new System.Windows.Forms.ToolStripButton();
            this.ts_redo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Separator2_3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_wordWrap = new System.Windows.Forms.ToolStripButton();
            this.tc_Notepad = new System.Windows.Forms.TabControl();
            this.tp_1 = new System.Windows.Forms.TabPage();
            this.fctb_notepad = new FastColoredTextBoxNS.FastColoredTextBox();
            this.color_dialog = new System.Windows.Forms.ColorDialog();
            this.font_dialog = new System.Windows.Forms.FontDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tc_Notepad.SuspendLayout();
            this.tp_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctb_notepad)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_edit,
            this.tsmi_view,
            this.tsmi_language,
            this.tsmi_settings,
            this.tsmi_about});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(848, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip3";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file_new,
            this.tsmi_file_open,
            this.tsmi_file_save,
            this.tsmi_file_saveas,
            this.tsmi_file_rename,
            this.tsmi_file_close,
            this.toolStrip_Separator1,
            this.tsmi_file_print,
            this.toolStrip_Separator2,
            this.tsmi_file_exit});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(37, 20);
            this.tsmi_file.Text = "File";
            // 
            // tsmi_file_new
            // 
            this.tsmi_file_new.Name = "tsmi_file_new";
            this.tsmi_file_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_file_new.Size = new System.Drawing.Size(177, 22);
            this.tsmi_file_new.Text = "New";
            this.tsmi_file_new.Click += new System.EventHandler(this.tsmi_file_new_Click);
            // 
            // tsmi_file_open
            // 
            this.tsmi_file_open.Name = "tsmi_file_open";
            this.tsmi_file_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmi_file_open.Size = new System.Drawing.Size(177, 22);
            this.tsmi_file_open.Text = "Open";
            this.tsmi_file_open.Click += new System.EventHandler(this.tsmi_file_open_Click);
            // 
            // tsmi_file_save
            // 
            this.tsmi_file_save.Name = "tsmi_file_save";
            this.tsmi_file_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_file_save.Size = new System.Drawing.Size(177, 22);
            this.tsmi_file_save.Text = "Save";
            this.tsmi_file_save.Click += new System.EventHandler(this.tsmi_file_save_Click);
            // 
            // tsmi_file_saveas
            // 
            this.tsmi_file_saveas.Name = "tsmi_file_saveas";
            this.tsmi_file_saveas.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.tsmi_file_saveas.Size = new System.Drawing.Size(177, 22);
            this.tsmi_file_saveas.Text = "Save As";
            this.tsmi_file_saveas.Click += new System.EventHandler(this.tsmi_file_saveas_Click);
            // 
            // tsmi_file_rename
            // 
            this.tsmi_file_rename.Name = "tsmi_file_rename";
            this.tsmi_file_rename.Size = new System.Drawing.Size(177, 22);
            this.tsmi_file_rename.Text = "Rename...";
            this.tsmi_file_rename.Click += new System.EventHandler(this.tsmi_file_rename_Click);
            // 
            // tsmi_file_close
            // 
            this.tsmi_file_close.Name = "tsmi_file_close";
            this.tsmi_file_close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tsmi_file_close.Size = new System.Drawing.Size(177, 22);
            this.tsmi_file_close.Text = "Close";
            this.tsmi_file_close.Click += new System.EventHandler(this.tsmi_file_close_Click);
            // 
            // toolStrip_Separator1
            // 
            this.toolStrip_Separator1.Name = "toolStrip_Separator1";
            this.toolStrip_Separator1.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmi_file_print
            // 
            this.tsmi_file_print.Name = "tsmi_file_print";
            this.tsmi_file_print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmi_file_print.Size = new System.Drawing.Size(177, 22);
            this.tsmi_file_print.Text = "Print";
            this.tsmi_file_print.Click += new System.EventHandler(this.tsmi_file_print_Click);
            // 
            // toolStrip_Separator2
            // 
            this.toolStrip_Separator2.Name = "toolStrip_Separator2";
            this.toolStrip_Separator2.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmi_file_exit
            // 
            this.tsmi_file_exit.Name = "tsmi_file_exit";
            this.tsmi_file_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmi_file_exit.Size = new System.Drawing.Size(177, 22);
            this.tsmi_file_exit.Text = "Exit";
            this.tsmi_file_exit.Click += new System.EventHandler(this.tsmi_file_exit_Click);
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_edit_undo,
            this.tsmi_edit_redo,
            this.toolStrip_Separator3,
            this.tsmi_edit_cut,
            this.tsmi_edit_copy,
            this.tsmi_edit_paste,
            this.tsmi_edit_delete,
            this.tsmi_edit_selectall});
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Size = new System.Drawing.Size(39, 20);
            this.tsmi_edit.Text = "Edit";
            // 
            // tsmi_edit_undo
            // 
            this.tsmi_edit_undo.Name = "tsmi_edit_undo";
            this.tsmi_edit_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmi_edit_undo.Size = new System.Drawing.Size(164, 22);
            this.tsmi_edit_undo.Text = "Undo";
            this.tsmi_edit_undo.Click += new System.EventHandler(this.tsmi_edit_undo_Click);
            // 
            // tsmi_edit_redo
            // 
            this.tsmi_edit_redo.Name = "tsmi_edit_redo";
            this.tsmi_edit_redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmi_edit_redo.Size = new System.Drawing.Size(164, 22);
            this.tsmi_edit_redo.Text = "Redo";
            this.tsmi_edit_redo.Click += new System.EventHandler(this.tsmi_edit_redo_Click);
            // 
            // toolStrip_Separator3
            // 
            this.toolStrip_Separator3.Name = "toolStrip_Separator3";
            this.toolStrip_Separator3.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmi_edit_cut
            // 
            this.tsmi_edit_cut.Name = "tsmi_edit_cut";
            this.tsmi_edit_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmi_edit_cut.Size = new System.Drawing.Size(164, 22);
            this.tsmi_edit_cut.Text = "Cut";
            this.tsmi_edit_cut.Click += new System.EventHandler(this.tsmi_edit_cut_Click);
            // 
            // tsmi_edit_copy
            // 
            this.tsmi_edit_copy.Name = "tsmi_edit_copy";
            this.tsmi_edit_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmi_edit_copy.Size = new System.Drawing.Size(164, 22);
            this.tsmi_edit_copy.Text = "Copy";
            this.tsmi_edit_copy.Click += new System.EventHandler(this.tsmi_edit_copy_Click);
            // 
            // tsmi_edit_paste
            // 
            this.tsmi_edit_paste.Name = "tsmi_edit_paste";
            this.tsmi_edit_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmi_edit_paste.Size = new System.Drawing.Size(164, 22);
            this.tsmi_edit_paste.Text = "Paste";
            this.tsmi_edit_paste.Click += new System.EventHandler(this.tsmi_edit_paste_Click);
            // 
            // tsmi_edit_delete
            // 
            this.tsmi_edit_delete.Name = "tsmi_edit_delete";
            this.tsmi_edit_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmi_edit_delete.Size = new System.Drawing.Size(164, 22);
            this.tsmi_edit_delete.Text = "Delete";
            this.tsmi_edit_delete.Click += new System.EventHandler(this.tsmi_edit_delete_Click);
            // 
            // tsmi_edit_selectall
            // 
            this.tsmi_edit_selectall.Name = "tsmi_edit_selectall";
            this.tsmi_edit_selectall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmi_edit_selectall.Size = new System.Drawing.Size(164, 22);
            this.tsmi_edit_selectall.Text = "Select All";
            this.tsmi_edit_selectall.Click += new System.EventHandler(this.tsmi_edit_selectall_Click);
            // 
            // tsmi_view
            // 
            this.tsmi_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_view_wordWrap});
            this.tsmi_view.Name = "tsmi_view";
            this.tsmi_view.Size = new System.Drawing.Size(44, 20);
            this.tsmi_view.Text = "View";
            // 
            // tsmi_view_wordWrap
            // 
            this.tsmi_view_wordWrap.Name = "tsmi_view_wordWrap";
            this.tsmi_view_wordWrap.Size = new System.Drawing.Size(134, 22);
            this.tsmi_view_wordWrap.Text = "Word Wrap";
            this.tsmi_view_wordWrap.Click += new System.EventHandler(this.tsmi_view_wordWrap_Click);
            // 
            // tsmi_language
            // 
            this.tsmi_language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_language_cSharp,
            this.tsmi_language_html,
            this.tsmi_language_j,
            this.tsmi_language_l,
            this.tsmi_language_php,
            this.tsmi_language_sql,
            this.tsmi_language_xml});
            this.tsmi_language.Name = "tsmi_language";
            this.tsmi_language.Size = new System.Drawing.Size(71, 20);
            this.tsmi_language.Text = "Language";
            // 
            // tsmi_language_cSharp
            // 
            this.tsmi_language_cSharp.Name = "tsmi_language_cSharp";
            this.tsmi_language_cSharp.Size = new System.Drawing.Size(180, 22);
            this.tsmi_language_cSharp.Text = "C#";
            this.tsmi_language_cSharp.Click += new System.EventHandler(this.tsmi_language_cSharp_Click);
            // 
            // tsmi_language_html
            // 
            this.tsmi_language_html.Name = "tsmi_language_html";
            this.tsmi_language_html.Size = new System.Drawing.Size(180, 22);
            this.tsmi_language_html.Text = "HTML";
            this.tsmi_language_html.Click += new System.EventHandler(this.tsmi_language_html_Click_1);
            // 
            // tsmi_language_j
            // 
            this.tsmi_language_j.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_language_javaScript,
            this.tsmi_language_json});
            this.tsmi_language_j.Name = "tsmi_language_j";
            this.tsmi_language_j.Size = new System.Drawing.Size(180, 22);
            this.tsmi_language_j.Text = "J";
            // 
            // tsmi_language_javaScript
            // 
            this.tsmi_language_javaScript.Name = "tsmi_language_javaScript";
            this.tsmi_language_javaScript.Size = new System.Drawing.Size(126, 22);
            this.tsmi_language_javaScript.Text = "JavaScript";
            this.tsmi_language_javaScript.Click += new System.EventHandler(this.tsmi_language_javaScript_Click);
            // 
            // tsmi_language_json
            // 
            this.tsmi_language_json.Name = "tsmi_language_json";
            this.tsmi_language_json.Size = new System.Drawing.Size(126, 22);
            this.tsmi_language_json.Text = "JSON";
            this.tsmi_language_json.Click += new System.EventHandler(this.tsmi_language_json_Click);
            // 
            // tsmi_language_l
            // 
            this.tsmi_language_l.Name = "tsmi_language_l";
            this.tsmi_language_l.Size = new System.Drawing.Size(180, 22);
            this.tsmi_language_l.Text = "Lua";
            // 
            // tsmi_language_php
            // 
            this.tsmi_language_php.Name = "tsmi_language_php";
            this.tsmi_language_php.Size = new System.Drawing.Size(180, 22);
            this.tsmi_language_php.Text = "PHP";
            this.tsmi_language_php.Click += new System.EventHandler(this.tsmi_language_php_Click);
            // 
            // tsmi_language_sql
            // 
            this.tsmi_language_sql.Name = "tsmi_language_sql";
            this.tsmi_language_sql.Size = new System.Drawing.Size(180, 22);
            this.tsmi_language_sql.Text = "SQL";
            this.tsmi_language_sql.Click += new System.EventHandler(this.tsmi_language_sql_Click);
            // 
            // tsmi_language_xml
            // 
            this.tsmi_language_xml.Name = "tsmi_language_xml";
            this.tsmi_language_xml.Size = new System.Drawing.Size(180, 22);
            this.tsmi_language_xml.Text = "XML";
            this.tsmi_language_xml.Click += new System.EventHandler(this.tsmi_language_xml_Click);
            // 
            // tsmi_settings
            // 
            this.tsmi_settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_font,
            this.tsmi_coor});
            this.tsmi_settings.Name = "tsmi_settings";
            this.tsmi_settings.Size = new System.Drawing.Size(61, 20);
            this.tsmi_settings.Text = "Settings";
            // 
            // tsmi_font
            // 
            this.tsmi_font.Name = "tsmi_font";
            this.tsmi_font.Size = new System.Drawing.Size(103, 22);
            this.tsmi_font.Text = "Font";
            this.tsmi_font.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // tsmi_coor
            // 
            this.tsmi_coor.Name = "tsmi_coor";
            this.tsmi_coor.Size = new System.Drawing.Size(103, 22);
            this.tsmi_coor.Text = "Color";
            this.tsmi_coor.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // tsmi_about
            // 
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(24, 20);
            this.tsmi_about.Text = "?";
            this.tsmi_about.Click += new System.EventHandler(this.tsmi_about_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_new,
            this.ts_open,
            this.ts_save,
            this.ts_saveAll,
            this.ts_close,
            this.ts_print,
            this.toolStrip_Separator2_1,
            this.ts_cut,
            this.ts_copy,
            this.ts_paste,
            this.toolStrip_Separator2_2,
            this.ts_undo,
            this.ts_redo,
            this.toolStrip_Separator2_3,
            this.ts_wordWrap});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(848, 25);
            this.toolStrip.TabIndex = 8;
            this.toolStrip.Text = "toolStrip1";
            // 
            // ts_new
            // 
            this.ts_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_new.Image = ((System.Drawing.Image)(resources.GetObject("ts_new.Image")));
            this.ts_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_new.Name = "ts_new";
            this.ts_new.Size = new System.Drawing.Size(23, 22);
            this.ts_new.Text = "New";
            this.ts_new.Click += new System.EventHandler(this.ts_new_Click);
            // 
            // ts_open
            // 
            this.ts_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_open.Image = ((System.Drawing.Image)(resources.GetObject("ts_open.Image")));
            this.ts_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_open.Name = "ts_open";
            this.ts_open.Size = new System.Drawing.Size(23, 22);
            this.ts_open.Text = "Open";
            this.ts_open.Click += new System.EventHandler(this.ts_open_Click);
            // 
            // ts_save
            // 
            this.ts_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_save.Image = ((System.Drawing.Image)(resources.GetObject("ts_save.Image")));
            this.ts_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_save.Name = "ts_save";
            this.ts_save.Size = new System.Drawing.Size(23, 22);
            this.ts_save.Text = "Save";
            this.ts_save.Click += new System.EventHandler(this.ts_save_Click);
            // 
            // ts_saveAll
            // 
            this.ts_saveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_saveAll.Image = ((System.Drawing.Image)(resources.GetObject("ts_saveAll.Image")));
            this.ts_saveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_saveAll.Name = "ts_saveAll";
            this.ts_saveAll.Size = new System.Drawing.Size(23, 22);
            this.ts_saveAll.Text = "Save All";
            this.ts_saveAll.Click += new System.EventHandler(this.ts_saveAll_Click);
            // 
            // ts_close
            // 
            this.ts_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_close.Image = ((System.Drawing.Image)(resources.GetObject("ts_close.Image")));
            this.ts_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_close.Name = "ts_close";
            this.ts_close.Size = new System.Drawing.Size(23, 22);
            this.ts_close.Text = "Close";
            this.ts_close.Click += new System.EventHandler(this.ts_close_Click);
            // 
            // ts_print
            // 
            this.ts_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_print.Image = ((System.Drawing.Image)(resources.GetObject("ts_print.Image")));
            this.ts_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_print.Name = "ts_print";
            this.ts_print.Size = new System.Drawing.Size(23, 22);
            this.ts_print.Text = "Print";
            this.ts_print.Click += new System.EventHandler(this.ts_print_Click);
            // 
            // toolStrip_Separator2_1
            // 
            this.toolStrip_Separator2_1.Name = "toolStrip_Separator2_1";
            this.toolStrip_Separator2_1.Size = new System.Drawing.Size(6, 25);
            // 
            // ts_cut
            // 
            this.ts_cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_cut.Image = ((System.Drawing.Image)(resources.GetObject("ts_cut.Image")));
            this.ts_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_cut.Name = "ts_cut";
            this.ts_cut.Size = new System.Drawing.Size(23, 22);
            this.ts_cut.Text = "Cut";
            this.ts_cut.Click += new System.EventHandler(this.ts_cut_Click);
            // 
            // ts_copy
            // 
            this.ts_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_copy.Image = ((System.Drawing.Image)(resources.GetObject("ts_copy.Image")));
            this.ts_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_copy.Name = "ts_copy";
            this.ts_copy.Size = new System.Drawing.Size(23, 22);
            this.ts_copy.Text = "Copy";
            this.ts_copy.Click += new System.EventHandler(this.ts_copy_Click);
            // 
            // ts_paste
            // 
            this.ts_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_paste.Image = ((System.Drawing.Image)(resources.GetObject("ts_paste.Image")));
            this.ts_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_paste.Name = "ts_paste";
            this.ts_paste.Size = new System.Drawing.Size(23, 22);
            this.ts_paste.Text = "Paste";
            this.ts_paste.Click += new System.EventHandler(this.ts_paste_Click);
            // 
            // toolStrip_Separator2_2
            // 
            this.toolStrip_Separator2_2.Name = "toolStrip_Separator2_2";
            this.toolStrip_Separator2_2.Size = new System.Drawing.Size(6, 25);
            // 
            // ts_undo
            // 
            this.ts_undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_undo.Image = ((System.Drawing.Image)(resources.GetObject("ts_undo.Image")));
            this.ts_undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_undo.Name = "ts_undo";
            this.ts_undo.Size = new System.Drawing.Size(23, 22);
            this.ts_undo.Text = "Undo";
            this.ts_undo.Click += new System.EventHandler(this.ts_undo_Click);
            // 
            // ts_redo
            // 
            this.ts_redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_redo.Image = ((System.Drawing.Image)(resources.GetObject("ts_redo.Image")));
            this.ts_redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_redo.Name = "ts_redo";
            this.ts_redo.Size = new System.Drawing.Size(23, 22);
            this.ts_redo.Text = "Redo";
            this.ts_redo.Click += new System.EventHandler(this.ts_redo_Click);
            // 
            // toolStrip_Separator2_3
            // 
            this.toolStrip_Separator2_3.Name = "toolStrip_Separator2_3";
            this.toolStrip_Separator2_3.Size = new System.Drawing.Size(6, 25);
            // 
            // ts_wordWrap
            // 
            this.ts_wordWrap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_wordWrap.Image = ((System.Drawing.Image)(resources.GetObject("ts_wordWrap.Image")));
            this.ts_wordWrap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_wordWrap.Name = "ts_wordWrap";
            this.ts_wordWrap.Size = new System.Drawing.Size(23, 22);
            this.ts_wordWrap.Text = "Word wrap";
            this.ts_wordWrap.Click += new System.EventHandler(this.ts_wordWrap_Click);
            // 
            // tc_Notepad
            // 
            this.tc_Notepad.Controls.Add(this.tp_1);
            this.tc_Notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Notepad.Location = new System.Drawing.Point(0, 49);
            this.tc_Notepad.Name = "tc_Notepad";
            this.tc_Notepad.SelectedIndex = 0;
            this.tc_Notepad.Size = new System.Drawing.Size(848, 375);
            this.tc_Notepad.TabIndex = 1;
            // 
            // tp_1
            // 
            this.tp_1.Controls.Add(this.fctb_notepad);
            this.tp_1.Location = new System.Drawing.Point(4, 22);
            this.tp_1.Name = "tp_1";
            this.tp_1.Size = new System.Drawing.Size(840, 349);
            this.tp_1.TabIndex = 0;
            this.tp_1.Text = "new 1";
            this.tp_1.UseVisualStyleBackColor = true;
            // 
            // fctb_notepad
            // 
            this.fctb_notepad.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctb_notepad.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fctb_notepad.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctb_notepad.BackBrush = null;
            this.fctb_notepad.CharHeight = 14;
            this.fctb_notepad.CharWidth = 8;
            this.fctb_notepad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctb_notepad.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctb_notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctb_notepad.IsReplaceMode = false;
            this.fctb_notepad.Location = new System.Drawing.Point(0, 0);
            this.fctb_notepad.Name = "fctb_notepad";
            this.fctb_notepad.Paddings = new System.Windows.Forms.Padding(0);
            this.fctb_notepad.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctb_notepad.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctb_notepad.ServiceColors")));
            this.fctb_notepad.Size = new System.Drawing.Size(840, 349);
            this.fctb_notepad.TabIndex = 0;
            this.fctb_notepad.Zoom = 100;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDoc;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 424);
            this.Controls.Add(this.tc_Notepad);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Notepad++";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tc_Notepad.ResumeLayout(false);
            this.tp_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctb_notepad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_new;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_open;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_save;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_saveas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_rename;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_close;
        private System.Windows.Forms.ToolStripSeparator toolStrip_Separator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_print;
        private System.Windows.Forms.ToolStripSeparator toolStrip_Separator2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit_undo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit_redo;
        private System.Windows.Forms.ToolStripSeparator toolStrip_Separator3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit_cut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit_paste;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit_delete;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit_selectall;
        private System.Windows.Forms.ToolStripMenuItem tsmi_view;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language_html;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language_j;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language_l;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language_php;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language_sql;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language_xml;
        private System.Windows.Forms.ToolStripMenuItem tsmi_settings;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language_cSharp;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language_javaScript;
        private System.Windows.Forms.ToolStripMenuItem tsmi_language_json;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton ts_new;
        private System.Windows.Forms.ToolStripButton ts_open;
        private System.Windows.Forms.ToolStripButton ts_save;
        private System.Windows.Forms.ToolStripButton ts_saveAll;
        private System.Windows.Forms.ToolStripButton ts_close;
        private System.Windows.Forms.ToolStripButton ts_print;
        private System.Windows.Forms.ToolStripSeparator toolStrip_Separator2_1;
        private System.Windows.Forms.ToolStripButton ts_copy;
        private System.Windows.Forms.ToolStripButton ts_paste;
        private System.Windows.Forms.ToolStripSeparator toolStrip_Separator2_2;
        private System.Windows.Forms.ToolStripButton ts_undo;
        private System.Windows.Forms.ToolStripButton ts_redo;
        private System.Windows.Forms.ToolStripSeparator toolStrip_Separator2_3;
        private System.Windows.Forms.ColorDialog color_dialog;
        private System.Windows.Forms.FontDialog font_dialog;
        private System.Windows.Forms.ToolStripMenuItem tsmi_font;
        private System.Windows.Forms.ToolStripMenuItem tsmi_coor;
        private System.Windows.Forms.ToolStripButton ts_wordWrap;
        public System.Windows.Forms.ToolStripButton ts_cut;
        private System.Windows.Forms.TabPage tp_1;
        public FastColoredTextBoxNS.FastColoredTextBox fctb_notepad;
        public System.Windows.Forms.TabControl tc_Notepad;
        private System.Windows.Forms.ToolStripMenuItem tsmi_view_wordWrap;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}

