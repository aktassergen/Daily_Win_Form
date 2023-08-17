using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath = "data.json";

        private void button1_Click(object sender, EventArgs e)
        {
            List<Daily> listDaily = new List<Daily>();
            Daily daily = new Daily();
            daily.dailyName = textBox1.Text;
            daily.dailyNote = richTextBox2.Text;
            daily.DateTime = DateTime.Now;
            listDaily.Add(daily);

            foreach (var item in listDaily)
            {
                
                listBox1.Items.Add(item.dailyName +"  Date="+item.DateTime);
            }

            //listMüsteriler.Add(müsteri);

            if (!File.Exists(filePath))
            {
                var newData = JsonSerializer.Serialize(listDaily);
                File.WriteAllText(filePath, newData);
            }
            else
            {
                string oldData = File.ReadAllText(filePath);
                List<Daily> comingData = JsonSerializer.Deserialize<List<Daily>>(oldData);

                foreach (Daily item in comingData)
                {
                    listDaily.Add(item);

                }
                string updatedData = JsonSerializer.Serialize(listDaily);
                File.WriteAllText(filePath, updatedData);
            }

            // listBox1.Items.Clear();


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            string camedatafile = File.ReadAllText(filePath);
            var cameList = JsonSerializer.Deserialize<List<Daily>>(camedatafile);

            string selectedItem = listBox1.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedItem))
            {
                //foreach (var Items in cameList)
                //{
                //    richTextBox1.Text = Items.dailyNotes;
                //}
                ////richTextBox1.Text = selectedItem;
                ///
                foreach (var item in cameList)
                {
                    if(item.dailyName == selectedItem)
                    {
                        richTextBox1.Text = item.dailyNote;
                    }

                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Daily> listDaily = new List<Daily>();
            if (File.Exists(filePath))
            {
                string oldData = File.ReadAllText(filePath);
                List<Daily> comingData = JsonSerializer.Deserialize<List<Daily>>(oldData);
               

                foreach (Daily item in comingData.OrderBy(x => x.DateTime).ToList())
                {
                    listBox1.Items.Add(item.dailyName);

                }
            }


        }

        private void richTextBox2_DoubleClick(object sender, EventArgs e)
        {

        }
    }


    public class Daily
    {
        public DateTime DateTime { get; set; }
        public string dailyName { get; set; }
        public string dailyNote { get; set; }
        public string dailyNotes { get; set; }

        public List<string> Dailyy { get; set; }

        public Daily()
        {
            Dailyy = new List<string>();
        }
    }
}