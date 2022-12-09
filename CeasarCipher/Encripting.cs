namespace CeasarCipher
{
    public static class Encripting
    {
        /// <summary>
        /// Encripts given string with given parametrs
        /// </summary>
        /// <param name="text">String to encript</param>
        /// <param name="shift">Move length</param>
        /// <param name="languages">What languages encriptin g string contains</param>
        /// <param name="includeSpaces">To not ignore spaces</param>
        /// <param name="includeEnter">To not ignore enters</param>
        /// <param name="includeSpecialsSymbols">To not ignore special symbols</param>
        /// <returns>Encripted string</returns>
        public static string Encript(string text, int shift, Languages[] languages, bool includeSpaces = false, bool includeEnter = false, bool includeSpecialsSymbols = false)
        {
            EncriptingSettings settings = new EncriptingSettings(shift, languages, includeSpaces, includeEnter, includeSpecialsSymbols);
            return Encript(text, settings);
        }

        /// <summary>
        /// Encripts given string with given parametrs
        /// </summary>
        /// <param name="text">String to encript</param>
        /// <param name="alphabet">Alpabet</param>
        /// <param name="shift">Move length</param>
        /// <returns>Encripted string</returns>
        public static string Encript(string text, string alphabet, int shift)
        {
            return move(text, alphabet, shift);
        }

        /// <summary>
        /// Encripts given string with given parametrs
        /// </summary>
        /// <param name="text">String to encript</param>
        /// <param name="settings">Parametrs to ecript with</param>
        /// <returns>Encripted string</returns>
        public static string Encript(string text, EncriptingSettings settings)
        {
            return move(text, settings.alphabet, settings.shift);
        }

        /// <summary>
        /// Decrips given text
        /// </summary>
        /// <param name="encriptedText">Encripted text</param>
        /// <param name="encriptingShift">Encripting shift</param>
        /// <param name="languages">Encripting languages</param>
        /// <param name="includeSpaces">Includes spaces</param>
        /// <param name="includeEnter">Includes enters</param>
        /// <param name="includeSpecialsSymbols">Includes special symbols</param>
        /// <returns>Decripted text</returns>
        public static string Decript(string encriptedText, int encriptingShift, Languages[] languages, bool includeSpaces = false, bool includeEnter = false, bool includeSpecialsSymbols = false)
        {
            EncriptingSettings settings = new EncriptingSettings(encriptingShift, languages, includeSpaces, includeEnter);
            return Decript(encriptedText, settings);
        }

        /// <summary>
        /// Decrips given text
        /// </summary>
        /// <param name="encriptedText">Encripted text</param>
        /// <param name="alphabet">Encripting alphabet</param>
        /// <param name="encriptingShift">Encripting shift</param>
        /// <returns>Decripted text</returns>
        public static string Decript(string encriptedText, string alphabet, int encriptingShift)
        {
            return move(encriptedText, alphabet, encriptingShift * -1);
        }

        /// <summary>
        /// Decrips given text
        /// </summary>
        /// <param name="encriptedText">Encripted text</param>
        /// <param name="encriptingSettings">Encripting settings</param>
        /// <returns>Decripted text</returns>
        public static string Decript(string encriptedText, EncriptingSettings encriptingSettings)
        {
            return move(encriptedText, encriptingSettings.alphabet, encriptingSettings.shift * -1);
        }



        private static string move(string text, string alphabet, int shift)
        {
            while(shift < 0)
            {
                shift = alphabet.Length + shift;
            }

            string answer = string.Empty;
            for(int i = 0; i < text.Length; i++)
            {
                int index = -1;
                for(int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == text[i])
                    {
                        index = j;
                        break;
                    }
                }
                if(index == -1)
                {
                    continue;
                }

                int newSymbol = (index + shift) % alphabet.Length;
                answer += alphabet[newSymbol];
            }

            return answer;
        }
    }
}
