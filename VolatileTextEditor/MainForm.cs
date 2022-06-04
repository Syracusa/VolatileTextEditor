using System.Diagnostics;
using System.Text;

namespace VolatileTextEditor
{
    public partial class MainForm : Form
    {
        DateTimeOffset timeOffset;
        private long deleteInterval;
        private long deleteTick;

        FontDialog fontDialog;

        public MainForm()
        {
            InitializeComponent();

            try
            {
                deleteInterval = Int32.Parse(DeleteTimeSetTextBox.Text);
            }
            catch
            {
                deleteInterval = 5000;
            }
            deleteTick = GetCurrentTick() + deleteInterval * 10000;

            fontDialog = new FontDialog();
            ResizeComponent();
        }

        private long GetCurrentTick()
        {
            timeOffset = DateTimeOffset.Now;
            return timeOffset.UtcTicks;
        }

        private void ResizeComponent()
        {
            ResizeTextbox();
            ResizeDeleteProgreeBar();

            DeleteTimeSetTextBox.Width = TimeScaleIndicateLabel.Left - TimeSetHelpLabel1.Right - 10;
        }

        private void ResizeDeleteProgreeBar()
        {
            DeleteProgressBar.Left = 20;
            DeleteProgressBar.Top = this.Height - 30;
            DeleteProgressBar.Width = this.Size.Width - 60;
        }

        private void ResizeTextbox()
        {
            MainRichTextBox.Left = 20;
            MainRichTextBox.Width = this.Size.Width - 60;
            MainRichTextBox.Width = this.Size.Width - 60;
            MainRichTextBox.Height = this.Size.Height - (100 + MainRichTextBox.Top);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizeComponent();
        }

        private void TimecheckTimer_Tick(object sender, EventArgs e)
        {
            long current_tick = GetCurrentTick();

            DebugLabel.Text = (deleteTick - current_tick).ToString();

            if (deleteTick >= current_tick)
            {
                long diff_tick = deleteTick - current_tick;
                DeleteProgressBar.Value = (int)((diff_tick * DeleteProgressBar.Maximum) / (deleteInterval * 10000));
            }
            else
            {
                DeleteProgressBar.Value = 0;
                deleteTick = GetCurrentTick() + deleteInterval * 10000;
                MainRichTextBox.Text = "";
            }
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StartButton.Enabled == true)
            {
                WriteStart();
            }
            deleteTick = GetCurrentTick() + deleteInterval * 10000;
        }
        private void WriteStart()
        {
            try
            {
                deleteInterval = Int32.Parse(DeleteTimeSetTextBox.Text);
            }
            catch
            {
                DeleteTimeSetTextBox.Text = "5000";
                deleteInterval = 5000;
            }

            StartButton.Enabled = false;
            deleteTick = GetCurrentTick() + deleteInterval * 10000;
            DeleteTimeSetTextBox.Enabled = false;
            TimecheckTimer.Enabled = true;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            WriteStart();
        }

        private void FontSelectButton_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;

            fontDialog.Font = MainRichTextBox.Font;
            fontDialog.Color = MainRichTextBox.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                MainRichTextBox.Font = fontDialog.Font;
                MainRichTextBox.ForeColor = fontDialog.Color;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            byte[] text_bytes = Encoding.UTF8.GetBytes(MainRichTextBox.Text);

            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save a text file";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                    case 2:
                        //userInput.Position = 0;
                        //userInput.WriteTo(fileStream);
                        fs.Write(text_bytes, 0, text_bytes.Length);
                        break;
                    default:
                        break;
                }

                fs.Close();
            }
        }


    }
}