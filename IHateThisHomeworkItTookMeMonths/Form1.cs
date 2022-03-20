using System.Text.Json;
using System.Text.Json.Serialization;

namespace IHateThisHomeworkItTookMeMonths
{
    public partial class Form1 : Form
    {

       List<Person> People = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            short tempAge;
            short.TryParse(AgeTxt.Text, out tempAge);
            Person person = new Person(NameTxt.Text, SurnameTxt.Text, tempAge);
            People.Add(person);
            _ = SerializeAsync();
        }

        public async Task SerializeAsync()
        {
            await using FileStream createStream = File.Create("PersonData.json");
            await JsonSerializer.SerializeAsync(createStream, People);
        }

        public async Task Reset()
        {
            List<Person> tempPeople = new List<Person>();
            await using FileStream createStream = File.Create("PersonData.json");
            await JsonSerializer.SerializeAsync(createStream, tempPeople);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}