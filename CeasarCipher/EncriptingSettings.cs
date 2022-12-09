namespace CeasarCipher
{
    public class EncriptingSettings
    {
        public EncriptingSettings(int shift, Languages language, bool includeSpaces = false, bool includeEnter = false, bool includeSpecialsSymbols = false)
        {
            this.shift = shift;
            this.includeEnter = includeEnter;
            this.includeSpecialsSymbols = includeSpecialsSymbols;
            this.languages = new Languages[] { language};
            this.alphabet = string.Empty;


            switch (language)
            {
                case Languages.English:
                    {
                        alphabet += "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ";

                        break;
                    }
                case Languages.Russian:
                    {
                        alphabet += "аАбБвВгГдДеЕёЁжЖзЗиИйЙкКлЛмМнНоОпПрРсСтТуУфФхХцЦчЧшШщЩъЪыЫьЬэЭюЮяЯ";

                        break;
                    }
            }

            if (includeSpaces)
            {
                alphabet += ' ';
            }
            if (includeEnter)
            {
                alphabet += '\n';
            }
            if (includeSpecialsSymbols)
            {
                alphabet += "1234567890:;<=>?!#$%^*()-+@[\\]^_`{|}~.,/№\"'";
            }
        }

        public EncriptingSettings(int shift, Languages[] languages, bool includeSpaces = false, bool includeEnter = false, bool includeSpecialsSymbols = false)
        {
            this.shift = shift;
            this.includeEnter = includeEnter;

            this.includeSpecialsSymbols = includeSpecialsSymbols;
            this.languages = languages;
            this.alphabet = string.Empty;

            foreach(Languages language in languages)
            {
                switch (language)
                {
                    case Languages.English:
                        {
                            alphabet += "abcdefghijklmnopqrstuvwxyz";
                            alphabet += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                            break;
                        }
                    case Languages.Russian:
                        {
                            alphabet += "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                            alphabet += "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

                            break;
                        }
                }
            }

            if (includeSpaces)
            {
                alphabet += ' ';
            }
            if (includeEnter)
            {
                alphabet += '\n';
            }
            if (includeSpecialsSymbols)
            {
                alphabet += "1234567890:;<=>?!#$%^*()-+@[\\]^_`{|}~.,/№\"'";
            }
        }

        public int shift { get; set; }

        public bool includeEnter { get; set; }
        public bool includeSpecialsSymbols { get; set; }
        public Languages[] languages { get; set; }
        public string alphabet { get; set; }
    }
    public enum Languages
    {
        English,
        Russian,
    }
}
