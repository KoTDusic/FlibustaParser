using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using ProjectClasses;

namespace FlibustaParser
{
    public partial class Form1 : Form
    {
        private List<Book> _books;
        private HtmlParser _parser;
        private string _bookDirectory;
        private string _currentHrefBook;
        private string _currentBookName;
        private string _siteDomen;
        private string _currentDirectory;
        private string _imagesDirectory;
        private int _currentBookId;
        static int _posX = 10;
        static int _posY = 10;
        int _firstHidedBookIndex;
        int _allButtonsCount;
        public Form1()
        {
            InitializeComponent();
            _siteDomen = ConfigsMain.GetDomen();
            _currentDirectory = Environment.CurrentDirectory;
            load_picturebox.Image = Image.FromFile(_currentDirectory + @"\Images\loading.gif");
            annotation_text.Hide();
            book_name_field.Hide();
            _bookDirectory = Environment.CurrentDirectory + @"\Books\";
            Directory.CreateDirectory(_bookDirectory);
            _parser = new HtmlParser(_siteDomen);
            var a = new Thread(LoadButtons);
            a.Start();
            splitContainer1.Panel1.Hide();
        }
        private void LoadButtons()
        {
            
            _books = _parser.GetBookList();
            _allButtonsCount = _books.Count;
            var addButton = new Action<int>(LoadNewButtons);
            splitContainer1.Panel1.Hide();
            var resultObj = splitContainer1.Panel1.BeginInvoke(addButton, 50);
            splitContainer1.EndInvoke(resultObj);
            this.BeginInvoke(new Action<IAsyncResult>(DisableLoadAnimation), resultObj);
        }
        private void LoadNewButtons(int number)
        {
            var bookBtnArray = new LinkButton[number];
            for (var i = 0; i < number; i++, _firstHidedBookIndex++)
            {
                if (_firstHidedBookIndex > _allButtonsCount - 1) return; //Если книжки кончились
                bookBtnArray[i] = AddNewButton(
                    _firstHidedBookIndex
                    );
            }
            splitContainer1.Panel1.Controls.AddRange(bookBtnArray);
        }
        private LinkButton AddNewButton(int bookId)
        {
            var btn = new LinkButton
            {
                Location = new Point(_posX, _posY),
                Text = _books[bookId].GetName(),
                Size = new Size(456, 25),
                MasIndex = bookId
            };
            btn.Click += OpenBook;
            _posY += 25;
            return btn;
        }
        void DisableLoadAnimation(IAsyncResult obj)
        {
            AsyncCompleted(obj);
            load_picturebox.Hide();

            splitContainer1.Panel1.Show();
            splitContainer1.Panel1.Focus();
            annotation_text.Show();
            book_name_field.Show();
        }
        private static void AsyncCompleted(IAsyncResult resObj) {  }
        private void OpenBook(object sender, EventArgs e)
        {
            var button = (LinkButton)sender;
            _currentBookName = _books[button.MasIndex].GetName();
            button.Href = _books[button.MasIndex].GetRef();
            book_name_field.Text = _currentBookName;
            _currentBookId = button.MasIndex;
            annotation_text.Text = _parser.GetBookAnotation(_books[button.MasIndex].GetRef());
            _currentHrefBook = button.Href;
            picture_box.Image = _parser.LoadBookImage(button.Href);
            download_button.Enabled = true;
        }

        private void DownloadButtonClick(object sender, EventArgs e)
        {
            var downloader=new Thread(DownloadFile);
            var data = new Container
            {
                Url = _siteDomen + _currentHrefBook + "/download",
                Dir = _bookDirectory + DateTime.Now.ToShortDateString() + "_" + _currentBookName + ".zip"
            };
            downloader.Start(data);
            download_button.Enabled = false;
        }
        private void DownloadFile(object param)
        {
            var data = (Container)param;
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(data.Url, data.Dir);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        private void splitContainer1_Panel1_Scroll(object sender, ScrollEventArgs e)
        {
            var maxlen = splitContainer1.Panel1.VerticalScroll.Maximum;
            toolStripLabel2.Text = "Max=" + maxlen;
            toolStripLabel1.Text = e.NewValue.ToString();
            if (e.NewValue + 529 >= maxlen)
            {
                splitContainer1.Panel1.Hide();
                var addButton = new Action<int>(LoadNewButtons);
                var resultObj = splitContainer1.Panel1.BeginInvoke(addButton, 50);
                splitContainer1.Panel1.Show();
            }
        }
    }
    public struct Container
    {
        public string Dir;
        public string Url;
    }
}
