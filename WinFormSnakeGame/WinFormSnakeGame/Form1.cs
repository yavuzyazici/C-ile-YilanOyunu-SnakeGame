using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSnakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<KareInfo> listKare = new List<KareInfo>();
        List<KareInfo> listUzuv = new List<KareInfo>();
        YilanInfo yilanInfo = null;
        int kareSayi = 40;
        int yon = 2;
        int toplamKareSayisi = 0;
        bool gameOver = false;
        bool yemVar = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            toplamKareSayisi = kareSayi * kareSayi;

            int KareKenarUzunluk = 12;
            int kareX = 1;
            int kareY = 1;
            int margin = 2;

            for (int i = 0; i < toplamKareSayisi; i++)
            {
                KareInfo kareInfo = new KareInfo(this.panel, new Point(kareX, kareY), new Size(KareKenarUzunluk, KareKenarUzunluk), i);
                listKare.Add(kareInfo);

                kareX += KareKenarUzunluk + margin;
                if ((i + 1) % 40 == 0)
                {
                    kareX = 1;
                    kareY += KareKenarUzunluk + margin;
                }
            }
            sinirEkle();
            yilanInfo = new YilanInfo(listKare, listUzuv);
        }

        void newgame()
        {
            timer.Start();

            foreach (KareInfo item in listKare)
            {
                if (!item.sinir)
                {
                    item.uzuvYapma();
                    item.yemYapma();
                }
            }

            gameOver = false;
            yon = 2;
            yemVar = false;
            lblSkor.Text = "0";
            listUzuv.Clear();
            yilanInfo = new YilanInfo(listKare, listUzuv);
        }


        public void GameOver()
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Yeniden oynamak ister misiniz ? ", "Kaybettiniz", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                newgame();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void restart()
        {
            Form1 startForm = new Form1();
            this.Hide();
            startForm.Show();

            Application.Restart();

        }
        void yemEkle()
        {
            if (yemVar)
            {
                return;
            }

            Random random = new Random();
            int indis = 0;
            bool durum = false;

            while (durum == false)
            {
                indis = random.Next(0, toplamKareSayisi + 1);
                durum = true;

                if (this.listKare[indis].uzuv || this.listKare[indis].sinir)
                {
                    durum = false;
                }
            }

            if (durum)
            {
                this.listKare[indis].yemYap();
                this.yemVar = true;
            }
        }

        void sinirEkle()
        {
            for (int i = 0; i <= 39; i += 1)
            {
                listKare[i].sinirYap();
            }

            for (int i = 0; i <= 1560; i += 40)
            {
                listKare[i].sinirYap();
            }

            for (int i = 1560; i <= 1599; i += 1)
            {
                listKare[i].sinirYap();
            }

            for (int i = 39; i <= 1599; i += 40)
            {
                listKare[i].sinirYap();
            }
        }

        class KareInfo
        {
            public Point location { get; set; }
            public Size size { get; set; }
            public Color backColor { get; set; }
            public PictureBox pictureBox { get; set; }

            public int indis { get; set; }
            public bool uzuv { get; set; }
            public bool yem { get; set; }
            public bool sinir { get; set; }

            public Panel panel { get; set; }

            public KareInfo(Panel panel, Point location, Size size, int indis)
            {
                this.panel = panel;
                this.location = location;
                this.size = size;
                this.indis = indis;
                this.backColor = Color.Black;
                this.uzuv = false;
                this.yem = false;
                this.sinir = false;
                pictureBoxAdd();
            }

            void pictureBoxAdd()
            {
                pictureBox = new PictureBox();
                pictureBox.Location = this.location;
                pictureBox.Size = this.size;
                pictureBox.BackColor = this.backColor;
                this.panel.Controls.Add(pictureBox);
            }

            public void uzuvYap()
            {
                this.pictureBox.BackColor = Color.GreenYellow;
                this.uzuv = true;
            }

            public void uzuvYapma()
            {
                this.pictureBox.BackColor = this.backColor;
                this.uzuv = false;
            }

            public void yemYap()
            {
                this.pictureBox.BackColor = Color.Red;
                this.yem = true;
            }

            public void yemYapma()
            {
                this.pictureBox.BackColor = this.backColor;
                this.yem = false;
            }

            public void sinirYap()
            {
                this.pictureBox.BackColor = Color.Gray;
                this.sinir = true;
            }

        }

        class YilanInfo
        {
            public int startPosition = 43;
            public int yon { get; set; }
            public List<KareInfo> listKare { get; set; }
            public List<KareInfo> listUzuv { get; set; }



            public YilanInfo(List<KareInfo> listKare, List<KareInfo> listUzuv)
            {
                this.listKare = listKare;
                this.listUzuv = listUzuv;

                this.listKare[41].uzuvYap();
                this.listKare[42].uzuvYap();
                this.listKare[43].uzuvYap();

                this.listUzuv.Add(this.listKare[41]);
                this.listUzuv.Add(this.listKare[42]);
                this.listUzuv.Add(this.listKare[43]);
            }

            public int yurut(int yon)
            {
                this.yon = yon;

                switch (yon)
                {
                    case 1:
                        startPosition = startPosition - 40;
                        break;

                    case 2:
                        startPosition = startPosition + 1;
                        break;

                    case 3:
                        startPosition = startPosition + 40;
                        break;

                    case 4:
                        startPosition = startPosition - 1;
                        break;

                    default:
                        break;
                }


                if (this.listKare[startPosition].uzuv || this.listKare[startPosition].sinir)
                {
                    return 0;//Hata Varsa (Oyun Bitiyor)
                }
                else
                {
                    this.listKare[startPosition].uzuvYap();
                    this.listUzuv.Add(this.listKare[startPosition]);

                    if (this.listKare[startPosition].yem)
                    {
                        this.listKare[startPosition].yem = false;

                        return 2; // Yem yenmiş ise
                    }
                    else
                    {
                        this.listKare[this.listUzuv[0].indis].uzuvYapma();
                        this.listUzuv.RemoveAt(0);

                        return 1;//Kuyruk silinmiş ise
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            yemEkle();
            int sonuc = yilanInfo.yurut(yon);

            switch (sonuc)
            {
                case 0:
                    timer.Stop();
                    gameOver = true;
                    GameOver();
                    break;

                case 1:

                    break;

                case 2:
                    yemVar = false;
                    lblSkor.Text = Convert.ToString(Convert.ToInt32(lblSkor.Text) + 1);
                    break;

                default:
                    break;
            }
        }

        private void pictureUp_Click(object sender, EventArgs e)
        {
            if (yilanInfo.yon != 3)
            {
                yon = 1;
            }
        }

        private void pictureRight_Click(object sender, EventArgs e)
        {
            if (yilanInfo.yon != 4)
            {
                yon = 2;
            }
        }
        private void pictureLeft_Click(object sender, EventArgs e)
        {
            if (yilanInfo.yon != 2)
            {
                yon = 4;
            }
        }

        private void pictureDown_Click(object sender, EventArgs e)
        {
            if (yilanInfo.yon != 1)
            {
                yon = 3;
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                timer.Stop();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {

            if (keyData == Keys.Up)
            {
                if (yilanInfo.yon != 3)
                {
                    yon = 1;
                }
            }

            if (keyData == Keys.Right)
            {
                if (yilanInfo.yon != 4)
                {
                    yon = 2;
                }
            }

            if (keyData == Keys.Down)
            {
                if (yilanInfo.yon != 1)
                {
                    yon = 3;
                }
            }

            if (keyData == Keys.Left)
            {
                if (yilanInfo.yon != 2)
                {
                    yon = 4;
                }
            }
            if (keyData == Keys.W)
            {
                if (yilanInfo.yon != 3)
                {
                    yon = 1;
                }
            }

            if (keyData == Keys.D)
            {
                if (yilanInfo.yon != 4)
                {
                    yon = 2;
                }
            }

            if (keyData == Keys.S)
            {
                if (yilanInfo.yon != 1)
                {
                    yon = 3;
                }
            }

            if (keyData == Keys.A)
            {
                if (yilanInfo.yon != 2)
                {
                    yon = 4;
                }
            }

            if (keyData == Keys.R)
            {
                newgame();
            }

            if (keyData == Keys.NumPad0)
            {
                btnCokKolayMod.PerformClick();
            }

            if (keyData == Keys.NumPad1)
            {
                btnKolayMod.PerformClick();
            }

            if (keyData == Keys.NumPad2)
            {
                btnOrtaMod.PerformClick();
            }

            if (keyData == Keys.NumPad3)
            {
                btnZorMod.PerformClick();
            }

            if (keyData == Keys.NumPad4)
            {
                btnExtremeMod.PerformClick();
            }

            if (keyData == Keys.NumPad5)
            {
                btnImkansizMod.PerformClick();
            }

            if (keyData == Keys.Enter)
            {
                btnBaslat.PerformClick();
            }

            if (keyData == Keys.Space)
            {
                btnDurdur.PerformClick();
            }


            return base.ProcessDialogKey(keyData);
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            newgame();
        }

        private void btnCokKolayMod_Click(object sender, EventArgs e)
        {
            timer.Interval = 200;
        }

        private void btnKolayMod_Click(object sender, EventArgs e)
        {
            timer.Interval = 140;
        }

        private void btnOrtaMod_Click(object sender, EventArgs e)
        {
            timer.Interval = 75;
        }

        private void btnZorMod_Click(object sender, EventArgs e)
        {
            timer.Interval = 50;
        }

        private void btnExtremeMod_Click(object sender, EventArgs e)
        {
            timer.Interval = 30;
        }

        private void btnImkansizMod_Click(object sender, EventArgs e)
        {
            timer.Interval = 15;
        }
    }
}
