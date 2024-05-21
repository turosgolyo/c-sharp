MilleniumFalcon milleniumFalcon = new MilleniumFalcon
{
    Name = "Millenium Falcon",
    Captain = new Captain
    {
        CaptainName = "1",
        Rank = Rank.Admiral
    },
    Shield = 50
};
Enterprise enterprise = new Enterprise
{
    Name = "Enterprise",
    Captain = new Captain
    {
        CaptainName = "2",
        Rank = Rank.Captain
    },
    Shield = 75
};
Rocinante rocinante = new Rocinante
{
    Name = "Rocinante",
    Captain = new Captain
    {
        CaptainName = "3",
        Rank = Rank.Major
    },
    Shield = 80
};
milleniumFalcon.JumpToHyperSpeed();
milleniumFalcon.Attack(rocinante);

rocinante.Selfdistruct();
