using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using System.Diagnostics;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.VisualBasic.ApplicationServices;
namespace Client
{

    public partial class BookDetails : Form
    {
        public BookDetails(string title, string authors, string description)
        {
            InitializeComponent();
            rtbBookDetails.Text = $"Title: {title}\nAuthors: {authors}\nDescription: {description}";
        }

        private void rtbBookDetails_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnAddToShelf_Click(object sender, EventArgs e)
        {
            CreateBookshelf createBookshelf = new CreateBookshelf();
            string name = createBookshelf.bookshelfname;
            string volumeID = "2508";

            AddBookToLibrary(name, volumeID);
        }

        static async void AddBookToLibrary(string bookshelfname, string volumeID)
        {
            var Service = new BooksService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBxAT0Lx1JgyO91B5OxH52ZXsU_xMl2htU",
                ApplicationName = "BookManagementApp"
            });

            var request = Service.Mylibrary.Bookshelves.AddVolume(bookshelfname,volumeID);
            await request.ExecuteAsync();
            MessageBox.Show("Book Added successful!");
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromShelf_Click(object sender, EventArgs e)
        {
            CreateBookshelf createBookshelf = new CreateBookshelf();
            string name = createBookshelf.bookshelfname;
            string volumeID = "2508";

            RemoveBookFromBookshelf(name, volumeID);
        }

        static async void RemoveBookFromBookshelf( string bookshelfname, string volumeId)
        {
            var Service = new BooksService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBxAT0Lx1JgyO91B5OxH52ZXsU_xMl2htU",
                ApplicationName = "BookManagementApp"
            });

            var request = Service.Mylibrary.Bookshelves.RemoveVolume(bookshelfname, volumeId);
            await request.ExecuteAsync();
        }

    }
}
