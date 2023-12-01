namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int arrayIndex = 0;
        string[] arrID = new string[1000];
        string[] arrName = new string[1000];
        int[] arrScore = new int[10];

        string inputID;
        string inputNAME;
        string inputScore;

        int max_score, max_index, min_score, min_index;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //get input data from textbox
            inputID = tbinputID.Text;
            inputNAME = tbinputNAME.Text;
            inputScore = tbinputScore.Text;
            //create array สร้างเพื่อเก็บข้อมูลไว้

            //add data to array
            arrID[arrayIndex] = inputID;
            arrName[arrayIndex] = inputNAME;
            arrScore[arrayIndex] = int.Parse(inputScore);
            //add data to array
            arrayIndex++;

            // array = [1 ,2 ,3 , 4 ]
            //การหาค่ามากสุด
            max_score = arrScore.Max();
            max_index = arrScore.ToList().IndexOf(max_score);

            tbSCORE1.Text = arrScore[max_index].ToString();
            tbIDScore1.Text = arrID[max_index];
            tbNameScore1.Text = arrName[max_index];


            min_score = max_score;
            for (int i = 0; i < arrayIndex; i++)
            {

                if (arrScore[i] < min_score)
                {

                    min_score = arrScore[i];
                }

            }

            min_index = arrScore.ToList().IndexOf(min_score);


            tbSCORE2.Text = arrScore[min_index].ToString();
            tbIDScore2.Text = arrID[min_index].ToString();
            tbNameScore2.Text = arrName[min_index].ToString();

            int sum = 0;
            for (int i = 0; i < arrayIndex; i++)
            {

                sum += arrScore[i];

            }

            tbAVER.Text = (sum / arrayIndex).ToString();
        }





        private void tbIDScore1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNameScore1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbNameScore2_TextChanged(object sender, EventArgs e)
        {
            tbNameScore2.Text = inputNAME;
        }

        private void tbSCORE2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSCORE1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
