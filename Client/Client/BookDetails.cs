using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class BookDetails : Form
    {
        public BookDetails(string title, string authors, string description)
        {
            InitializeComponent();
            rtbBookDetails.Text = $"Title: {title}\nAuthors: {authors}\nDescription: {description}";
        }
    }
}
