namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        private char _islem;
        private bool _ekrantemizlenecekmi;
        private int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }



        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void toplabutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void esitbutton_Click(object sender, EventArgs e)
        {

            int ikincisayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void cýkartbutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpbutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void bolbutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void cbutton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}