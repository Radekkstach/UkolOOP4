using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //    Vytvořte třídu NakladniAuto, která bude obsahovat:
    //Soukromý atribut spz
    //Soukromý atribut nosnost(v tunách),
    //Vlastnost Hmotnost nákladu(v tunách) – pouze pro čtení inicializovaný na 0
    //Třída bude obsahovat jediný konstruktor
    //Nastaví spz a nosnost na požadované hodnoty
    //Třída bude obsahovat metody:
    //NalozNaklad – která naloží požadovaný náklad a nedovolí přesáhnout nosnost.
    //Pokud při naložení celého nákladu je překročena nosnost, metoda umožní naložit
    //náklad částečně, do výše nosnosti a navíc vypíše zprávu, kolik tun nákladu nebylo
    //naloženo.
    //VylozNaklad – vyloží požadovanou hmotnost nákladu a nedovolí vyložit více, než
    //je naloženo.Pokud je požadováno více, metoda vyloží veškerý náklad a vypíše,
    //kolik tun požadovaného písku chybí.
    //Přepsanou metodu ToString – vrátí text ve tvaru „Nákladní auto ABC123 má
    //nosnost 3 t a má naloženo 1,5 t “.
    internal class NakladniAuto
    {
        protected string spz;
        protected int nosnost;
        protected int hmotnostnakladu = 0;


        public int HmotnostNakladu
        {
            get { return hmotnostnakladu; }
        }

        public NakladniAuto(string spz, int nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;

        }

        public void NalozNaklad(int hmotnost)
        {
            if (hmotnost > nosnost )
            {
                hmotnostnakladu = hmotnost - (hmotnost - nosnost);
                MessageBox.Show("Naklad nebyl nalozen o " + (hmotnost - nosnost));
            }
            else
            {
                if (hmotnostnakladu >= nosnost){ } 
                else
                {
                    hmotnostnakladu = hmotnostnakladu + hmotnost;
                    if(hmotnostnakladu > nosnost)
                    {
                        hmotnostnakladu = nosnost;
                    }
                }
            }
        }

        public void VylozitNaklad(int hmotnost)
        {
            if (hmotnost > hmotnostnakladu)
            {
                MessageBox.Show("Brzdi, brzdi, zas tolik tam nemas.\n Chybi: " + (hmotnost - hmotnostnakladu));
                hmotnostnakladu = 0;
            }
            else
            {
                hmotnostnakladu = hmotnostnakladu - hmotnost;
            }
        }

        public override string ToString()
        {
            return "Nakladni auto " + spz + " ma nosnost " + nosnost + "tun a ma nalozeno " + hmotnostnakladu + "tun";
        }
    }
}
