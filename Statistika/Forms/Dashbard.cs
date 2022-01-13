//using Entities.Concrete;
//using HtmlAgilityPack;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using System.Text.RegularExpressions;
//using Excel = Microsoft.Office.Interop.Excel;

//namespace Statistika.Forms
//{
//    public partial class Dashbard : Form
//    {
//        HtmlWeb htmlWeb = new HtmlWeb();
//        public Dashbard()
//        {
//            InitializeComponent();
//        }

//        private void Dashbard_Load(object sender, EventArgs e)
//        {
//            labelFbSuccesIcon.Visible = false;
//            labelFbErrorIcon.Visible = false;
//            labelInstaSuccessIcon.Visible = false;
//            labelInstaErrorIcon.Visible = false;
//            DateTime date = DateTime.Now;
//            if (date.Hour == 5 || date.Hour == 6 || date.Hour == 7 || date.Hour == 8)
//            {
//                DateTimeMessage("Nə tez gəlmisən ?");
//            }
//            if (date.Hour == 9)
//            {
//                DateTimeMessage("Məsuliyyətli işçi, afərin sənə");
//            }
//            if (date.Hour == 10 || date.Hour == 11 || date.Hour == 12)
//            {
//                DateTimeMessage("Sanki birəz işə gecikmisən");
//            }
//            if (date.Hour == 13 || date.Hour == 14 || date.Hour == 13 || date.Hour == 15 || date.Hour == 16 || date.Hour == 17)
//            {
//                DateTimeMessage("Niyə belə gecikmisən ? Nəsə kömək edə biləcəyimiz birşey varmı?");
//            }
//            if (date.Hour == 18 || date.Hour == 19 || date.Hour == 20 || date.Hour == 21 || date.Hour == 22 || date.Hour == 23 || date.Hour == 24 || date.Hour == 1 || date.Hour == 2 || date.Hour == 3 || date.Hour == 4 || date.Hour < 5)
//            {
//                DateTimeMessage("Bugün iş birəz çox olub deyəsən ?");
//            }

//        }

//        List<string> linksFacebook = new List<string>() { "https://www.facebook.com/Ucar-KOB-%C4%B0nki%C5%9Faf-M%C9%99rk%C9%99zi-107636808252467",
//                                                           "https://www.facebook.com/gencekobim",
//                                                           "https://www.facebook.com/kobimgoycay/",
//                                                           "https://www.facebook.com/kobimlenkeran",
//                                                           "https://www.facebook.com/absheronkobim",
//                                                           "https://www.facebook.com/kobimshamaxiismayilli",
//                                                           "https://www.facebook.com/nadirovasimare",
//                                                           "https://www.facebook.com/masallicelilabadbilesuvarkobim/",
//                                                           "https://www.facebook.com/neftchalasalyankobim",
//                                                           "https://www.facebook.com/kobimbeyleqanimishli",
//                                                           "https://www.facebook.com/agsukurdemirkobim",
//                                                           "https://www.facebook.com/zaqatalabalakankobim/",
//                                                           "https://www.facebook.com/mingechevirkobim",
//                                                           "https://www.facebook.com/g%c3%b6yg%c3%b6l-da%c5%9fk%c9%99s%c9%99n-kob-%c4%b0nki%c5%9faf-m%c9%99rk%c9%99zi-111070697898915",
//                                                           "https://www.facebook.com/shemkirgedebeykobim",
//                                                           "https://www.facebook.com/tovuzkobim",
//                                                           "https://www.facebook.com/kobimbaki",
//                                                           "https://www.facebook.com/sumgaitkobim",
//                                                           "https://www.facebook.com/kobimkhachmaz",
//                                                           "https://www.facebook.com/%c5%9e%c9%99ki-kob-%c4%b0nki%c5%9faf-m%c9%99rk%c9%99zi-100863908642697/",
//                                                           "https://www.facebook.com/kobimyevlax/"

