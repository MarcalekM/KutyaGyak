using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaGyak
{
    internal class Kutya
    {
        public DateTime ChipDatum { get; private set; }
        public Fajta Fajta { get; private set; }
        public Gazda Gazda { get; private set; }
        public int Id { get; private set; }
        public bool Kan { get; private set; }
        public string KepUrl { get; private set; }
        public int Kor { get; private set; }
        public string Nev { get; private set; }

        static public List<Kutya> ListaFeltoltes(string forras)
        {
            List<Kutya> kutyaLista = new();
            string path = $@"../../../src/{forras}";
            using StreamReader sr = new(
                path: path,
                encoding: UTF8Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                
            }
            return kutyaLista;
        }

        public Kutya(int id, string nev, bool kan, int kor, DateTime chipDatum, string kepUrl, Fajta fajta, Gazda gazda)
        {
            Id = id;
            Nev = nev;
            Kan = kan;
            Kor = kor;
            ChipDatum = chipDatum;
            KepUrl = kepUrl;
            Fajta = fajta;
            Gazda = gazda;
        }
    }
}
