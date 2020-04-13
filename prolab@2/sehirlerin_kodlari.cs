using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab_2
{


    public class sehirlerin_kodlari
    {
        private int kod;

        public sehirlerin_kodlari(string city)
        {
            switch (city)
            {
                case "adana":
                    kod = 0;
                    break;
                case "adıyaman":
                    kod = 1;
                    break;
                case "afonkarahisar":
                    kod = 2;
                    break;
                case "ağrı":
                    kod = 3;
                    break;
                case "amasya":
                    kod = 4;
                    break;
                case "ankara":
                    kod = 5;
                    break;
                case "antalya":
                    kod = 6;
                    break;
                case "artvin":
                    kod = 7;
                    break;
                case "aydın":
                    kod = 8;
                    break;
                case "balıkesir":
                    kod = 9;
                    break;
                case "bilecik":
                    kod = 10;
                    break;
                case "bingöl":
                    kod = 10;
                    break;
                case "bitlis":
                    kod = 12;
                    break;
                case "bolu":
                    kod = 13;
                    break;
                case "burdur":
                    kod = 14;
                    break;
                case "bursa":
                    kod = 15;
                    break;
                case "çanakkale":
                    kod = 16;
                    break;
                case "çankırı":
                    kod = 17;
                    break;
                case "çorum":
                    kod = 18;
                    break;
                case "denizli":
                    kod = 19;
                    break;
                case "diyarbakır":
                    kod = 20;
                    break;
                case "edirne":
                    kod = 21;
                    break;
                case "elazığ":
                    kod = 22;
                    break;
                case "erzincan":
                    kod = 23;
                    break;
                case "erzurum":
                    kod = 24;
                    break;
                case "eskişehir":
                    kod = 25;
                    break;
                case "gaziantep":
                    kod = 26;
                    break;
                case "giresun":
                    kod = 27;
                    break;
                case "gümüşhane":
                    kod = 28;
                    break;
                case "hakkari":
                    kod = 29;
                    break;
                case "hatay":
                    kod = 30;
                    break;
                case "ısparta":
                    kod = 31;
                    break;
                case "mersin":
                    kod = 32;
                    break;
                case "istanbul":
                    kod = 33;
                    break;
                case "izmir":
                    kod = 34;
                    break;
                case "kars":
                    kod = 35;
                    break;
                case "kastamanu":
                    kod = 36;
                    break;
                case "kayseri":
                    kod = 37;
                    break;
                case "kırklareli":
                    kod = 38;
                    break;
                case "kırşehir":
                    kod = 39;
                    break;
                case "kocaeli":
                    kod = 40;
                    break;
                case "konya":
                    kod = 41;
                    break;
                case "kütahya":
                    kod = 42;
                    break;
                case "malatya":
                    kod = 43;
                    break;
                case "manisa":
                    kod = 44;
                    break;
                case "kahramanmaraş":
                    kod = 45;
                    break;
                case "mardin":
                    kod = 46;
                    break;
                case "muğla":
                    kod = 47;
                    break;
                case "muş":
                    kod = 48;
                    break;
                case "nevşehir":
                    kod = 49;
                    break;
                case "niğde":
                    kod = 50;
                    break;
                case "ordu":
                    kod = 51;
                    break;
                case "rize":
                    kod = 52;
                    break;
                case "sakarya":
                    kod = 53;
                    break;
                case "samsun":
                    kod = 54;
                    break;
                case "siirt":
                    kod = 55;
                    break;
                case "sinop":
                    kod = 56;
                    break;
                case "sivas":
                    kod = 57;
                    break;
                case "tekirdağ":
                    kod = 58;
                    break;
                case "tokat":
                    kod = 59;
                    break;
                case "trabzon":
                    kod = 60;
                    break;
                case "tunceli":
                    kod = 61;
                    break;
                case "şanlıurfa":
                    kod = 62;
                    break;
                case "uşak":
                    kod = 63;
                    break;
                case "van":
                    kod = 64;
                    break;
                case "yozgat":
                    kod = 65;
                    break;
                case "zonguldak":
                    kod = 66;
                    break;
                case "aksaray":
                    kod = 67;
                    break;
                case "barbut":
                    kod = 68;
                    break;
                case "karaman":
                    kod = 69;
                    break;
                case "kırıkkale":
                    kod = 70;
                    break;
                case "batman":
                    kod = 71;
                    break;
                case "şırnak":
                    kod = 72;
                    break;
                case "bartın":
                    kod = 73;
                    break;
                case "ardahan":
                    kod = 74;
                    break;
                case "ığdır":
                    kod = 75;
                    break;
                case "yalova":
                    kod = 76;
                    break;
                case "karabük":
                    kod = 77;
                    break;
                case "kilis":
                    kod = 78;
                    break;
                case "osmaniye":
                    kod = 79;
                    break;
                case "düzce":
                    kod = 80;
                    break;
            }
        }
        public int plaka
        {
            get { return kod; }
            set { kod = value; }
        }
    }
}

 