//                };
//        List<string> linksInstagram = new List<string>() { "https://www.instagram.com/kobimucar/",
//                                                           "https://www.instagram.com/gencekobim/",
//                                                           "https://www.instagram.com/kobimgoycayagdas/",
//                                                           "https://www.instagram.com/kobimlenkeran/",
//                                                           "https://www.instagram.com/kobimabsheron/",
//                                                           "https://www.instagram.com/samaxiismayillikobim/",
//                                                           "https://www.instagram.com/saatli__sabirabad_kobim/",
//                                                           "https://www.instagram.com/masallicelilabadbilesuvarkobim/",
//                                                           "https://www.instagram.com/neftchalasalyankobim/",
//                                                           "https://www.instagram.com/kobimbeyleqanimishli/",
//                                                           "https://www.instagram.com/agsukurdemirkobim/",
//                                                           "https://www.instagram.com/zaqatalabalakenkobim/",
//                                                           "https://www.instagram.com/mingechevirkobim/",
//                                                           "https://www.instagram.com/smb.goygol_dashkesen/",
//                                                           "https://www.instagram.com/shemkirgedebeykobim/",
//                                                           "https://www.instagram.com/tovuzkobim/",
//                                                           "https://www.instagram.com/kobimbaki/",
//                                                           "https://www.instagram.com/kobimsumgayit/",
//                                                           "https://www.instagram.com/khachmazkobim/",
//                                                           "https://www.instagram.com/shakikobim/",
//                                                           "https://www.instagram.com/kobimyevlax/"

//                };

//        List<string> linksYoutube = new List<string>() { "https://www.youtube.com/channel/UCWX4ddSZ2J5mhWzQGWJOq5w",
//                                                           //"gencekobim",
//                                                           //"kobimgoycayagdas",
//                                                           //"kobimlenkeran",
//                                                           //"kobimabsheron",
//                                                           //"samaxiismayillikobim",
//                                                           //"saatli__sabirabad_kobim",
//                                                           //"masallicelilabadbilesuvarkobim",
//                                                           //"neftchalasalyankobim",
//                                                           //"kobimbeyleqanimishli/",
//                                                           //"agsukurdemirkobim/",
//                                                           //"zaqatalabalakenkobim/",
//                                                           //"mingechevirkobim/",
//                                                           //"smb.goygol_dashkesen/",
//                                                           //"shemkirgedebeykobim/",
//                                                           //"tovuzkobim/",
//                                                           //"kobimbaki/",
//                                                           //"kobimsumgayit/",
//                                                           //"khachmazkobim/",
//                                                           //"shakikobim/",
//                                                           //"kobimyevlax/"

//                };

//        List<string> bolgeler = new List<string>(){
//                                            "Ucar-Zərdab",
//                                            "Gəncə",
//                                            "Göyçay-Ağdaş",
//                                            "Lənkəran",
//                                            "Abşeron",
//                                            "Şamaxı-İsmayıllı",
//                                            "Saatlı-Sabirabad",
//                                            "Masallı-Cəlilabad-Biləsuvar",
//                                            "Neftcala-Salyan",
//                                            "Beyləqan-İmişli",
//                                            "Ağsu-Kurdemir",
//                                            "Zaqatala-Balakən",
//                                            "Mingecevir",
//                                            "Göygöl-Daşkəsən",
//                                            "Şəmkir-Gədəbəy",
//                                            "Tovuz",
//                                            "Baki",
//                                            "Sumqayit",
//                                            "Xaçmaz",
//                                            "Şəki",
//                                            "Yevlax"
//                };

//        private void buttonGetir_Click(object sender, EventArgs e)
//        {
//            listBoxFacebook.Items.Clear();
//            labelFacebook.Text = "";
//            FacebookWrite();

//        }

//        private void buttonInstagramGetir_Click(object sender, EventArgs e)
//        {
//            listBoxInstagram.Items.Clear();
//            labelInstagram.Text = "";
//            InstagramWrite();
//        }



