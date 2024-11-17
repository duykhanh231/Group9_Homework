using Google.Apis.Books.v1;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Apis.Books.v1.Data;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }

        private async Task LoadDataWithProgress()
        {
            pgbBookSearch.Visible = true;
            pgbBookSearch.Value = 0;

            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(50);
                pgbBookSearch.Value = i;
            }

            pgbBookSearch.Visible = false;
        }

        private async void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedBookId = dgvBooks.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var selectedBookTitle = dgvBooks.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                var selectedBookAuthors = dgvBooks.Rows[e.RowIndex].Cells["Authors"].Value.ToString();

                // Fetch additional details for the selected book
                var bookDetails = await GetBookDetails(selectedBookId);

                var detailForm = new BookDetails(bookDetails.Title, bookDetails.Authors, bookDetails.Description);
                detailForm.Show();
            }
        }

        private async Task<(string Title, string Authors, string Description)> GetBookDetails(string volumeId)
        {
            await LoadDataWithProgress();

            var service = new BooksService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBxAT0Lx1JgyO91B5OxH52ZXsU_xMl2htU",
                ApplicationName = "BookManagementApp"
            });

            var bookDetails = await service.Volumes.Get(volumeId).ExecuteAsync();


            return (bookDetails.VolumeInfo.Title,
                    string.Join(", ", bookDetails.VolumeInfo.Authors ?? new List<string> { "Unknown Author" }),
                    bookDetails.VolumeInfo.Description ?? "No Description Available");
        }

        private async Task SearchBooks(string query)
        {
            await LoadDataWithProgress();

            var service = new BooksService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBxAT0Lx1JgyO91B5OxH52ZXsU_xMl2htU",
                ApplicationName = "BookManagementApp"
            });

            var request = service.Volumes.List(query);
            try
            {
                var response = await request.ExecuteAsync();
                if (response.Items == null || response.Items.Count == 0)
                {
                    MessageBox.Show("No books found for the search query.");
                    return;
                }

                if (response.Items != null)
                {
                    dgvBooks.DataSource = response.Items.Select(item => new
                    {
                        Title = item.VolumeInfo?.Title ?? "No Title",
                        Authors = item.VolumeInfo?.Authors != null ? string.Join(", ", item.VolumeInfo.Authors) : "Unknown Author",
                        Id = item.Id
                    }).ToList();
                }
                else
                {
                    dgvBooks.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await SearchBooks(txtSearch.Text);
        }

        private void btnCreateBookshelf_Click(object sender, EventArgs e)
        {
            CreateBookshelf createBookshelf = new CreateBookshelf();
            createBookshelf.ShowDialog();
            this.Hide();
        }

        private void BookSearch_Load(object sender, EventArgs e)
        {

        }

    }
}
