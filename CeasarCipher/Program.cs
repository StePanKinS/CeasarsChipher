using CeasarCipher;

EncriptingSettings settings = new EncriptingSettings(4, Languages.Russian, includeSpaces: true);

string encripted = Encripting.Encript("ББбБбБбРРРРРрРруХ ыоравлсфстджыфдиж", settings);
Console.WriteLine(encripted);

Console.WriteLine();
Console.WriteLine(Encripting.Decript(encripted, settings));
