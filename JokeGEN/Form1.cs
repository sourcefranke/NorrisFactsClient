using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JokeGEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chuck_norris;
            textBoxJoke.Text = "";
            labelST.Text = "";
            labelJI.Text = "";
            labelCTG.Text = "";
        }

        static readonly HttpClient client = new HttpClient();

        public class Value
        {
            public int Id { get; set; }
            public string Joke { get; set; }
            public List<string> Categories { get; set; }
        }

        public class Root
        {
            public string Type { get; set; }
            public Value Value { get; set; }
        }

        private async void btnjoke_Click(object sender, EventArgs e)
        {
          try
            {
            var response = await client.GetAsync("http://api.icndb.com/jokes/random");
            var root = await response.Content.ReadAsAsync<Root>();

            textBoxJoke.Text = root.Value.Joke;
            labelST.Text = root.Type;
            labelJI.Text = root.Value.Id.ToString();

            if (root.Value.Categories.Count > 0)
            {
                labelCTG.Text = string.Join(", ", root.Value.Categories);
            }
            else
            {
                labelCTG.Text = "No Category";
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error trying to generate the joke: " + ex.Message);
            }
        }
    }
}
