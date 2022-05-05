using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ExifDateChanger
{
    public partial class Form1 : Form
    {
        // http://json2csharp.com/#

        private string _exifTool = @"D:\ExifTool\exiftool.exe";
        private Runner _runner;
        //private RootObject exifData;

        private List<string> timeTags = new List<string>
        {
            "FileModifyDate",
            "FileAccessDate",
            "FileCreateDate",
            "ModifyDate",
            "DateTimeOriginal",
            "DateTimeDigitized",
            "CreateDate",
            "GPSDateStamp"
        };

        public Form1()
        {
            InitializeComponent();
            _runner = new Runner(_exifTool);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(openFileDialog1.FileNames.Select(n => n).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                var exifData = ReadExif(item.ToString());

                textBox2.AppendText("-----------------------------------------------------------------------------------");
                textBox2.AppendText(Environment.NewLine);
                textBox2.AppendText(item.ToString());
                textBox2.AppendText(Environment.NewLine);
                textBox2.AppendText("-----------------------------------------------------------------------------------");
                textBox2.AppendText(Environment.NewLine);

                SetField("FileModifyDate", exifData.Time.FileModifyDate?.val, item);
                SetField("FileAccessDate", exifData.Time.FileAccessDate?.val, item);
                SetField("FileCreateDate", exifData.Time.FileCreateDate?.val, item);
                SetField("ModifyDate", exifData.Time.ModifyDate?.val, item);
                SetField("DateTimeOriginal", exifData.Time.DateTimeOriginal?.val, item);
                SetField("DateTimeDigitized", exifData.Time.DateTimeOriginal?.val, item);
                SetField("CreateDate", exifData.Time.CreateDate?.val, item);
                SetField("GPSDateStamp", exifData.Time.GPSDateStamp?.val, item);
            }
        }

        private void SetField(string tag, string date, object item)
        {
            if (string.IsNullOrWhiteSpace(date))
            {
                ShowFormatError(tag, date ?? string.Empty);
                return;
            }

            DateTime dt;

            if (TryGetTime(date, out dt))
            {
                // set new date and keep original time
                var command = $" -{tag}=\"{dateTimePicker1.Value.ToString("yyyy-MM-dd")} {dt.ToString("HH:mm:ss")}\" \"{item}\"";
                textBox2.AppendText(command);
                textBox2.AppendText(Environment.NewLine);

                var response = string.Join(string.Empty, _runner.Command(command));

                textBox2.AppendText(response);
                textBox2.AppendText(Environment.NewLine);
            }
            else
            {
                ShowFormatError(tag, date);
            }

            Application.DoEvents();
        }

        private bool TryGetTime(string date, out DateTime dt)
        {
            var result = DateTime.TryParseExact(date, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
            if (!result)
            {
                DateTimeOffset dtf;
                result = DateTimeOffset.TryParseExact(date, "yyyy:MM:dd HH:mm:sszzzz", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtf);

                if (result)
                {
                    dt = dtf.DateTime;
                }
            }

            return result;
        }

        private void ShowFormatError(string tag, string date)
        {
            textBox2.AppendText($"Tag '{tag}' with value '{date}' cannot be converted to DateTime");
            textBox2.AppendText(Environment.NewLine);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            textBox1.Clear();
            var exifData = ReadExif(listBox1.SelectedItem.ToString());
            if (exifData != null)
            {
                textBox1.AppendText(JsonConvert.SerializeObject(exifData.Time, Formatting.Indented));
            }
        }

        private RootObject ReadExif(string path)
        {
            var response = string.Join(string.Empty, _runner.Command($" -t -g2 -ALL -j \"{path}\""));
            return JsonConvert.DeserializeObject<List<RootObject>>(response).FirstOrDefault();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                textBox2.AppendText("-----------------------------------------------------------------------------------");
                textBox2.AppendText(Environment.NewLine);
                textBox2.AppendText(item.ToString());
                textBox2.AppendText(Environment.NewLine);
                textBox2.AppendText("-----------------------------------------------------------------------------------");
                textBox2.AppendText(Environment.NewLine);

                foreach (var tag in timeTags)
                {
                    var command = $" -{tag} \"{item}\"";
                    var response = string.Join(string.Empty, _runner.Command(command));
                    textBox2.AppendText(response);
                    textBox2.AppendText(Environment.NewLine);
                }

                Application.DoEvents();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>();
            DateTime dt;

            foreach (var item in listBox1.Items)
            {
                var exif = ReadExif(item.ToString());
                if (TryGetTime(exif?.Time?.DateTimeOriginal?.val, out dt))
                {
                    dict.Add(item.ToString(), dt);
                }
            }

            var files = dict
                .OrderBy(k => k.Value)
                .ToList();

            var path = Path.GetDirectoryName(listBox1.Items[0].ToString());
            var ext = Path.GetExtension(listBox1.Items[0].ToString());
            int i = 1;

            foreach (var file in files)
            {
                var newName = Path.Combine(path, $"IMG_{dateTimePicker1.Value.ToString("yyyyMMdd")}_{i++.ToString("D3")}{ext}");

                textBox2.AppendText("-----------------------------------------------------------------------------------");
                textBox2.AppendText(Environment.NewLine);
                textBox2.AppendText("Renaming " + file.Key + " to " + newName);
                textBox2.AppendText(Environment.NewLine);
                textBox2.AppendText("-----------------------------------------------------------------------------------");
                textBox2.AppendText(Environment.NewLine);

                File.Move(file.Key, newName);

                File.SetCreationTime(newName, file.Value);
                File.SetLastAccessTime(newName, file.Value);
                File.SetLastWriteTime(newName, file.Value);

                Application.DoEvents();
            }
        }
    }
}
