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
        string[] Scopes = { BooksService.Scope.Books };
        string ApplicationName = "Google Books API C# Example";
        public BookDetails(string title, string authors, string description)
        {
            InitializeComponent();
            rtbBookDetails.Text = $"Title: {title}\nAuthors: {authors}\nDescription: {description}";
        }

        private void rtbBookDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToShelf_Click(object sender, EventArgs e)
        {
            
            UserCredential credential;

            
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                
                string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".credentials/books-api-dotnet-quickstart");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            
            var Service = new BooksService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            string bookshelfID = "2508";
            string volumneID = "ABCDEF";
            AddBookToLibrary(Service, bookshelfID,volumneID);
        }

        static void AddBookToLibrary(BooksService service, string bookshelfId, string volumeId)
        {

            try
            {
                
                var request = service.Mylibrary.Bookshelves.AddVolume(bookshelfId, volumeId);

                var bookshelf = request.Execute();

                
                var bookRequest = service.Mylibrary.Bookshelves.AddVolume(bookshelfId, bookshelfId);

                var response = bookRequest.Execute();
                Console.WriteLine($"Added book {volumeId} to your bookshelf.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error adding book: " + e.Message);
            }
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromShelf_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
               
                string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".credentials/books-api-dotnet-quickstart");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,Scopes,"user",CancellationToken.None,new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            
            var service = new BooksService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            
            string bookshelfId = "1001"; 
            string volumeId = "zyTCAlFPjgY"; 

            
            RemoveBookFromBookshelf(service, bookshelfId, volumeId);
        }

        static void RemoveBookFromBookshelf(BooksService service, string bookshelfId, string volumeId)
        {
            try
            {
                
                var request = service.Mylibrary.Bookshelves.RemoveVolume(bookshelfId, volumeId);
                request.Execute(); 
                Console.WriteLine($"Sách với ID {volumeId} đã bị xóa khỏi kệ sách {bookshelfId}.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi khi xóa sách: " + e.Message);
            }
        }

    }
}
