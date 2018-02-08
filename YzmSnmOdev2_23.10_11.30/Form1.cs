using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace YzmSnmOdev2_23._10_11._30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 0 duvar , 1 yol
        int uzaklik;
        //kuzey güney doğu batı belirlemek icin
        int[] satirNum = { -1, 0, 0, 1 };
        int[] sutunNum = { 0, -1, 1, 0 };
        int[,] yol;
        Stack<point> st = new Stack<point>();

        point fare = new point();
        point peynir = new point();

        int fareSayisi = 0;
        int peynirSayisi = 0;
        bool kaldir = false;

        bool[,] visited;
        bool duvarEkle = false;
        bool fareEkle = false;
        bool peynirEkle = false;
        int[,] dizi;
        Button[,] butonlar;
        int en = 0, boy = 0;
      
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_AddWalls.Enabled = false;
           
            btn_AddMouse.Enabled = false;
            btn_AddCheese.Enabled = false;
            btn_Start.Enabled = false;
            btn_Kaldir.Enabled = false;
        }

        //txtboxlarin sadece sayı alması
        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btn_DrawMap_Click(object sender, EventArgs e)
        {
            
            gbx_Labyrinth.SetBounds(0, 0, 0, 0);
            gbx_Labyrinth.AutoSize = true;
            gbx_ControlPanel.Width = 375;
            gbx_ControlPanel.Height = 440;

            if(txt_Height.Text!="" && txt_Width.Text!="")
            { en = Convert.ToInt32(txt_Width.Text);
            boy = Convert.ToInt32(txt_Height.Text);
            dizi = new int[boy, en];
            butonlar = new Button[boy, en];
            visited = new bool[boy, en];
            gbx_Labyrinth.Height = boy * 50 - 15;
            gbx_Labyrinth.Width = en * 50 - 5;
            yol= new int[boy, en];
            for (int i = 0; i < boy; i++)
            {
                for (int j = 0; j < en; j++)
                {
                    dizi[i, j] = 1;
                    visited[i, j] = false;
                    yol[i, j] = -1;
                }
            }
            //basta butun hucreleri yol olarak belirliyoruz
            for (int i = 0; i < boy; i++)
            {
                for (int j = 0; j < en; j++)
                {
                    Button b = new Button();

                    b.Width = 50;
                    b.Height = 50;
                    b.Top = i * 50;
                    b.Left = j * 50;
                    b.FlatStyle = FlatStyle.Flat;

                    b.Click += b_Click;
                    b.Tag = "yol";

                    b.Image = Properties.Resources.road;
                    ////////// kenarlara duvar ekleme
                    /*
                    if (i == 0 || j == 0 || i == boy - 1 || j == en - 1)
                    {
                        b.Tag = "duvar";
                        b.Image = Properties.Resources.wall;
                        dizi[b.Top / 50, b.Left / 50] = 0;
                    }
                    */
                    ///////
                    gbx_Labyrinth.Controls.Add(b);
                    butonlar[i, j] = b;
                }
            }
            gbx_ControlPanel.SetBounds((gbx_Labyrinth.Width) -1, 0, 0, 0);

          

            gbx_ControlPanel.AutoSize = true;
           
            btn_DrawMap.Enabled = false;
            txt_Width.Enabled = false;
            txt_Height.Enabled = false;

            btn_AddWalls.Enabled = true;
                btn_AddMouse.Enabled = true;
                btn_AddCheese.Enabled = true;
                gbx_Labyrinth.Enabled = true;
                btn_Start.Enabled = true;
                btn_Kaldir.Enabled = true;
            }
            else MessageBox.Show("Textboxları boş bırakmayınız ve pozitif tamsayı haricinde bir değer girmeyiniz!!!");


        }

        private void btn_AddWalls_Click(object sender, EventArgs e)
        {
            kaldir = false;
            duvarEkle = true;
            fareEkle = false;
            peynirEkle = false;
            
            
        }

       
        private void btn_AddMouse_Click(object sender, EventArgs e)
        {

            kaldir = false;
            fareEkle = true;
            duvarEkle = false;
            peynirEkle = false;   
        }

        private void btn_AddCheese_Click(object sender, EventArgs e)
        {

            kaldir = false;
            peynirEkle = true;
            duvarEkle = false;
            fareEkle = false;
            
        }

        private void b_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            
            // tıklanılan butonu duvar yapıyor
                if (duvarEkle == true && b.Tag.ToString() != "peynir" && b.Tag.ToString() != "fare")
                {

                    b.Image = Properties.Resources.wall;

                    dizi[b.Top / 50, b.Left / 50] = 0;
                    b.Tag = "duvar";
                    
                }
            // tıklanılan butonu fare yapıyor
            if (fareEkle == true && b.Tag.ToString() != "duvar" &&  b.Tag.ToString() != "peynir")
                {
                if(fareSayisi!=0)
                {
                    MessageBox.Show("Haritada 1 tane fare olabilir.");
                }
                else
                {
                    fareSayisi++;
                    fareEkle = false;
                    b.Image = Properties.Resources.mice_dogu;
                    
                    
                    b.Tag = "fare";
                    
                    
                fare.x = b.Left / 50;
                fare.y = b.Top / 50;
                }
                
                }
            // tıklanılan butonu peynir yapıyor
            if (peynirEkle == true && b.Tag.ToString() != "duvar" && b.Tag.ToString() != "fare"  )
                {
                if(peynirSayisi!=0)
                {
                    MessageBox.Show("Haritada 1 tane peynir olabilir.");
                }
                else
                {
                    peynirSayisi++;
                    peynirEkle = false;
                    b.Image = Properties.Resources.cheese;
                    b.Tag = "peynir";
                    
                peynir.x = b.Left / 50;
                peynir.y = b.Top / 50;
                }
                
            }
            if (kaldir == true)
            {
                if (b.Tag.ToString() == "duvar")
                {
                    b.Image = Properties.Resources.road;
                    dizi[b.Top / 50, b.Left / 50] = 1;
                    b.Tag = "yol";
                    kaldir = false;
                }
                else if (b.Tag.ToString() == "fare")
                {
                    b.Image = Properties.Resources.road;
                    dizi[b.Top / 50, b.Left / 50] = 1;
                    b.Tag = "yol";
                    kaldir = false;
                    fareSayisi--;
                }
                else if (b.Tag.ToString() == "peynir")
                {
                    b.Image = Properties.Resources.road;
                    dizi[b.Top / 50, b.Left / 50] = 1;
                    b.Tag = "yol";
                    kaldir = false;
                    peynirSayisi--;
                }
                else
                {
                    MessageBox.Show("Burası zaten boş");
                    kaldir = false;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            point pt = new point();
            if (st.Count != 0)
            {
                pt=st.Pop();
                butonlar[fare.y, fare.x].Image = Properties.Resources.roadPassed;
                

                if(fare.x<pt.x)
                    butonlar[pt.y, pt.x].Image = Properties.Resources.mice_dogu;
                else if(fare.x>pt.x)
                    butonlar[pt.y, pt.x].Image = Properties.Resources.mice_bati;
                else if (fare.y > pt.y)
                    butonlar[pt.y, pt.x].Image = Properties.Resources.mice_kuzey;
                else if (fare.y < pt.y)
                    butonlar[pt.y, pt.x].Image = Properties.Resources.mice_guney;

                
                fare.y = pt.y;
                fare.x = pt.x;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Peynir Bulundu!!!");
                
            }
            
           
        }
        private bool Gecerli(int satir, int sutun,int yon)
        {
            if (yon == 0)
            {
                return satir>= 0;
            }
            else if (yon == 1)
            {
                return sutun >= 0;
            }
            else if (yon == 2)
            {
                return sutun < boy;
            }
            else if (yon == 3)
            {
                return satir< en;
            }

            else { MessageBox.Show("Hata"); return false; } 
          
        }
        private int Bfs (point src,point dest)
        {
            visited[src.y, src.x] = true;
            Queue<QueueNode> q=new Queue<QueueNode>();

            QueueNode s = new QueueNode();
            s.pt = src;
            s.Uzaklik = 0;
            q.Enqueue(s);
            yol[src.y, src.x] = s.Uzaklik;

            int yon;

            while (q.Count!=0)
            {
                yon = 0;
                QueueNode curr = q.Peek();
                point pt = curr.pt;


                uzaklik = curr.Uzaklik;
                //peyniri buldugunda uzakligi donduruyor
                if (pt.x == dest.x && pt.y == dest.y)
                    return curr.Uzaklik;

                
                q.Dequeue();
                //sırasıyla bati kuzey guney dogu yonlerine bakılıyor
                for (int i = 0; i < 4; i++)
                {
                    int satir= pt.x + satirNum[i];
                    int sutun = pt.y + sutunNum[i];
                    
                    //belirtilen yon labirentin icerisinde , ziyaret edilmemis ve duvar degilse o yonu de ziyaret ediyoruz ve queue nun icine atıyoruz
                    if (Gecerli(satir,sutun,yon) && dizi[sutun,satir]==1 &&
                       !visited[sutun,satir])
                    {
                      
                        visited[sutun,satir] = true;
                        QueueNode Adjcell=new QueueNode();
                        Adjcell.pt.x = satir;
                        Adjcell.pt.y = sutun;
                        Adjcell.Uzaklik = curr.Uzaklik + 1;
                        q.Enqueue(Adjcell);
                        yol[Adjcell.pt.y, Adjcell.pt.x] = Adjcell.Uzaklik;
                        //butonlar[Adjcell.pt.y, Adjcell.pt.x].Text = Adjcell.Uzaklik.ToString();
                    }
                    yon++;
                }
            }

            //fpeyniri bulamadıysa -1 donduruyor
            return -1;
            
        }

        private void btn_Kaldir_Click(object sender, EventArgs e)
        {
            kaldir = true;
            duvarEkle = false;
            peynirEkle = false;
            fareEkle = false;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int adim = 0;
            duvarEkle = false;
            if(fareSayisi==1 && peynirSayisi==1)
            {
                btn_Start.Enabled = false;
                btn_Kaldir.Enabled = false;
                btn_AddMouse.Enabled = false;
                btn_AddWalls.Enabled = false;
                btn_AddCheese.Enabled = false;
                adim = Bfs(fare, peynir);
                //adim -1 donmusse farenin veya peynirin etrafi cevrilidir
                if (adim!=-1)
                {
                    MessageBox.Show("Fare " + adim.ToString() + " adımda peynire ulaşabiliyor.");

                    point peynir_buffer;

                    peynir_buffer = new point();
                    peynir_buffer.x = peynir.x;
                    peynir_buffer.y = peynir.y;


                    int yon;


                    while (peynir_buffer.x != fare.x || peynir_buffer.y != fare.y)
                    {
                        yon = 0;
                        st.Push(peynir_buffer);
                        uzaklik--;

                        //kuzey guney dogu batida uzaklikla aynı degerde point varsa onu peynirbuffer yap
                        for (int i = 0; i < 4; i++)
                        {
                            int satir= peynir_buffer.x + satirNum[i];
                            int sutun = peynir_buffer.y + sutunNum[i];


                            if (Gecerli(satir, sutun, yon) && yol[sutun, satir] == uzaklik)
                            {
                                peynir_buffer = new point();
                                peynir_buffer.x = satir;
                                peynir_buffer.y = sutun;

                                break;
                            }
                            yon++;
                        }
                    }


                    timer1.Enabled = true;

                    timer1.Interval = 150;
                }
                else MessageBox.Show("Fare peynire ulaşamadı!!!");

            }

            else MessageBox.Show("Haritada 1 fare ve 1 peynir olmalı!!!");
        }
    }
}
