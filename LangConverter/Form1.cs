using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LangConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.comboBox1.SelectedValue = "Choose one...";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    this.CollectBasicDataSettingsContainer.Enabled = false;
                    this.TranslateLangSettingsContainer.Enabled = false;
                    break;
                case 1:
                    this.CollectBasicDataSettingsContainer.Enabled = true;
                    this.TranslateLangSettingsContainer.Enabled = false;
                    break;
                case 2:
                    this.CollectBasicDataSettingsContainer.Enabled = false;
                    this.TranslateLangSettingsContainer.Enabled = true;
                    break;
            }
        }

        private void ChooseFile(Button sender, TextBox target,string filter)
        {
            sender.Enabled = false;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = filter;
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    target.Text = dialog.FileName;
                }
            }
            sender.Enabled = true;
        }

        private void ChooseSaveFile(Button sender, TextBox target, string filter)
        {
            sender.Enabled = false;
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = filter;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    target.Text = dialog.FileName;
                }
            }
            sender.Enabled = true;
        }

        private void OriginalChooseButton_Click(object sender, EventArgs e) => this.ChooseFile(this.OriginalChooseButton, this.textBox1, "Lang file|*.lang");

        private void TranslatedChooseButton_Click(object sender, EventArgs e) => this.ChooseFile(this.TranslatedChooseButton, this.textBox2, "Lang file|*.lang");

        private void button4_Click(object sender, EventArgs e) => this.ChooseFile(this.button4, this.textBox6, "Lang file|*.lang");

        private void button3_Click(object sender, EventArgs e) => this.ChooseFile(this.button3, this.textBox5, "Json file|*.json");

        private void ExportChooseButton_Click(object sender, EventArgs e) => this.ChooseSaveFile(this.ExportChooseButton, this.textBox3, "Json file|*.json");

        private void button2_Click(object sender, EventArgs e) => this.ChooseSaveFile(this.button2, this.textBox4, "Lang file|*.lang");

        private void CollectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text) || string.IsNullOrEmpty(this.textBox3.Text))
            {
                return;
            }
            this.CollectButton.Enabled = false;
            this.CollectBasicDataSettingsContainer.Enabled = false;
            this.TranslateLangSettingsContainer.Enabled = false;
            using (StreamReader reader_orig = new StreamReader(this.textBox1.Text))
            using (StreamReader reader_tran = new StreamReader(this.textBox2.Text))
            using (StreamWriter writer = new StreamWriter(this.textBox3.Text))
            {
                Dictionary<string, string> orig_data = new Dictionary<string, string>();
                while (!reader_orig.EndOfStream)
                {
                    string line = reader_orig.ReadLine();
                    if (!line.StartsWith("#") && line.Contains("="))
                    {
                        string[] vs = line.Split('=');
                        if (orig_data.Keys.Contains(vs[0]))
                        {
                            orig_data.Remove(vs[0]);
                        }
                        orig_data.Add(vs[0], vs[1]);
                    }
                }
                Dictionary<string, string> tran_data = new Dictionary<string, string>();
                while (!reader_tran.EndOfStream)
                {
                    string line = reader_tran.ReadLine();
                    if (!line.StartsWith("#") && line.Contains("="))
                    {
                        string[] vs = line.Split('=');
                        if (tran_data.Keys.Contains(vs[0]))
                        {
                            tran_data.Remove(vs[0]);
                        }
                        tran_data.Add(vs[0], vs[1]);
                    }
                }
                List<IntermediateData> l = new List<IntermediateData>(orig_data.Count);
                foreach (string v in orig_data.Keys)
                {
                    if (tran_data.Keys.Contains(v))
                    {
                        l.Add(new IntermediateData(orig_data[v], tran_data[v]));
                    }
                }
                string json = JsonConvert.SerializeObject(l.ToArray());
                writer.Write(json);
            }
            MessageBox.Show("Convertion finished", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.CollectButton.Enabled = true;
            this.comboBox1_SelectedIndexChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox6.Text) || string.IsNullOrEmpty(this.textBox5.Text) || string.IsNullOrEmpty(this.textBox4.Text))
            {
                return;
            }
            this.CollectButton.Enabled = false;
            this.CollectBasicDataSettingsContainer.Enabled = false;
            this.TranslateLangSettingsContainer.Enabled = false;
            List<IntermediateData> baseData = new List<IntermediateData>(JsonConvert.DeserializeObject(File.ReadAllText(this.textBox5.Text), typeof(IntermediateData[])) as IntermediateData[]);
            using(StreamReader orig_reader = new StreamReader(this.textBox6.Text))
            using(StreamWriter tran_writer = new StreamWriter(this.textBox4.Text))
            using(Form2 form2 = new Form2())
            {
                while (!orig_reader.EndOfStream)
                {
                    string line = orig_reader.ReadLine();
                    if (!line.Contains("="))
                    {
                        tran_writer.WriteLine(line);
                        continue;
                    }
                    string[] kvp = line.Split('=');
                    if (baseData.Any(cont => cont.original == kvp[1]))
                    {
                        tran_writer.WriteLine($"{kvp[0]}={baseData.First(cont => cont.original == kvp[1]).equals}");
                    }
                    else if(!this.checkBox1.Checked)
                    {
                        form2.SetContent(kvp[1]);
                        form2.ShowDialog();
                        tran_writer.WriteLine($"{kvp[0]}={form2.GetTranslated()}");
                        baseData.Add(new IntermediateData(kvp[1], form2.GetTranslated()));
                    }
                    else
                    {
                        tran_writer.WriteLine(line);
                    }
                }
            }
            MessageBox.Show("Convertion finished", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string json = JsonConvert.SerializeObject(baseData);
            File.WriteAllText(this.textBox5.Text, json);
            this.CollectButton.Enabled = true;
            this.comboBox1_SelectedIndexChanged(null, null);
        }
    }

    internal struct IntermediateData
    {
        internal IntermediateData(string original, string equals)
        {
            this.original = original;
            this.equals = equals;
        }
        [JsonProperty]
        public string original;
        [JsonProperty]
        public string equals;
    }
}
