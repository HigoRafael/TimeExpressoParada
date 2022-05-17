namespace TimeExpressoParada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void CalcularTimer(String horIniti, String horFinal)
        {
            try
            {
                TimeSpan intervalo = Convert.ToDateTime(horIniti) - Convert.ToDateTime(horFinal);
                MessageBox.Show("Horas:  " + intervalo.Hours + " Minutos " + intervalo.Minutes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique o formato dos dados inseridos");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(mtxtIniTimer.Text))
            {
                mtxtFinalTimer.Focus();
            }
        }

        private void mtxtFinalTimer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(mtxtFinalTimer.Text))
            {
                btnCalc.Focus();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                CalcularTimer(mtxtIniTimer.Text, mtxtFinalTimer.Text);
                mtxtIniTimer.Text = "";
                mtxtFinalTimer.Text = "";
                mtxtIniTimer.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !");
            }
        }
    }
}