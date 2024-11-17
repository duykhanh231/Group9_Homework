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
        public string bookshelfname = "";
        
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
            
            bookshelfname = tb_BookShelfName.Text;

            var Service = new BooksService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBxAT0Lx1JgyO91B5OxH52ZXsU_xMl2htU",
                ApplicationName = "BookManagementApp"
            });

            MessageBox.Show("Create Book Shelf Successful!");
        }

        private void CreateBookshelf_Load_1(object sender, EventArgs e)
        {

        }
    }
}
