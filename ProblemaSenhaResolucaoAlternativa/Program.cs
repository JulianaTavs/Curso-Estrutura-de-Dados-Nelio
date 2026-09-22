static bool ValidatePassword(string str)
{
    bool contemLetra = str.Any(char.IsLetter);
    bool contemDigito = str.Any(char.IsDigit);
    bool temOitoCaracteresOuMais = str.Length >= 8;
    bool temCaractereEspecial = str.AsSpan().ContainsAny("@#&");

        if (temOitoCaracteresOuMais && contemLetra && temCaractereEspecial && contemDigito)
        {
            return true;
        }

        return false;
}

if (ValidatePassword("amrca154682"))
{
    Console.WriteLine("VALIDA");
}
else
{
    Console.WriteLine("INVALIDA");
}

