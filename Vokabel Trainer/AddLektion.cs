using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Vokabel_Trainer
{
    public partial class AddLektion : CustomCloseButton
    {
        bool saved = true;
        public BindingList<Vocabulary> vocabList = new BindingList<Vocabulary>();
        string MainPath;
        SaveScript SS;
        CConsole cConsole;
        Form1 Main;
        string extension = ".LGvok";

        public AddLektion(Form1 main, CConsole cC, string path, string LoadPath = "")
        {
            InitializeComponent();
            cConsole = cC;
            this.CloseButtonClicked += OnCloseButtonPressed;
            dataGridView1.DataSource = vocabList;

            MainPath = path;
            Main = main;
            cConsole.WriteLine("AL path: " + path + lektionNameBox.Text + extension);
            cConsole.WriteLine("AL LPath: " + LoadPath);
            SS = new SaveScript(path + lektionNameBox.Text + extension, cC);
            if (LoadPath != "")
            {
                SS.path = LoadPath;
                LoadVocab();
                lektionNameBox.Text = Path.GetFileNameWithoutExtension(LoadPath);
                cConsole.WriteLine("Loading File: " + LoadPath);
            }
            //else 

        }
        public void LoadVocab(string TPath = "T")
        {
            string oldPath = SS.path;
            cConsole.WriteLine("TPath: " + TPath);
            if(TPath != "T") SS.path = TPath;
            SS.Read();
            string[] clases = SS.getAllClassNames();
            foreach (string s in clases)
            {
                string word = s;
                string translation = SS.GetVariable(s, "Translation");
                Vocabulary vocab = new Vocabulary { Word = word, Translation = translation };
                vocabList.Add(vocab);
            }
            SS.path = oldPath;

            // Print counts for debugging; Fun fact: ChatGPT didnt found the Problem and suggested to use the Console more, lol
            cConsole.WriteLine("Found Vocabs: " + vocabList.Count);
        }
        public void CheckSaved(bool set = false)
        {
            saved = set;
            if (saved) savedLabel.Text = "Saved";
            else savedLabel.Text = "*Not Saved";
            cConsole.WriteLine("Saved was checked: " + saved);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            cConsole.WriteLine("Saved: " + saved);
            CheckSaved(true);
            cConsole.WriteLine("Saved: " + saved);
            string[] Trash = new string[1];
            Trash[0] = "Congrats of finding that File. Due this being a complicated System, I recommend not to edit this file";
            SS.Write(Trash, false); // needed to clear the old File so it can be replaced with the old
            foreach (Vocabulary v in vocabList)
            {
                string[] variables = new string[1];
                variables[0] = "Translation:" + v.Translation; //Could you not do something like this: ["T1", "T2"]? Or was this JS?
                SS.Write(v.Word, variables, true);
            }
            cConsole.WriteLine("Saved File at: " + SS.path);
            Main.UpdateDropbox();
            OnCloseButtonPressed(null, null);
        }
        public void OnCloseButtonPressed(object sender, EventArgs e)
        {
            if (!saved)
            {
                // MessageBoxButtons.YesNoCancel  
                DialogResult dialogResult = MessageBox.Show("The Vocabulary lesson is not saved. Do you want to save it befor closing this Window?", "Not saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Save_Click(null, null);
                }
                else if (dialogResult == DialogResult.No)
                {
                    Close();
                }
                else if (dialogResult == DialogResult.Cancel) return;
            }
            else Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CheckSaved();
            // Get word and translation from textboxes
            string word = wordTextBox.Text;
            string translation = translationTextBox.Text;

            // Create a new Vocabulary object
            Vocabulary vocab = new Vocabulary { Word = word, Translation = translation };

            // Add the vocabulary to the list
            vocabList.Add(vocab);

            // Clear textboxes for the next input
            wordTextBox.Clear();
            translationTextBox.Clear();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CheckSaved();
        }

        private void lektionNameBox_TextChanged(object sender, EventArgs e)
        {
            SS.path = MainPath + lektionNameBox.Text + extension;
        }
    }
}
