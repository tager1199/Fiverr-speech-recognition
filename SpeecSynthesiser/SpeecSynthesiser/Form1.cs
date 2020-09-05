using System;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace SpeecSynthesiser
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        SpeechRecognitionEngine startListening = new SpeechRecognitionEngine();
        Random rnd = new Random();
        int RecTimeOut = 0;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            using (SpeechRecognitionEngine recognizer =
                new SpeechRecognitionEngine(
                    new System.Globalization.CultureInfo("en-GB")))
            {
                recognizer.LoadGrammar(new DictationGrammar());

                recognizer.SpeechRecognized += 
                    new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                recognizer.SetInputToDefaultAudioDevice();
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                while (true)
                {
                    Console.ReadLine();
                }
            }
        }
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Recognized text: " + e.Result.Text);
        }
    }
}
