using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using XenoUI;
using FastColoredTextBoxNS; // ���� �� ����� ��� ������� �� NuGet

namespace D3M0N3T
{
    public partial class D3M0N3T : Form
    {
        private string saveFilePath;
        // ����� ����� ��� ������ ��� API (���� ����)
        private TextStyle apiStyle = new TextStyle(Brushes.Gold, null, FontStyle.Bold);

        public D3M0N3T()
        {
            InitializeComponent();

            // 1. ����� ������ ��������
            if (File.Exists("D5.ico"))
            {
                this.Icon = new Icon("D5.ico");
            }

            // 2. ����� ����� �������
            ClientsWindow.Initialize(false);

            // 3. ���� ��� ������� ��������
            saveFilePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "D3M0N3T_SavedScript.txt"
            );

            // 4. ��� ��� ������ (FCTB)
            SetupEditorStyles();

            // 5. ����� ��� ����� �� ����
            LoadSavedScript();
        }

        #region Xeno API Imports (����� �� ��� ��� DLL)
        [DllImport("Xeno.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern IntPtr GetClients();

        [DllImport("Xeno.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void Execute(byte[] script, int[] PIDs, int count);

        [DllImport("Xeno.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Attach();
        #endregion

        #region Editor Setup (������� ������ ����������)
        private void SetupEditorStyles()
        {
            // ����� ��� ��� ��������
            Editor.Language = Language.Lua;

            // ��� D3M0N3T (������ �����)
            Editor.BackColor = Color.FromArgb(20, 20, 20); // ����� ����� ����
            Editor.ForeColor = Color.White;                // �� ����
            Editor.IndentBackColor = Color.FromArgb(25, 25, 25); // ������ �������
            Editor.LineNumberColor = Color.MediumPurple;   // ����� ������ ������ (D5)
            Editor.CaretColor = Color.White;               // ��� ������
            Editor.SelectionColor = Color.FromArgb(60, 75, 0, 130); // ����� ������ ����

            // ����� ����� ��� API �������� ��� �������
            Editor.TextChanged += (s, e) =>
            {
                // ��� �� ����� API ����� ��� ���� �������
                Editor.Range.SetStyle(apiStyle, @"\b(getgenv|getrenv|getreg|fireclickdetector|printconsole|loadstring|getrawmetatable)\b");
            };
        }
        #endregion

        // ���� ������ ���� ����� ��������


        #region Core Functions (������ ��������)
        private List<int> GetReadyClientPIDs()
        {
            var pids = new List<int>();
            try
            {
                IntPtr clientsPtr = GetClients();
                if (clientsPtr == IntPtr.Zero) return pids;

                string clientsJson = Marshal.PtrToStringAnsi(clientsPtr);
                var clientsList = JsonConvert.DeserializeObject<List<List<object>>>(clientsJson);

                if (clientsList != null)
                {
                    foreach (var client in clientsList)
                    {
                        if (client.Count >= 4)
                        {
                            int pid = Convert.ToInt32(client[0]);
                            int state = Convert.ToInt32(client[3]);
                            if (state == 3) pids.Add(pid); // ������ 3 ���� ������ ����
                        }
                    }
                }
            }
            catch { }
            return pids;
        }

        private void ExecuteScriptOnClients(string script)
        {
            if (string.IsNullOrWhiteSpace(script))
            {
                MessageBox.Show("Script is empty.", "D3M0N3T", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clientPIDs = GetReadyClientPIDs();
            if (clientPIDs.Count == 0)
            {
                MessageBox.Show("No ready clients found. Make sure you've pressed Attach.", "D3M0N3T", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Execute(Encoding.UTF8.GetBytes(script + "\0"), clientPIDs.ToArray(), clientPIDs.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Execution failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenLuaFiles()
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Lua Files (*.lua;*.luau;*.txt)|*.lua;*.luau;*.txt|All files (*.*)|*.*";
                    ofd.Multiselect = true;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder sb = new StringBuilder();
                        var sorted = ofd.FileNames.OrderBy(f => Path.GetExtension(f).ToLower() == ".luau" ? 1 : 0);
                        foreach (string file in sorted)
                        {
                            sb.AppendLine(File.ReadAllText(file, Encoding.UTF8));
                            sb.AppendLine();
                        }
                        Editor.Text = sb.ToString();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadSavedScript()
        {
            try { if (File.Exists(saveFilePath)) Editor.Text = File.ReadAllText(saveFilePath, Encoding.UTF8); } catch { }
        }
        #endregion

        #region Buttons Events (����� �������)
        private void atach_Click(object sender, EventArgs e) => Attach();

        private void execute_Click(object sender, EventArgs e) => ExecuteScriptOnClients(Editor.Text);

        private void clear_Click(object sender, EventArgs e) => Editor.Clear();

        private void btnOpen_Click(object sender, EventArgs e) => OpenLuaFiles();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { File.WriteAllText(saveFilePath, Editor.Text, Encoding.UTF8); } catch { }
        }

        // ����� ������� �������� ����
        private void button1_Click(object sender, EventArgs e) => Editor.Clear();
        private void button2_Click(object sender, EventArgs e) => ExecuteScriptOnClients(Editor.Text);
        private void button3_Click(object sender, EventArgs e) => ExecuteScriptOnClients(Editor.Text);
        private void Inject_Click(object sender, EventArgs e) => Attach();
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            // ������ ����� �� �� ���� ��� �������
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // ������ �����
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            Editor.Clear();
            if (Clipboard.ContainsText())
            {
                Editor.Paste();
            }

		}
    }
}