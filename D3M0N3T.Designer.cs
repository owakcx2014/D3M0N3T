namespace D3M0N3T
{
    partial class D3M0N3T
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
	

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D3M0N3T));
            Execut = new Button();
            atach = new Button();
            btnOpen = new Button();
            clear = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Editor = new FastColoredTextBoxNS.FastColoredTextBox();
            tabPage2 = new TabPage();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage3 = new TabPage();
            webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage4 = new TabPage();
            webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Editor).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView23).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Execut
            // 
            Execut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Execut.AutoSize = true;
            Execut.BackColor = Color.BlueViolet;
            Execut.Cursor = Cursors.Hand;
            Execut.FlatAppearance.BorderSize = 0;
            Execut.FlatStyle = FlatStyle.Flat;
            Execut.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Execut.ForeColor = Color.BlueViolet;
            Execut.Image = (Image)resources.GetObject("Execut.Image");
            Execut.Location = new Point(753, 418);
            Execut.MaximumSize = new Size(10000, 10000);
            Execut.MinimumSize = new Size(30, 30);
            Execut.Name = "Execut";
            Execut.Size = new Size(106, 106);
            Execut.TabIndex = 2;
            Execut.UseVisualStyleBackColor = false;
            Execut.Click += button3_Click;
            // 
            // atach
            // 
            atach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            atach.AutoSize = true;
            atach.BackColor = Color.BlueViolet;
            atach.Cursor = Cursors.Hand;
            atach.FlatAppearance.BorderSize = 0;
            atach.FlatStyle = FlatStyle.Flat;
            atach.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            atach.ForeColor = SystemColors.Control;
            atach.Image = (Image)resources.GetObject("atach.Image");
            atach.Location = new Point(45, 407);
            atach.MaximumSize = new Size(10000, 10000);
            atach.MinimumSize = new Size(30, 30);
            atach.Name = "atach";
            atach.Size = new Size(131, 119);
            atach.TabIndex = 5;
            atach.UseVisualStyleBackColor = false;
            atach.Click += atach_Click;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Bottom;
            btnOpen.AutoSize = true;
            btnOpen.BackColor = Color.BlueViolet;
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = SystemColors.Control;
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.Location = new Point(269, 407);
            btnOpen.MaximumSize = new Size(10000, 10000);
            btnOpen.MinimumSize = new Size(30, 30);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(133, 124);
            btnOpen.TabIndex = 6;
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // clear
            // 
            clear.Anchor = AnchorStyles.Bottom;
            clear.AutoSize = true;
            clear.BackColor = Color.BlueViolet;
            clear.Cursor = Cursors.Hand;
            clear.FlatAppearance.BorderSize = 0;
            clear.FlatStyle = FlatStyle.Flat;
            clear.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear.ForeColor = SystemColors.Control;
            clear.Image = (Image)resources.GetObject("clear.Image");
            clear.Location = new Point(500, 403);
            clear.MaximumSize = new Size(10000, 10000);
            clear.MinimumSize = new Size(30, 30);
            clear.Name = "clear";
            clear.Size = new Size(130, 128);
            clear.TabIndex = 7;
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.MaximumSize = new Size(10000, 10000);
            tabControl1.MinimumSize = new Size(30, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(890, 557);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.BlueViolet;
            tabPage1.Controls.Add(Editor);
            tabPage1.Controls.Add(atach);
            tabPage1.Controls.Add(clear);
            tabPage1.Controls.Add(Execut);
            tabPage1.Controls.Add(btnOpen);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(882, 529);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Executer";
            tabPage1.Click += tabPage1_Click;
            // 
            // Editor
            // 
            Editor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Editor.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            Editor.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            Editor.AutoScrollMinSize = new Size(115, 14);
            Editor.AutoSize = true;
            Editor.BackBrush = null;
            Editor.BackColor = Color.Black;
            Editor.BorderStyle = BorderStyle.Fixed3D;
            Editor.CharHeight = 14;
            Editor.CharWidth = 8;
            Editor.Cursor = Cursors.IBeam;
            Editor.DefaultMarkerSize = 8;
            Editor.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            Editor.Font = new Font("Courier New", 9.75F);
            Editor.ForeColor = SystemColors.ControlLightLight;
            Editor.Hotkeys = resources.GetString("Editor.Hotkeys");
            Editor.IndentBackColor = Color.Gray;
            Editor.IsReplaceMode = false;
            Editor.LineNumberColor = Color.Black;
            Editor.Location = new Point(3, 0);
            Editor.MaximumSize = new Size(10000, 10000);
            Editor.MinimumSize = new Size(1, 1);
            Editor.Name = "Editor";
            Editor.Paddings = new Padding(0);
            Editor.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            Editor.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("Editor.ServiceColors");
            Editor.ServiceLinesColor = Color.Black;
            Editor.Size = new Size(882, 412);
            Editor.TabIndex = 8;
            Editor.Text = "print(\"no\")";
            Editor.Zoom = 100;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(webView21);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(882, 529);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "D3X Hub";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(-4, 1);
            webView21.Name = "webView21";
            webView21.Size = new Size(886, 535);
            webView21.Source = new Uri("https://owakcx2014.github.io/D3X/", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(webView22);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(882, 529);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "D3X keeper";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // webView22
            // 
            webView22.AllowExternalDrop = true;
            webView22.CreationProperties = null;
            webView22.DefaultBackgroundColor = Color.White;
            webView22.Dock = DockStyle.Fill;
            webView22.Location = new Point(3, 3);
            webView22.Name = "webView22";
            webView22.Size = new Size(876, 523);
            webView22.Source = new Uri("https://owakcx2014.github.io/script_keeper/", UriKind.Absolute);
            webView22.TabIndex = 0;
            webView22.ZoomFactor = 1D;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(webView23);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(882, 529);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "About";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // webView23
            // 
            webView23.AllowExternalDrop = true;
            webView23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView23.CreationProperties = null;
            webView23.DefaultBackgroundColor = Color.White;
            webView23.Location = new Point(0, 0);
            webView23.Name = "webView23";
            webView23.Size = new Size(882, 532);
            webView23.Source = new Uri("https://owakcx2014.github.io/about-demonet/", UriKind.Absolute);
            webView23.TabIndex = 0;
            webView23.ZoomFactor = 1D;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(896, 563);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // D3M0N3T
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(896, 563);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "D3M0N3T";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D3M0N3T";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Editor).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView22).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView23).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Execut;
        private Button button4;
        private Button atach;
        private Button btnOpen;
        private Button clear;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TabPage tabPage3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private TableLayoutPanel tableLayoutPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox Editor;
        private TabPage tabPage4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;
    }
}
