using CatFactAPI.Model.CatFact;
using CatFact_Form_App.Actions;

namespace CatFact_Form_App
{
    public partial class Form1 : Form
    {
        public CatFact? currentFact;
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            currentFact = new CatFact();
            currentFact = await CatFactActions.FetchFactAsync();
            CatFactTextlbl.Text = currentFact.fact;
            CatFactLengthlbl.Text = currentFact.length.ToString();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CatFactTextlbl_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
