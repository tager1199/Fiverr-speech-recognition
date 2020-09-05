using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;

namespace SpeecSynthesiser
{

    public partial class Form1 : Form
    {
        DateTime speekTime = DateTime.UtcNow;
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SpeechRecognitionEngine startListening = new SpeechRecognitionEngine();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            recognizer.SetInputToDefaultAudioDevice();
            recognizer.LoadGrammarAsync(new DictationGrammar());
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
            recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_StartListening);
            recognizer.RecognizeAsync(RecognizeMode.Multiple);

            startListening.SetInputToDefaultAudioDevice();
            startListening.LoadGrammarAsync(new DictationGrammar());
            startListening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startListening_SpeechRecognised);
        }

        public void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine(speekTime.Subtract(DateTime.UtcNow).TotalSeconds);
            if (DateTime.UtcNow.Subtract(speekTime).TotalSeconds > 10)
                SpeechBox.Text = e.Result.Text;
            else
                SpeechBox.Text += "\n" + e.Result.Text;
            speekTime = DateTime.UtcNow;
            Clipboard.SetText(SpeechBox.Text);
        }

        static void recognizer_StartListening(object sender, SpeechDetectedEventArgs e)
        {

        }

        private void startListening_SpeechRecognised(object sender, SpeechRecognizedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
