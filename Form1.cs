using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//źródła grafiki strzałek wykorzystanych w programie
//arrow strait https://us.123rf.com/450wm/juliarstudio/juliarstudio1602/juliarstudio160202524/51973336-strza%C5%82ka-w-prawo-czarna-ikona-prosta-na-bia%C5%82ym-tle.jpg?ver=6
//arrow rotate https://pl.fotoomnia.com/zdjecia/thumb/56d0c52babb01c4343425e8f29f988f0.jpg

namespace AplikacjaBluetooth_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //odczytanie dostępnych portów wraz z wpisanie ich do rozwijanej listy
            comboBox1.Items.AddRange(SerialPort.GetPortNames());

            //sortowanie wyswietlanych nazw dostępnych portów
            comboBox1.Sorted = true;   //true oznacza, że zawartość tego komponenty ma być posortowana

            //przypisanie wartosci domyslnych w rozwijanych listach wyboru
            comboBox1.SelectedIndex = 0;   //pierwszy dostępny port
            comboBox2.SelectedIndex = 6;   //prędkość 19200 - jest 6 z kolei - liczymy od 0

            //aktywacja i deaktywacja odpowiednich kontrolek
            comboBox1.Enabled = true;   //lista z portami
            comboBox2.Enabled = true;   //lista z prędkością
            button3.Enabled = false;    //przycisk wyślij
            button1.Enabled = true;     //przycisk połącz
            button2.Enabled = false;    //przycisk rozłącz
            textBox1.Enabled = false;   //edit box dla wyślij
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zabezpieczenie przed wystąpieniem wyjątku/problemu z otwarciem portu
            try
            {
                //ustawiany jest port, który został wybrany z rozwijanej listy
                serialPort1.PortName = comboBox1.Text;
                //konwersja i ustawienie prędkości transmisji (która została wybrana z rozwijanej listy)
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);

                //otwarcie wybranego portu
                serialPort1.Open();

                //wpisanie do "odebrane"
                richTextBox1.Text += "Połączono dla Port " + serialPort1.PortName + " " + serialPort1.BaudRate.ToString() + "bps \n\r";

                //aktywacja i deaktywacja odpowiednich kontrolek
                comboBox1.Enabled = false;      //lista z portami
                comboBox2.Enabled = false;      //lista z prędkością
                button3.Enabled = true;         //przycisk wyślij
                button1.Enabled = false;        //przycisk połącz
                button2.Enabled = true;         //przycisk rozłącz
                textBox1.Enabled = true;        //edit box dla wyślij
            }
            catch
            {
                //jeżeli wystąpi błąd
                richTextBox1.Text += "Błąd połączenia\n\r";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //zabezpieczenie przed wystąpieniem wyjątku/problemu z zamknięciem portu
            try
            {
                //zamknięciu portu - odłączenie
                serialPort1.Close();

                //wpisanie do "odebrane"
                richTextBox1.Text += "Rozłączono\n\r";

                //aktywacja i deaktywacja odpowiednich kontrolerk
                comboBox1.Enabled = true;   //lista z portami
                comboBox2.Enabled = true;   //lista z prędkością
                button3.Enabled = false;    //przycisk wyślij
                button1.Enabled = true;     //przycisk połącz
                button2.Enabled = false;    //przycisk rozłącz
                textBox1.Enabled = false;   //edit box dla wyślij
            }
            catch
            {
                //jeżeli wystąpi błąd
                richTextBox1.Text += "Błąd z rozłączeniem\n\r";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //wsyłanie danych z kontroli textbox przez port szeregowy
            serialPort1.Write(textBox1.Text.ToString());

            //czy ma wysyłać polecenie powrotu karetki
            if (checkBox1.Checked)
            {
                //wysłanie polecenia powrotu
                serialPort1.Write("\r");
            }

            //czy ma wysyłać polecenie nowej lini
            if (checkBox2.Checked)
            {
                //wysłanie polecenia nowej linii
                serialPort1.Write("\n");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //jeżeli dla komponentu serialport1 jest otwarty port należy do zamknąć
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        /* instrukcje do sterowania kierunkiem pojazdu
         * aby zwiększyć czytelność kodu wartości wpisano do enumeratora
        a - przod
        b - tył
        c - prawo
        d - lewo
        e - przodPrawo
        f - przodLewo
        g - tyłPrawo
        h - tyłLewo
        i - obrotPrawo
        j - obrotLewo
        z - stop*/

        enum kierunekJazdy { przod='a', tyl, prawo, lewo,
                                przodPrawo, przodLewo, tylPrawo, tylLewo,
                                obrotPrawo, obrotLewo, stop='z'}



        #region Przyciski z sekcji podstawowej
        //zdarzenia wciśnięcia buttona dla ruchów przód/tył wraz z obrotami
        private void btnPrzod_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.przod, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }

        private void btnTyl_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.tyl, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }

        private void obrotLewoP_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.obrotLewo, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }

        private void obrotPrawoP_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.obrotPrawo, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }
        #endregion

        #region Przyciski z sekcji dodatkowej
        //zdarzenia wciśnięcia buttona lewo/prawo
        private void btnLewoD_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.lewo, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }

        private void btnPrawoD_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.prawo, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }

        //zdarzenia wciśnięcia buttona jazdy po skosie
        private void btnPrzodPrawoD_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.przodPrawo, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }

        private void btnPrzodLewoD_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.przodLewo, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }

        private void btnTylPrawoD_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.tylPrawo, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }

        private void btnTylLewoD_MouseDown(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.tylLewo, (char)trackBar1.Value };
            serialPort1.Write(ruchRobota, 0, 2);
        }
        #endregion

        //wspólne zdarzenie dla puszczenia klawisza myszy dla sekcji sterowania
        private void btnStop_MouseUp(object sender, MouseEventArgs e)
        {
            char[] ruchRobota = new char[2] { (char)kierunekJazdy.stop, (char)trackBar1.Value };
            try
            {
                serialPort1.Write(ruchRobota, 0, 2);
            }
            catch {   }
            
        }
    }
}
