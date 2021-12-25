using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatistikaForm.Entities.Concrete;
using HtmlAgilityPack;
using System.Threading;

namespace StatistikaForm.Forms
{
    public partial class Dashboard : Form
    {
        HtmlWeb htmlWeb = new HtmlWeb();
        public Dashboard()
        {
            InitializeComponent();
        }


        private void buttonGetir_Click(object sender, EventArgs e)
        {
            FacebookWrite();
            //InstagramWrite();
            // YoutubeWrite();
            // LinkedInWrite();

        }

        private void FacebookWrite()
        {
            try
            {
                //string followers="";
                List<Kobim> kobim = new List<Kobim>();
                List<string> links = new List<string>() { "https://www.facebook.com/Ucar-KOB-%C4%B0nki%C5%9Faf-M%C9%99rk%C9%99zi-107636808252467",
                                                           "https://www.facebook.com/gencekobim",
                                                           "https://www.facebook.com/kobimgoycay/",
                                                           "https://www.facebook.com/kobimlenkeran",
                                                           //"https://www.facebook.com/absheronkobim",
                                                           //"https://www.facebook.com/kobimshamaxiismayilli",
                                                           //"https://www.facebook.com/NadirovaSimare",
                                                           //"https://www.facebook.com/Masallicelilabadbilesuvarkobim/",
                                                           //"https://www.facebook.com/neftchalasalyankobim",
                                                           //"https://www.facebook.com/kobimbeyleqanimishli",
                                                           //"https://www.facebook.com/agsukurdemirkobim",
                                                           //"https://www.facebook.com/zaqatalabalakankobim/",
                                                           //"https://www.facebook.com/mingechevirkobim",
                                                           //"https://www.facebook.com/G%C3%B6yg%C3%B6l-Da%C5%9Fk%C9%99s%C9%99n-KOB-%C4%B0nki%C5%9Faf-M%C9%99rk%C9%99zi-111070697898915",
                                                           //"https://www.facebook.com/shemkirgedebeykobim",
                                                           //"https://www.facebook.com/TovuzKOBIM",
                                                           //"https://www.facebook.com/kobimbaki",
                                                           //"https://www.facebook.com/sumgaitkobim",
                                                           //"https://www.facebook.com/kobimkhachmaz",
                                                           //"https://www.facebook.com/%C5%9E%C9%99ki-KOB-%C4%B0nki%C5%9Faf-M%C9%99rk%C9%99zi-100863908642697/",
                                                           //"https://www.facebook.com/kobimyevlax/"

                };

                List<string> bolgeler = new List<string>(){
                                            "Ucar-Zərdab",
                                            "Gəncə",
                                            "Göyçay-Ağdaş",
                                            "Lənkəran",
                                            "Abşeron",
                                            "Şamaxı-İsmayıllı",
                                            "Saatlı-Sabirabad",
                                            "Masallı-Cəlilabad-Biləsuvar",
                                            "Neftcala-Salyan",
                                            "Beyləqan-İmişli",
                                            "Ağsu-Kurdemir",
                                            "Zaqatala-Balakən",
                                            "Mingecevir",
                                            "Göygöl-Daşkəsən",
                                            "Şəmkir-Gədəbəy",
                                            "Tovuz",
                                            "Baki",
                                            "Sumqayit",
                                            "Xaçmaz",
                                            "Şəki",
                                            "Yevlax"
                };

                for (int i = 0; i < links.Count; i++)
                {
                    textBoxUri.Text = links[i];
                    var doc = htmlWeb.Load(textBoxUri.Text);
                    //Thread.Sleep(5000);
                    HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//div[@class='clearfix _ikh']");
                    for (int j = 0; j < 1; j++)
                    {
                        string followers = results[j].SelectSingleNode("./div[@class='_4bl9']").InnerText;
                        kobim.Add(new Kobim()
                        {
                            Insta = followers
                        });
                        listBox1.Items.Add(followers);
                    }
                }


                //foreach (string link in links)
                //{

                //    textBoxUri.Text = link;
                //    var doc = htmlWeb.Load(textBoxUri.Text);
                //    //Thread.Sleep(5000);
                //    HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//div[@class='clearfix _ikh']");
                //    //< div class='clearfix _ikh'><div class="_4bl9">

                //    for (int i = 0; i < 1; i++)
                //    {
                //        string followers = results[i].SelectSingleNode("./div[@class='_4bl9']").InnerText.Remove(5);


                //        kobim.Add(new Kobim()
                //        {
                //            Insta = followers
                //        });
                //        listBox1.Items.Add(followers);
                //    }
                //}

                

                MessageBox.Show("Oldu");
            }
            catch (Exception)
            {

                return;
            }
        }

