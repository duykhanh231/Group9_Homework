using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;

namespace Client
{
    public partial class BookSearch : Form
    {
        private const string apiKey = "AIzaSyBxAT0Lx1JgyO91B5OxH52ZXsU_xMl2htU";

        public BookSearch()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadDataWithProgress();
            await SearchBooks(txtSearch.Text);
        }

        private async Task LoadDataWithProgress()
        {
            pgbBookSearch.Visible = true;
            for (int i = 0; i <= 100; i += 5)
            {
                await Task.Delay(10);
                pgbBookSearch.Value = i;
            }
            pgbBookSearch.Visible = false;
        }

        private async Task SearchBooks(string query)
        {
            var service = InitializeService();

            try
            {
                var request = service.Volumes.List(query);
                var response = await request.ExecuteAsync();

                if (response.Items == null || response.Items.Count == 0)
                {
                    MessageBox.Show("No books found for the search query.");
                    return;
                }

                dgvBooks.DataSource = response.Items.Select(item => new
                {
                    Title = item.VolumeInfo?.Title ?? "No Title",
                    Authors = item.VolumeInfo?.Authors != null ? string.Join(", ", item.VolumeInfo.Authors) : "Unknown Author",
                    Id = item.Id
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}");
            }
        }

        private async void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedBookId = dgvBooks.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var bookDetails = await GetBookDetails(selectedBookId);

                var detailForm = new BookDetails(bookDetails.Title, bookDetails.Authors, bookDetails.Description);
                detailForm.Show();
            }
        }

        private async Task<(string Title, string Authors, string Description)> GetBookDetails(string volumeId)
        {
            var service = InitializeService();

            try
            {
                var book = await service.Volumes.Get(volumeId).ExecuteAsync();
                return (
                    book.VolumeInfo.Title,
                    string.Join(", ", book.VolumeInfo.Authors ?? new[] { "Unknown Author" }),
                    book.VolumeInfo.Description ?? "No Description Available"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching book details: {ex.Message}");
                return ("Error", "Error", "Error");
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

        private void btnCreateBookshelf_Click(object sender, EventArgs e)
        {
            CreateBookshelf createBookshelf = new CreateBookshelf();
            createBookshelf.ShowDialog();
        }
    }
}
