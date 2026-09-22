using System.Text.RegularExpressions;

static bool ValidarSenhaRegex(string senha)
{
    if (string.IsNullOrEmpty(senha)) return false;

    // Explicação do padrão:
    // (?=.*[a-zA-Z]) -> Pelo menos uma letra (maiúscula ou minúscula)
    // (?=.*\d)       -> Pelo menos um dígito (0-9)
    // (?=.*[@#&])    -> Pelo menos um dos caracteres especiais: @, # ou &
    // .{8,}          -> No mínimo 8 caracteres no total
    string padrao = @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[@#&]).{8,}$";

    return Regex.IsMatch(senha, padrao);
}

bool ehValido = ValidarSenhaRegex("amrca154682");

if (ehValido)
{
    Console.WriteLine("VALIDA");
}else
{
    Console.WriteLine("INVALIDA");
}