//        private void FacebookWrite()
//        {
//            try
//            {
//                labelFbSuccesIcon.Visible = false;
//                labelFbErrorIcon.Visible = false;
//                for (int i = 0; i < linksFacebook.Count; i++)
//                {

//                    var doc = htmlWeb.Load(linksFacebook[i]);
//                    HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//div[@class='clearfix _ikh']");
//                    for (int j = 1; j < 2; j++)
//                    {
//                        string followers = results[j].SelectSingleNode("./div[@class='_4bl9']").InnerText;
//                        string[] numbers = Regex.Split(followers, @"\D+");
//                        string oldNumber = "";
//                        foreach (string number in numbers)
//                        {
//                            int say;
//                            if (int.TryParse(number, out say))
//                            {
//                                oldNumber += number;
//                            }
//                        }
//                        listBoxFacebook.Items.Add(oldNumber);
//                    }
//                }
//                labelFacebook.Text = listBoxFacebook.Items.Count.ToString();
//                SuccesMessage("Facebook");
//                labelFbSuccesIcon.Visible = true;

//            }
//            catch (Exception)
//            {
//                ErrorMessage();
//                labelFbErrorIcon.Visible = true;
//                return;
//            }
//        }

//        private void InstagramWrite()
//        {
//            try
//            {
//                labelInstaSuccessIcon.Visible = false;
//                labelInstaErrorIcon.Visible = false;
//                for (int i = 0; i < linksInstagram.Count; i++)
//                {
//                    var doc = htmlWeb.Load(linksInstagram[i]);
//                    HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//meta[@property='og:description']");
//                    for (int j = 0; j < 1; j++)
//                    {
//                        string followers = results[j].Attributes["content"].Value.Remove(8);
//                        string[] numbers = Regex.Split(followers, @"\D+");
//                        string oldNumber = "";
//                        foreach (string number in numbers)
//                        {
//                            int say;
//                            if (int.TryParse(number, out say))
//                            {
//                                oldNumber += number;
//                            }
//                        }
//                        listBoxInstagram.Items.Add(oldNumber);
//                    }
//                }
//                labelInstagram.Text = listBoxInstagram.Items.Count.ToString();
//                SuccesMessage("Instagram");
//                labelInstaSuccessIcon.Visible = true;

//            }
//            catch (Exception)
//            {
//                ErrorMessage();
//                labelInstaErrorIcon.Visible = true;
//                return;
//            }
//        }


//        private void CreateExcel()
//        {
//            Excel.Application excelApp = new Excel.Application();
//            excelApp.Workbooks.Add();

//            for (int i = 0; i < bolgeler.Count; i++)
//            {
//                excelApp.Cells[i + 1, 1] = bolgeler[i];
//            }
//            for (int i = 0; i < listBoxFacebook.Items.Count; i++)
//            {
//                string result = listBoxFacebook.Items[i].ToString();
//                excelApp.Cells[i + 1, 3] = result;
//            }

//            for (int i = 0; i < listBoxInstagram.Items.Count; i++)
//            {
//                string result = listBoxInstagram.Items[i].ToString();
//                excelApp.Cells[i + 1, 2] = result;
//            }
//            excelApp.Visible = true;
//        }


//        private void buttonYaz_Click(object sender, EventArgs e)
//        {
//            CreateExcel();
//        }

//        //Message
//        private void ErrorMessage()
//        {
//            MessageBox.Show("Internet xətası zəhmət olmasa interneti yoxlayıb yenidən cəhd edin", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }

//        private void SuccesMessage(string website)
//        {
//            string result = "";
//            result = "takipçiləri";
//            string message = "Kobimlərin " + website + $" səhifələrinin {result} müvəffəqiyyətlə sıralandı";
//            MessageBox.Show(message, "Uğurlu cəhd", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        private void DateTimeMessage(string message)
//        {
//            string result = "Cabbar Allahverdiyevdən mesaj : " + message;
//            MessageBox.Show(result, "Xoş gəlmisən", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        private void labelInstagram_Click(object sender, EventArgs e)
//        {

//        }




//        //--------------

//    }
//}
