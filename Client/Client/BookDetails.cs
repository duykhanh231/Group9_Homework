using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Books.v1;
using Google.Apis.Services;
using Newtonsoft.Json;

namespace Client
{
    public partial class BookDetails : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiKey = "AIzaSyBxAT0Lx1JgyO91B5OxH52ZXsU_xMl2htU";

        public BookDetails(string title, string authors, string description)
        {
            InitializeComponent();
            rtbBookDetails.Text = $"Title: {title}\nAuthors: {authors}\nDescription: {description}";
        }

        private async void btnAddToShelf_Click(object sender, EventArgs e)
        {
            string bookshelfId = await GetBookshelfIdAsync();
            if (!string.IsNullOrEmpty(bookshelfId))
            {
                string volumeID = "2508"; // Replace with actual volume ID
                await AddBookToLibrary(bookshelfId, volumeID);
            }
        }

        private async void btnRemoveFromShelf_Click(object sender, EventArgs e)
        {
            string bookshelfId = await GetBookshelfIdAsync();
            if (!string.IsNullOrEmpty(bookshelfId))
            {
                string volumeID = "2508";
                await RemoveBookFromBookshelf(bookshelfId, volumeID);
            }
        }

        private async Task<string> GetBookshelfIdAsync()
        {
            string url = $"https://www.googleapis.com/books/v1/mylibrary/bookshelves?key={apiKey}";

            try
            {
                var response = await client.GetStringAsync(url);
                var bookshelvesResponse = JsonConvert.DeserializeObject<Bookshelves>(response);

                if (bookshelvesResponse.Items != null && bookshelvesResponse.Items.Count > 0)
                {
                    return bookshelvesResponse.Items[0].Id;
                }
                else
                {
                    MessageBox.Show("No bookshelves found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving bookshelves: {ex.Message}");
                return null;
            }
        }

        private async Task AddBookToLibrary(string bookshelfId, string volumeId)
        {
            var service = InitializeService();
            try
            {
                var request = service.Mylibrary.Bookshelves.AddVolume(bookshelfId, volumeId);
                await request.ExecuteAsync();
                MessageBox.Show("Book added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}");
            }
        }

        private async Task RemoveBookFromBookshelf(string bookshelfId, string volumeId)
        {
            var service = InitializeService();
            try
            {
                var request = service.Mylibrary.Bookshelves.RemoveVolume(bookshelfId, volumeId);
                await request.ExecuteAsync();
                MessageBox.Show("Book removed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing book: {ex.Message}");
            }
        }

        private BooksService InitializeService()
        {
            return new BooksService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey,
                ApplicationName = "BookManagementApp"
            });
        }
    }

    public class Bookshelves
    {
        public List<Bookshelf> Items { get; set; }
    }

    public class Bookshelf
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }
}
