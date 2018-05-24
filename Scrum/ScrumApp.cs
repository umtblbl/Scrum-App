using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace Scrum
{
    public partial class ScrumApp : MetroForm
    {
        public ScrumApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\My World of Software\Desktop\Scrum\Text\textStories.txt";

            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            string text = streamReader.ReadLine();
            while (text != null)
            {
                listboxStories.Items.Add(text);
                text = streamReader.ReadLine();
            }
            streamReader.Close();
            fileStream.Close();

            string filePath2 = @"C:\Users\My World of Software\Desktop\Scrum\Text\textNotStarted.txt";

            FileStream fileStream2 = new FileStream(filePath2, FileMode.Open, FileAccess.Read);
            StreamReader streamReader2 = new StreamReader(fileStream2);
            string text2 = streamReader2.ReadLine();
            while (text2 != null)
            {
                listboxNotStarted.Items.Add(text2);
                text2 = streamReader2.ReadLine();
            }
            streamReader2.Close();
            fileStream2.Close();

            string filePath3 = @"C:\Users\My World of Software\Desktop\Scrum\Text\textInProgress.txt";

            FileStream fileStream3 = new FileStream(filePath3, FileMode.Open, FileAccess.Read);
            StreamReader streamReader3 = new StreamReader(fileStream3);
            string text3 = streamReader3.ReadLine();
            while (text3 != null)
            {
                listboxInProgress.Items.Add(text3);
                text3 = streamReader3.ReadLine();
            }
            streamReader3.Close();
            fileStream3.Close();

            string filePath4 = @"C:\Users\My World of Software\Desktop\Scrum\Text\textDone.txt";

            FileStream fileStream4 = new FileStream(filePath4, FileMode.Open, FileAccess.Read);
            StreamReader streamReader4 = new StreamReader(fileStream4);
            string text4 = streamReader4.ReadLine();
            while (text4 != null)
            {
                listboxDone.Items.Add(text4);
                text4 = streamReader4.ReadLine();
            }
            streamReader4.Close();
            fileStream4.Close();
        }

        private void btnAddStories_Click(object sender, EventArgs e)
        {
            String stories = textStories.Text.ToString();
            textStories.Clear();
            listboxStories.Items.Add(stories);

        }
        int sira;
        private void listboxStories_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            sira = listboxStories.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && sira != -1) {

                    listboxStories.DoDragDrop(listboxStories.Items[sira], DragDropEffects.All);
                    listboxStories.Items.Remove(listboxStories.SelectedItem);
                
            }
        }

        private void listboxStories_DragDrop(object sender, DragEventArgs e)
        {
            listboxStories.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listboxStories_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listboxNotStarted_DragOver(object sender, DragEventArgs e)
        {
            if(e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listboxNotStarted_DragDrop(object sender, DragEventArgs e)
        {
            listboxNotStarted.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            
        }

        private void listboxNotStarted_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            sira = listboxNotStarted.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && sira != -1)
            {
                listboxNotStarted.DoDragDrop(listboxNotStarted.Items[sira], DragDropEffects.All);
                listboxNotStarted.Items.Remove(listboxNotStarted.SelectedItem);
            }
        }

        private void listboxInProgress_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            sira = listboxInProgress.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && sira != -1)
            {
                listboxInProgress.DoDragDrop(listboxInProgress.Items[sira], DragDropEffects.All);
                listboxInProgress.Items.Remove(listboxInProgress.SelectedItem);
            }
        }

        private void listboxInProgress_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listboxInProgress_DragDrop(object sender, DragEventArgs e)
        {
            listboxInProgress.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listboxDone_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            sira = listboxDone.IndexFromPoint(point);
            if (e.Button == MouseButtons.Left && sira != -1)
            {
                listboxDone.DoDragDrop(listboxDone.Items[sira], DragDropEffects.All);
                listboxDone.Items.Remove(listboxDone.SelectedItem);
            }
        }

        private void listboxDone_DragDrop(object sender, DragEventArgs e)
        {
            listboxDone.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }

        private void listboxDone_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void btnSaveAndExits_Click(object sender, EventArgs e)
        {
            if (listboxStories.Items.Count != 0)
            {
                string filePath = @"C:\Users\My World of Software\Desktop\Scrum\Text\textStories.txt";
                FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);

                for (int i = 0; listboxStories.Items.Count > i; i++)
                {
                    streamWriter.WriteLine(listboxStories.Items[i]);
                }
                streamWriter.Flush();
                streamWriter.Close();
                fileStream.Close();
            }

            if (listboxNotStarted.Items.Count != 0)
            {
                string filePath2 = @"C:\Users\My World of Software\Desktop\Scrum\Text\textNotStarted.txt";
                FileStream fileStream2 = new FileStream(filePath2, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter streamWriter2 = new StreamWriter(fileStream2);

                for (int i = 0; listboxNotStarted.Items.Count > i; i++)
                {
                    streamWriter2.WriteLine(listboxNotStarted.Items[i]);
                }
                streamWriter2.Flush();
                streamWriter2.Close();
                fileStream2.Close();
            }
            else
            {
                TextWriter textWriter = new StreamWriter(@"C:\Users\My World of Software\Desktop\Scrum\Text\textNotStarted.txt");
                textWriter.Write("");
                textWriter.Close();
            }

            if (listboxInProgress.Items.Count != 0)
            {
                string filePath3 = @"C:\Users\My World of Software\Desktop\Scrum\Text\textInProgress.txt";
                FileStream fileStream3 = new FileStream(filePath3, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter streamWriter3 = new StreamWriter(fileStream3);

                for (int i = 0; listboxInProgress.Items.Count > i; i++)
                {
                    streamWriter3.WriteLine(listboxInProgress.Items[i]);
                }
                streamWriter3.Flush();
                streamWriter3.Close();
                fileStream3.Close();
            }
            else
            {
                TextWriter textWriter2 = new StreamWriter(@"C:\Users\My World of Software\Desktop\Scrum\Text\textInProgress.txt");
                textWriter2.Write("");
                textWriter2.Close();
            }
            if (listboxDone.Items.Count != 0)
            {
                string filePath4 = @"C:\Users\My World of Software\Desktop\Scrum\Text\textDone.txt";
                FileStream fileStream4 = new FileStream(filePath4, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter streamWriter4 = new StreamWriter(fileStream4);

                for (int i = 0; listboxDone.Items.Count > i; i++)
                {
                    streamWriter4.WriteLine(listboxDone.Items[i]);
                }
                streamWriter4.Flush();
                streamWriter4.Close();
                fileStream4.Close();
            }
            else
            {
                TextWriter textWriter3 = new StreamWriter(@"C:\Users\My World of Software\Desktop\Scrum\Text\textDone.txt");
                textWriter3.Write("");
                textWriter3.Close();
            }
            this.Close();
        }
    }
}
