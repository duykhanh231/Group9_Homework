using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using System.Security.Policy;
using System.Diagnostics;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;


namespace Client
{
    public partial class CreateBookshelf : Form
    {
        public CreateBookshelf()
        {
            InitializeComponent();
        }

        private async void CreateBookshelf_Load(object sender, EventArgs e)
        {
            
        }

        private void tb_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_BookShelfName_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnCreate_Click_1(object sender, EventArgs e)
        {
            string Bookshelfname = tb_BookShelfName.Text;
            string Description = tb_Description.Text;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string URL = "https://www.googleapis.com/books/v1/mylibrary/bookshelves";

                    var jsonData = "{ \"Title\": \"BookShelfname\" , \"age\": \"Description\" }";

                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        
                        string responseData = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseData);
                        MessageBox.Show("Create new bookshelf successful!");
                    }
                    else
                    {
                        Console.WriteLine("Error: " + response.StatusCode);
                    }

                    
                }
                catch (Exception ex)
                {

                }
            }
        }

        

        
    }
}
