using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Concrete;


namespace KobimStatistika.Forms
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
            var doc= htmlWeb.Load(textBoxUri.Text);
            Kobim kobim = new Kobim(); 
           
        }
    }
}
