DevizaBankszamla bankszamla = new DevizaBankszamla
{
    Id = 1,
    Tulajdonos = new Tulajdonos
    {
        Id = 1,
        TulajdonosNeve = "Daniel",
        Lakcim = new Lakcim
        {
            Id = 1,
            Orszag = "Magyarorszag",
            Iranyitoszam = 6758,
            TelepulesNeve = "Roszke",
            KozteruletNeve = "Csillag utca",
            Hazszam = 85
        }
    },
    Szamlaszam = "1235236-1235522",
    Egyenleg = 687432,
    DevizaTipus = Deviza.euro
};

Console.WriteLine($"Egyenleg: {bankszamla.EgyenlegLekerese()} {bankszamla.DevizaTipus}");

bankszamla.Fizetes();

Console.WriteLine($"Egyenleg: {bankszamla.EgyenlegLekerese()} {bankszamla.DevizaTipus}");
