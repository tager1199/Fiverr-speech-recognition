using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;

namespace SpeecSynthesiser
{

    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-GB"));
        SpeechRecognitionEngine startListening = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();
        }

        public static void ChangeText(String message)
        {
            Form1 frm1 = new Form1();
            frm1.SpeechBox.Text += message;
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
            SpeechBox.Text += e.Result.Text + "\n";
        }

        static void recognizer_StartListening(object sender, SpeechDetectedEventArgs e)
        {

        }

        private void startListening_SpeechRecognised(object sender, SpeechRecognizedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Copy_Btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SpeechBox.Text);
        }
    }
}
