using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyunum
{
    internal class Mayin_tarlasi
    {
        Size buyukluk_;
        List<Mayin> mayinlar;
        int dolu_mayin_sayisi;
        Random rdm = new Random();
        
        public Mayin_tarlasi(Size buyukluk, int mayin_sayisi)
        {
            mayinlar = new List<Mayin>();
            dolu_mayin_sayisi = mayin_sayisi;
            buyukluk_ = buyukluk;
            for (int x = 0; x < buyukluk.Width; x = x + 20)
            {
                for (int y = 0; y < buyukluk.Height; y = y + 20)
                {
                    Mayin b = new Mayin(new Point(x, y));
                    add_bomb(b);
                }
            }
            mayinlari_doldur();
            this.dolu_mayin_sayisi = dolu_mayin_sayisi;
        }
        public void add_bomb(Mayin b)
        {
            mayinlar.Add(b);
        }
        public void mayinlari_doldur()
        {
            int sayi = 0;
            while (sayi < dolu_mayin_sayisi)
            {
                int i =rdm.Next(0,mayinlar.Count);
                Mayin item= mayinlar[i];
                if (item.istherebomb == false)
                {
                    item.istherebomb = true;
                    sayi++;
                }
            }
        }
        public Size buyuklugu
        {
            get { return buyukluk_; }
        }
        public void mayin_ekle()
        {

        }
        public Mayin mayin_al_loc(Point location) { 
            foreach (Mayin item in mayinlar)
            {
                if (item.get_Bomblocation == location)
                {
                    return item;
                }
            }
            return null;
        }
        public List <Mayin> getallbomb
        {
            get
            {
                return mayinlar;
            }
        }
    }
}
