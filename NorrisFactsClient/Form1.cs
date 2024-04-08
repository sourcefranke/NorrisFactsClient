using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace NorrisFacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textboxJoke.Text = "";
            categoriesLabel.Text = "";
            urlLabel.Text = "";
        }

        static readonly HttpClient client = new HttpClient();

        public class Joke
        {
            public string Value { get; set; }
            public List<string> Categories { get; set; }
            public string Url { get; set; }
        }

        private async void btnjoke_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await client.GetAsync("https://api.chucknorris.io/jokes/random");
                var joke = await response.Content.ReadAsAsync<Joke>();

                textboxJoke.Text = joke.Value;

                if (joke.Categories.Count > 0)
                {
                    categoriesLabel.Text = string.Join(", ", joke.Categories);
                }
                else
                {
                    categoriesLabel.Text = "No Category";
                }

                urlLabel.Text = joke.Url;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error trying to generate the joke: " + ex.Message);
            }
        }
    }
}
