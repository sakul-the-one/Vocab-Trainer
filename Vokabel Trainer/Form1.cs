using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vokabel_Trainer
{

    public partial class Form1 : Form
    {

        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        CConsole cConsole;
        string path;
        string SelectedPath;
        public AddLektion addLektion;
        public int index;
        //Variables for ABFRAGEN:
        public List<string> allTranslations = new List<string>();
        public List<string> allWords = new List<string>();
        public Dictionary<string, string> Vokabeln = new Dictionary<string, string>();
        public Color bColor;
        Button[] abButtons = new Button[4];
        public void UpdateDropbox()
        {
            cConsole.WriteLine("Dropbox was updated");
            comboBox1.Items.Clear();
            try
            {
                string[] files = Directory.GetFiles(path);
                //cConsole.WriteLine("Found " + files.GetLength().ToString() + " Files");

                foreach (string file in files)
                {
                    cConsole.WriteLine(file);
                    comboBox1.Items.Add(file);

                }
                comboBox1.SelectedIndex = index;
            }
            catch (Exception e)
            {
                cConsole.WriteLine("There went something wrong: " + e.Message);
            }
            cConsole.WriteLine("Selected Path: " + SelectedPath);
        }
        public Form1()
        {
            InitializeComponent();
            LektionAbfrage.Visible = false;
            cConsole = new CConsole();
            // comboBox1.Items.Add    
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Vokabeln\";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    cConsole.WriteLine("That path exists already.");
                }
                else
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    cConsole.WriteLine("The directory was created successfully at " + Directory.GetCreationTime(path) + ".");
                }
                // Delete the directory.
                //  di.Delete();
                //cConsole.WriteLine("The directory was deleted successfully: " + path);
            }
            catch (Exception e)
            {
                cConsole.WriteLine("The process failed: " + e.ToString());
            }
            //Console.ReadLine();
            UpdateDropbox();
            cConsole.WriteLine("Selected Path: " + SelectedPath);
            cConsole.WriteLine("Current Index: " + comboBox1.SelectedIndex);

            abButtons[0] = Abutton1;
            abButtons[1] = Abutton2;
            abButtons[2] = Abutton3;
            abButtons[3] = Abutton4;
            bColor = abButtons[0].BackColor;
        }
        int ranBut;
        string CorrectAnswer;
        int ranVocab;
        bool Checked = true;
        int wrong = 0;
        int right = 0;
        int allTrys = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            wrong = 0;
            right = 0;
            allTrys = 0;

            ARichtigLabel.Text = "Right: " + right;
            AFalschLabel.Text = "Wrong " + wrong;
            left.Text = "Vocabs left: " + Vokabeln.Count;
            try { 
            AAlltrys.Text = "Efficiecy: " + (right/allTrys) + "%";
            }
            catch { AAlltrys.Text = "Efficiecy: 0%"; }
            string NPath = path + SelectedPath;
            Vokabeln.Clear();
            allTranslations.Clear();
            allWords.Clear();
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No Path selected to be trained. Select a Path befor it can be tested", "Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Vokabel Lekion Starten
            LektionAbfrage.Visible = true;

            BindingList<Vocabulary> vocabList;
            cConsole.WriteLine("Path bevor es gesendet wird um Lektion zu lernen: " + path);
            addLektion = new AddLektion(this, cConsole, path, SelectedPath);
            cConsole.WriteLine("Lernen Path: " + path);
            addLektion.LoadVocab(); //LOL

            vocabList = addLektion.vocabList;


            foreach (Vocabulary v in vocabList)
            {
                try { 
                Vokabeln.Add(v.Word, v.Translation);
                allTranslations.Add(v.Translation);
                allWords.Add(v.Word);
                } catch (Exception ex) { cConsole.WriteLine("Exception found: " + ex.Message); }
            }
            ANext_Click(null, null);
            Checked = true;
        }
        Random random = new Random();

        private void SoulutionButtonClicked(object sender, EventArgs e)
        {
            allTrys += 1;
            Checked = true;
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == CorrectAnswer)
            {
                right += 1;
                clickedButton.BackColor = Color.Green;
                Checked = true;
                Vokabeln.Remove(AVocabLabel.Text);
                allWords.Remove(AVocabLabel.Text);
            }
            else
            {
                clickedButton.BackColor = Color.Red;
                wrong += 1;
                foreach (Button b in abButtons)
                {
                    if (b.Text == CorrectAnswer) b.BackColor = Color.Green;
                }
            }
            ARichtigLabel.Text = "Right: " + right;
            AFalschLabel.Text = "Wrong " + wrong;
            left.Text = "Vocabs left: " + Vokabeln.Count;
            try
            {
                AAlltrys.Text = "Efficiecy: " + (((float)right / (float)allTrys)*100) + "%";
            }
            catch { AAlltrys.Text = "Efficiecy: 0%"; }
        }
        private void ANext_Click(object sender, EventArgs e)
        {
            if (Vokabeln.Count > 0)
            {
                if (Checked)
                {
                    try
                    {
                        int randomIndex = random.Next(allWords.Count);
                        cConsole.WriteLine("Random Index: " + randomIndex + "\nAllWords Count: " + allWords.Count + "\nVokabeln Count: " + Vokabeln.Count);
                        CorrectAnswer = Vokabeln[allWords[randomIndex]];
                        AVocabLabel.Text = allWords[randomIndex].Replace('_',' ');

                        foreach (Button b in abButtons)
                        {
                            b.Text = allTranslations[random.Next(allTranslations.Count)];
                            b.BackColor = bColor;
                        }
                        abButtons[random.Next(4)].Text = CorrectAnswer;
                        Checked = false;
                    }
                    catch (Exception ex)
                    {
                        cConsole.WriteLine("Something went wrong: " + ex.Message);
                    }
                }
                else MessageBox.Show("Stop Cheating, you cant skip. You are for ever here until you know everyone", "No Cheating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                LektionAbfrage.Visible = false;
                MessageBox.Show("Well done. You have completed this lection. Now you can learn again", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Show Console
            cConsole.Show();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPath = comboBox1.Text;
            cConsole.WriteLine("Selected Path: " + SelectedPath);
            // comboBox1.Items.Add
            index = comboBox1.SelectedIndex;
        }

        private void AddLektion_Click(object sender, EventArgs e)
        {
            addLektion = new AddLektion(this, cConsole, path);
            addLektion.Show();
        }

        private void editLektionButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No Path selected to be edited. Select a Path befor editing it", "Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            addLektion = new AddLektion(this, cConsole, path, SelectedPath);
            addLektion.Show();
        }

    }
}
