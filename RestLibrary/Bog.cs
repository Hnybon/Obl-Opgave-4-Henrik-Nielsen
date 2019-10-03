using System;

namespace RestLibrary
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;

        public Bog()
        {
            
        }

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {
            _titel = titel;
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;
        }

        public override string ToString()
        {
            return $"{nameof(Titel)}: {Titel}, {nameof(Forfatter)}: {Forfatter}, {nameof(Sidetal)}: {Sidetal}, {nameof(Isbn13)}: {Isbn13}";
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public string Forfatter
        {
            get { return _forfatter; }
            set { _forfatter = value; }
        }

        public int Sidetal
        {
            get { return _sidetal; }
            set { _sidetal = value; }
        }

        public string Isbn13
        {
            get { return _isbn13; }
            set { _isbn13 = value; }
        }
    }
}
