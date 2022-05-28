using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDyplomowa
{
    public class Component
    {
        public string nazwa;
        public string specyfikacje;
        public string producent;
        public Image zdjecie;

        public Component(string nazwa, string specyfikacje, string producent, Image zdjecie)
        {
            this.nazwa = nazwa;
            this.specyfikacje = specyfikacje;
            this.producent = producent;
            this.zdjecie = zdjecie;
        }

        public Component(string nazwa, string specyfikacje, string producent)
        {
            this.nazwa = nazwa;
            this.specyfikacje = specyfikacje;
            this.producent = producent;
            this.zdjecie = null;
        }


        override
        public string ToString()
        {
            return this.nazwa;
        }

        public string GetInfo()
        {
            string info = ""+ this.nazwa+";"+ this.specyfikacje + ";" + this.producent;
            return info;
        }

    }
}
