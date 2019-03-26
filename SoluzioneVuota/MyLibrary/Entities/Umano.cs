using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Entities
{
    public class Bambino: Umano
    {
        string _nome;
        //public string GetNome()
        //{
        //    return _nome;
        //}
        //public void SetNome(string nome)
        //{
        //    _nome = nome;
        //}

        //public string Nome {
        //    get
        //    {
        //        _nome = _nome.ToUpper();
        //        return _nome;
        //    }
        //    set
        //    {
        //        string tmp = value;
        //        _nome = tmp.ToLower();
        //    }
        //}

        void CalcolaCF()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    for (int k = 0; k < 30; k++)
                    {

                    }
                }
            }
        }
    }

    public class Umano
    {
        //campi privati
        bool _maschio;
        string _nome;
        public string Nome { get { return _nome; } }

        //property pubbliche
        int MioCampo { get; set; }
        public bool HoDigerito { get; set; }
        List<Cibo> _ciboIngerito = new List<Cibo>() {
            new Cibo(),
            new Cibo(),
        };
        
        //costruttore
        public Umano() : this(true)
        {
            //BOH
            int[] arrayInt = new int[0];
            List<int> listInt = new List<int>();

            List<Umano> listMaschi = new List<Umano>();

            List<Umano> listFemmine = new List<Umano>();

            List<Umano> listUmani = listMaschi.Union(listFemmine).ToList();
            //List<Umano> listUmani = new List<Umano>(listMaschi);
            //listUmani.AddRange(listFemmine);

            List<Umano> listaCosi = listUmani.FindAll(x => x.Nome == "coso");

            List<Umano> listaCosi2 = FindAll(listUmani, "coso");


            


        }

        public List<Umano> FindAll()
        {



            return new List<Umano>();
        }

        public List<Umano> FindAll(List<Umano> listaUmani, string nome)
        {
            List<Umano> listaCosi2 = new List<Umano>();
            for (int i = 0; i < listaUmani.Count; i++)
            {
                Umano u = listaUmani[i];
                if (u.Nome == nome)
                {
                    listaCosi2.Add(u);
                }
            }

            foreach (Umano uomo in listaUmani)
            {
                if (uomo.Nome == nome)
                {
                    listaCosi2.Add(uomo);
                }
            }
            return listaCosi2;
        }


        public bool Indigestione(bool v)
        {
            Cibo panino = _ciboIngerito.First(/*x => x.Nome == "Panino"*/);

            for (int i = 0; i < _ciboIngerito.Count; i++)
            {
                if (i == 1) return true;
                Digerisci();
            }
            
            return false;
        }

        public Umano(bool maschio)
        {
            _maschio = maschio;
        }

        public Umano(bool maschio, string nome) : this(maschio)
        {
            _nome = nome;
        }


        public void Mangia()
        {
            Mangia(new List<Cibo>());
        }
        //metodi
        public void Mangia(List<Cibo> cosaMangio)
        {
            _ciboIngerito = cosaMangio;
            ///Faccio qualcosa
            Ingoia();
            Deglutisci();
            Digerisci();
        }

        public void Mangia(List<Cibo> cosaMangio, int quantoMangio)
        {
            for (int i = 0; i < quantoMangio; i++)
            {
                Mangia(cosaMangio);
            }
        }
        
        public void Mangia10(List<Cibo> cibo)
        {
            Mangia(cibo, 10);
        }

        private void Digerisci()
        {
            //Digerisco il cibo
        }

        private void Deglutisci()
        {
            //Deglutisci
            foreach (var bolo in _ciboIngerito)
            {
                //bolo
            }







        }

        private void Ingoia()
        {

        }

        public void FaiCacca()
        {
            throw new NotImplementedException();
        }
    }
}