        private void InstagramWrite()
        {

            //string followers="";
            List<Kobim> kobim = new List<Kobim>();
            textBoxUri.Text = "https://www.instagram.com/kobimucar/";
            var doc = htmlWeb.Load(textBoxUri.Text);

            HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//div[@class='v9tJq AAaSh ']");
            Thread.Sleep(10000);
            // HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//a[@class='-nal3 CMY_Link CMY_Redirect CMY_Valid']");
            // HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//*[@id='react - root']/section/main/div/header/section/ul/li[2]/a[@class='-nal3 CMY_Link CMY_Redirect CMY_Valid']");
            //HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//div[@class='clearfix _ikh']");
            //< div class='clearfix _ikh'><div class="_4bl9">

            foreach (var result in results)
            {
                try
                {
                    //class="_4bl9"
                    // string followers = result.SelectSingleNode("./span[@class='g47SY']").InnerText;
                    string followers = result.SelectSingleNode("./div[@class='_4bl9']").InnerText;
                    kobim.Add(new Kobim()
                    {
                        Insta = followers
                    });
                    listBox1.Items.Add(followers);
                }
                catch (Exception)
                {

                    return;
                }

                MessageBox.Show("Oldu");


            }

        }
        private void YoutubeWrite()
        {
            try
            {
                List<Kobim> kobim = new List<Kobim>();
                textBoxUri.Text = "https://www.youtube.com/channel/UC0xi0ArP4R-MLmlxNnLD9yA"; //baki
                //textBoxUri.Text = "https://www.facebook.com/absheronkobim"; //abseron
                var doc = htmlWeb.Load(textBoxUri.Text);
                HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//*[@id='subscriber - count']");
                Thread.Sleep(5000);
                //HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//p[@class='style-scope ytd-c4-tabbed-header-renderer']");

                // HtmlNodeCollection results = doc.DocumentNode.SelectSingleNode("//yt - formatted - string[@id='subscriber-count']").InnerText;

                // < yt - formatted - string id = "subscriber-count" class="style-scope ytd-c4-tabbed-header-renderer" aria-label="7 abone">7 abone</yt-formatted-string>
                for (int i = 0; i < 1; i++)
                {
                    string followers = results[i].SelectSingleNode("./div[@class='_4bl9']").InnerText;
                    kobim.Add(new Kobim()
                    {
                        Insta = followers
                    });
                    listBox1.Items.Add(followers);
                }

                MessageBox.Show("Oldu");
            }
            catch (Exception)
            {

                return;
            }
        }
        public void LinkedInWrite()
        {
            try
            {
                List<Kobim> kobim = new List<Kobim>();
                textBoxUri.Text = "https://www.youtube.com/channel/UC0xi0ArP4R-MLmlxNnLD9yA"; //baki
                //textBoxUri.Text = "https://www.facebook.com/absheronkobim"; //abseron
                var doc = htmlWeb.Load(textBoxUri.Text);
                HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//*[@id='subscriber - count']");
                Thread.Sleep(5000);
                //HtmlNodeCollection results = doc.DocumentNode.SelectNodes("//p[@class='style-scope ytd-c4-tabbed-header-renderer']");

                // HtmlNodeCollection results = doc.DocumentNode.SelectSingleNode("//yt - formatted - string[@id='subscriber-count']").InnerText;

                // < yt - formatted - string id = "subscriber-count" class="style-scope ytd-c4-tabbed-header-renderer" aria-label="7 abone">7 abone</yt-formatted-string>
                for (int i = 0; i < 1; i++)
                {
                    string followers = results[i].SelectSingleNode("./div[@class='_4bl9']").InnerText;
                    kobim.Add(new Kobim()
                    {
                        Insta = followers
                    });
                    listBox1.Items.Add(followers);
                }

                MessageBox.Show("Oldu");
            }
            catch (Exception)
            {

                return;
            }
        }

    }
}
