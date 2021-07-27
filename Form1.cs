using kartoyun.siniflar;
using kartoyun.soyut_sinif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartoyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        test test = new test();
        Bilgisayar bilgisayar = Bilgisayar.nesnever();
        Kullanici kullanici = Kullanici.nesnever();


        private void Form1_Load(object sender, EventArgs e)
        {
            lbx_kart1.Enabled = false;
            lbx_kart2.Enabled = false;
            lbx_kart3.Enabled = false;
            lbx_kart4.Enabled = false;
            lbx_kart5.Enabled = false;
            lbx_kart6.Enabled = false;
            lbx_kart7.Enabled = false;
            lbx_kart8.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test.kartolustur();
            test.kartdagit();

            lbx_kart1.Enabled = true;
            lbx_kart2.Enabled = true;
            lbx_kart3.Enabled = true;
            lbx_kart4.Enabled = true;


            lbx_kart1.Items.Add("isim:" + kullanici.kartlist_futbol[0]._sporcuIsim);
            lbx_kart1.Items.Add("takim:" + kullanici.kartlist_futbol[0]._sporcuTakim);
            lbx_kart1.Items.Add("penalti:" + kullanici.kartlist_futbol[0]._penalti);
            lbx_kart1.Items.Add("serbestatış:" + kullanici.kartlist_futbol[0]._serbestAtis);
            lbx_kart1.Items.Add("kaleci_Karşı:" + kullanici.kartlist_futbol[0]._kaleciKarsiKarsiya);

            lbx_kart2.Items.Add("isim:" + kullanici.kartlist_futbol[1]._sporcuIsim);
            lbx_kart2.Items.Add("takim:" + kullanici.kartlist_futbol[1]._sporcuTakim);
            lbx_kart2.Items.Add("penalti:" + kullanici.kartlist_futbol[1]._penalti);
            lbx_kart2.Items.Add("serbestatış:" + kullanici.kartlist_futbol[1]._serbestAtis);
            lbx_kart2.Items.Add("kaleci_Karşı:" + kullanici.kartlist_futbol[1]._kaleciKarsiKarsiya);

            lbx_kart3.Items.Add("isim:" + kullanici.kartlist_futbol[2]._sporcuIsim);
            lbx_kart3.Items.Add("takim:" + kullanici.kartlist_futbol[2]._sporcuTakim);
            lbx_kart3.Items.Add("penalti:" + kullanici.kartlist_futbol[2]._penalti);
            lbx_kart3.Items.Add("serbestatış:" + kullanici.kartlist_futbol[2]._serbestAtis);
            lbx_kart3.Items.Add("kaleci_Karşı:" + kullanici.kartlist_futbol[2]._kaleciKarsiKarsiya);

            lbx_kart4.Items.Add("isim:" + kullanici.kartlist_futbol[3]._sporcuIsim);
            lbx_kart4.Items.Add("takim:" + kullanici.kartlist_futbol[3]._sporcuTakim);
            lbx_kart4.Items.Add("penalti:" + kullanici.kartlist_futbol[3]._penalti);
            lbx_kart4.Items.Add("serbestatış:" + kullanici.kartlist_futbol[3]._serbestAtis);
            lbx_kart4.Items.Add("kaleci_Karşı:" + kullanici.kartlist_futbol[3]._kaleciKarsiKarsiya);

            lbx_kart5.Items.Add("isim:" + kullanici.kartlist_basket[0]._sporcuIsim);
            lbx_kart5.Items.Add("takim:" + kullanici.kartlist_basket[0]._sporcuTakim);
            lbx_kart5.Items.Add("ikilik:" + kullanici.kartlist_basket[0]._ikilik);
            lbx_kart5.Items.Add("ucluk:" + kullanici.kartlist_basket[0]._ucluk);
            lbx_kart5.Items.Add("serbestAtış:" + kullanici.kartlist_basket[0]._serbestAtis);

            lbx_kart6.Items.Add("isim:" + kullanici.kartlist_basket[1]._sporcuIsim);
            lbx_kart6.Items.Add("takim:" + kullanici.kartlist_basket[1]._sporcuTakim);
            lbx_kart6.Items.Add("ikilik:" + kullanici.kartlist_basket[1]._ikilik);
            lbx_kart6.Items.Add("ucluk:" + kullanici.kartlist_basket[1]._ucluk);
            lbx_kart6.Items.Add("serbestAtış:" + kullanici.kartlist_basket[1]._serbestAtis);

            lbx_kart7.Items.Add("isim:" + kullanici.kartlist_basket[2]._sporcuIsim);
            lbx_kart7.Items.Add("takim:" + kullanici.kartlist_basket[2]._sporcuTakim);
            lbx_kart7.Items.Add("ikilik:" + kullanici.kartlist_basket[2]._ikilik);
            lbx_kart7.Items.Add("ucluk:" + kullanici.kartlist_basket[2]._ucluk);
            lbx_kart7.Items.Add("serbestAtış:" + kullanici.kartlist_basket[2]._serbestAtis);

            lbx_kart8.Items.Add("isim:" + kullanici.kartlist_basket[3]._sporcuIsim);
            lbx_kart8.Items.Add("takim:" + kullanici.kartlist_basket[3]._sporcuTakim);
            lbx_kart8.Items.Add("ikilik:" + kullanici.kartlist_basket[3]._ikilik);
            lbx_kart8.Items.Add("ucluk:" + kullanici.kartlist_basket[3]._ucluk);
            lbx_kart8.Items.Add("serbestAtış:" + kullanici.kartlist_basket[3]._serbestAtis);


        }

        private void cbx_pozisyonbilgi_DropDown(object sender, EventArgs e)
        {
            cbx_pozisyonbilgi.Items.Clear();

           
            if (test.kartno == 0 || test.kartno == 1 || test.kartno == 2 || test.kartno == 3)
            {
                cbx_pozisyonbilgi.Items.Add("penaltı");
                cbx_pozisyonbilgi.Items.Add("serbest atış");
                cbx_pozisyonbilgi.Items.Add("kalecikarsikarsiya");
            }
            if (test.kartno == 4 || test.kartno == 5 || test.kartno == 6 || test.kartno == 7)
            {
                cbx_pozisyonbilgi.Items.Add("ikilik");
                cbx_pozisyonbilgi.Items.Add("üçlük");
                cbx_pozisyonbilgi.Items.Add("serbestatış");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbx_pozisyonbilgi.SelectedItem != null && panel_alan2.Controls.Count != 0)
            {
                if (test.kartno == 0 || test.kartno == 1 || test.kartno == 2 || test.kartno == 3)
                {
                    test.pcsayi = bilgisayar.kartsec();
                    lbx_pckart.Items.Add("isim:" + bilgisayar.kartlist_futbol[test.pcsayi]._sporcuIsim);
                    lbx_pckart.Items.Add("takim:" + bilgisayar.kartlist_futbol[test.pcsayi]._sporcuTakim);
                    lbx_pckart.Items.Add("penalti:" + bilgisayar.kartlist_futbol[test.pcsayi]._penalti);
                    lbx_pckart.Items.Add("serbestatış:" + bilgisayar.kartlist_futbol[test.pcsayi]._serbestAtis);
                    lbx_pckart.Items.Add("kaleci_Karşı:" + bilgisayar.kartlist_futbol[test.pcsayi]._kaleciKarsiKarsiya);
                }
                if (test.kartno == 4 || test.kartno == 5 || test.kartno == 6 || test.kartno == 7)
                {
                    test.pcsayi = bilgisayar.kartsec();
                    lbx_pckart.Items.Add("isim:" + bilgisayar.kartlist_basket[test.pcsayi]._sporcuIsim);
                    lbx_pckart.Items.Add("takim:" + bilgisayar.kartlist_basket[test.pcsayi]._sporcuTakim);
                    lbx_pckart.Items.Add("ikilik:" + bilgisayar.kartlist_basket[test.pcsayi]._ikilik);
                    lbx_pckart.Items.Add("ucluk:" + bilgisayar.kartlist_basket[test.pcsayi]._ucluk);
                    lbx_pckart.Items.Add("serbestAtış:" + bilgisayar.kartlist_basket[test.pcsayi]._serbestAtis);
                }

                this.Refresh(); Thread.Sleep(1000);

                test.oyunoyna(cbx_pozisyonbilgi.SelectedIndex);

                if (test.kontrol == 0) // eşit
                {
                    if (test.kartno == 0)
                    {
                        panel_kart1.Controls.Clear();
                        panel_kart1.Controls.Add(lbx_kart1);
                    }
                    else if (test.kartno == 1)
                    {
                        panel_kart2.Controls.Clear();
                        panel_kart2.Controls.Add(lbx_kart2);
                    }
                    else if (test.kartno == 2)
                    {
                        panel_kart3.Controls.Clear();
                        panel_kart3.Controls.Add(lbx_kart3);
                    }
                    else if (test.kartno == 3)
                    {
                        panel_kart4.Controls.Clear();
                        panel_kart4.Controls.Add(lbx_kart4);
                    }
                    else if (test.kartno == 4)
                    {
                        panel_kart5.Controls.Clear();
                        panel_kart5.Controls.Add(lbx_kart5);
                    }
                    else if (test.kartno == 5)
                    {
                        panel_kart6.Controls.Clear();
                        panel_kart6.Controls.Add(lbx_kart6);
                    }
                    else if (test.kartno == 6)
                    {
                        panel_kart7.Controls.Clear();
                        panel_kart7.Controls.Add(lbx_kart7);
                    }
                    else if (test.kartno == 7)
                    {
                        panel_kart8.Controls.Clear();
                        panel_kart8.Controls.Add(lbx_kart8);
                    }
                    else
                    {
                        MessageBox.Show("farklı kart no !!");
                    }
                    lbx_pckart.Items.Clear();
                    panel_alan2.Controls.Clear();

                }
                else if (test.kontrol == 1) // farklı
                {
                    lbx_pckart.Items.Clear();
                    panel_alan2.Controls.Clear();
                    tbx_puanoyuncu.Text = kullanici._oyuncuSKOR.ToString();
                    tbx_puanpc.Text = bilgisayar._oyuncuSKOR.ToString();

                }
                else
                {
                    MessageBox.Show("farklı sonuç");
                }
               
            }
            else
            {
                MessageBox.Show("Pozisyon bilgisi veya kart seçin");
            }

            if (test.kalankart == 2 && test.kontrol == 0)
            {
                lbx_kart1.Enabled = true;
                lbx_kart2.Enabled = true;
                lbx_kart3.Enabled = true;
                lbx_kart4.Enabled = true;
                lbx_kart5.Enabled = true;
                lbx_kart6.Enabled = true;
                lbx_kart7.Enabled = true;
                lbx_kart8.Enabled = true;
                MessageBox.Show("Pozisyon Bilgisi değiştirip hamle yapın!");
                test.oyunoyna(cbx_pozisyonbilgi.SelectedIndex);
            }

            if (test.kalankart == 0)
            {
                if (kullanici._oyuncuSKOR > bilgisayar._oyuncuSKOR)
                {
                    MessageBox.Show("Kazanan:" + kullanici._oyuncuisim);
                }
                else if (kullanici._oyuncuSKOR < bilgisayar._oyuncuSKOR)
                {
                    MessageBox.Show("Kazanan:" + bilgisayar._oyuncuisim);
                }
                else
                {
                    MessageBox.Show("Oyun Berabere");
                }
            }

            if (test.kartno == 0 || test.kartno == 1 || test.kartno == 2 || test.kartno == 3)
            {
                lbx_kart5.Enabled = true;
                lbx_kart6.Enabled = true;
                lbx_kart7.Enabled = true;
                lbx_kart8.Enabled = true;
                if (panel_kart5.Controls.Count == 0 && panel_kart6.Controls.Count == 0 && panel_kart7.Controls.Count == 0 && panel_kart8.Controls.Count == 0)
                {
                    lbx_kart1.Enabled = true;
                    lbx_kart2.Enabled = true;
                    lbx_kart3.Enabled = true;
                    lbx_kart4.Enabled = true;
                }
            }
            if (test.kartno == 4 || test.kartno == 5 || test.kartno == 6 || test.kartno == 7)
            {
                lbx_kart1.Enabled = true;
                lbx_kart2.Enabled = true;
                lbx_kart3.Enabled = true;
                lbx_kart4.Enabled = true;
                if (panel_kart1.Controls.Count == 0 && panel_kart2.Controls.Count == 0 && panel_kart3.Controls.Count == 0 && panel_kart4.Controls.Count == 0)
                {
                    lbx_kart5.Enabled = true;
                    lbx_kart6.Enabled = true;
                    lbx_kart7.Enabled = true;
                    lbx_kart8.Enabled = true;
                }

            }
            cbx_pozisyonbilgi.Enabled = false;
            cbx_pozisyonbilgi.Text = "";
            
        }

        private void lbx_kart1_MouseClick(object sender, MouseEventArgs e)
        {
            panel_alan2.Controls.Add(lbx_kart1);
            lbx_kart1.Enabled = false;
            lbx_kart2.Enabled = false;
            lbx_kart3.Enabled = false;
            lbx_kart4.Enabled = false;
            test.kartno = 0;
            cbx_pozisyonbilgi.Enabled = true;
        }

        private void lbx_kart2_MouseClick(object sender, MouseEventArgs e)
        {
            panel_alan2.Controls.Add(lbx_kart2);

            lbx_kart1.Enabled = false;
            lbx_kart2.Enabled = false;
            lbx_kart3.Enabled = false;
            lbx_kart4.Enabled = false;

            test.kartno = 1;
            cbx_pozisyonbilgi.Enabled = true;
        }

        private void lbx_kart3_MouseClick(object sender, MouseEventArgs e)
        {
            panel_alan2.Controls.Add(lbx_kart3);

            lbx_kart1.Enabled = false;
            lbx_kart2.Enabled = false;
            lbx_kart3.Enabled = false;
            lbx_kart4.Enabled = false;

            test.kartno = 2;
            cbx_pozisyonbilgi.Enabled = true;
        }

        private void lbx_kart4_MouseClick(object sender, MouseEventArgs e)
        {
            panel_alan2.Controls.Add(lbx_kart4);

            lbx_kart1.Enabled = false;
            lbx_kart2.Enabled = false;
            lbx_kart3.Enabled = false;
            lbx_kart4.Enabled = false;

            test.kartno = 3;
            cbx_pozisyonbilgi.Enabled = true;
        }

        private void lbx_kart5_MouseClick(object sender, MouseEventArgs e)
        {
            panel_alan2.Controls.Add(lbx_kart5);
            lbx_kart5.Enabled = false;
            lbx_kart6.Enabled = false;
            lbx_kart7.Enabled = false;
            lbx_kart8.Enabled = false;

            test.kartno = 4;
            cbx_pozisyonbilgi.Enabled = true;
        }

        private void lbx_kart6_MouseClick(object sender, MouseEventArgs e)
        {
            panel_alan2.Controls.Add(lbx_kart6);
            lbx_kart5.Enabled = false;
            lbx_kart6.Enabled = false;
            lbx_kart7.Enabled = false;
            lbx_kart8.Enabled = false;
            test.kartno = 5;
            cbx_pozisyonbilgi.Enabled = true;
        }

        private void lbx_kart7_MouseClick(object sender, MouseEventArgs e)
        {
            panel_alan2.Controls.Add(lbx_kart7);
            lbx_kart5.Enabled = false;
            lbx_kart6.Enabled = false;
            lbx_kart7.Enabled = false;
            lbx_kart8.Enabled = false;
            test.kartno = 6;
            cbx_pozisyonbilgi.Enabled = true;
        }

        private void lbx_kart8_MouseClick(object sender, MouseEventArgs e)
        {
            panel_alan2.Controls.Add(lbx_kart8);
            lbx_kart5.Enabled = false;
            lbx_kart6.Enabled = false;
            lbx_kart7.Enabled = false;
            lbx_kart8.Enabled = false;
            test.kartno = 7;
            cbx_pozisyonbilgi.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
