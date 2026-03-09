using System;

namespace TaskGUI
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.InputSentence;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sentenceInput = textBox1.Text ?? "";
            var sentence = new Sentence { Text = sentenceInput };
            var letterPercent = Logic.CalculateLetterPercent(sentence);
            var eachLetterPercent = Logic.CalculateEachLetterPercent(sentence);
            string resultOutput = "";
            resultOutput+=($"Процент букв в предложении: {letterPercent:F2}%\n");
            resultOutput += ("Процент каждой буквы:\n");
            foreach (var kvp in eachLetterPercent)
            {
                resultOutput += ($"{kvp.Key}: {kvp.Value}%\n");
            }
            Results.Text = resultOutput;

            Properties.Settings.Default.InputSentence = sentenceInput;
            Properties.Settings.Default.Save();
        }
    }
    public class Sentence
    {
        public string Text { get; set; }

        public int GetLetterCount()
        {
            if (string.IsNullOrEmpty(Text)) return 0;
            int count = 0;
            foreach (char c in Text)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }

        public int GetLength()
        {
            return Text?.Length ?? 0;
        }
        public string GetLowerText()
        {
            return Text?.ToLower() ?? string.Empty;
        }
    }

    public class Logic
    {
        public static double CalculateLetterPercent(Sentence sentence)
        {
            int letterCount = sentence.GetLetterCount();
            int totalLength = sentence.GetLength();
            if (totalLength == 0) return 0;
            return (double)letterCount / totalLength * 100;
        }

        public static Dictionary<string, int> CalculateEachLetterPercent(Sentence sentence)
        {
            var result = new Dictionary<string, int>();
            string lowerText = sentence.GetLowerText();
            int totalLength = sentence.GetLength();

            if (totalLength == 0)
                return result;

            foreach (char c in lowerText)
            {
                if (char.IsLetter(c))
                {
                    string letter = c.ToString();
                    if (!result.ContainsKey(letter))
                    {
                        result[letter] = 0;
                    }
                    result[letter]++;
                }
            }

            foreach (var key in result.Keys.ToList())
            {
                result[key] = (int)((double)result[key] / totalLength * 100);
            }

            return result;
        }
    }

}
