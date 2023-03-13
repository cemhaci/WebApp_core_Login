using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewFakeData
{
    public class database
    {
        public  List<Musteri> musteriler = new List<Musteri>();

        public List<Musteri> musteriListele()
        {
            for (int i = 1; i < 500; i++)
            {
                Musteri m = new Musteri();
                m.Id = i;
                m.isim = FakeData.NameData.GetFirstName();
                m.soyisim = FakeData.NameData.GetSurname();
                m.emailAdres = FakeData.NetworkData.GetEmail();
                m.telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                m.il = FakeData.PlaceData.GetCity();
                m.ilce = FakeData.PlaceData.GetCounty();
                m.adres = FakeData.PlaceData.GetAddress();

                musteriler.Add(m);
            }

            return musteriler;
        }
    }
}
