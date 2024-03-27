using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using static System.Formats.Asn1.AsnWriter;
using static IMove;

public class Ratio : Pokemon, IMove
{

    public Ratio(int Where) : base(Where)
    {
        Icone = "=/=(|   |)=/=|o|-|o|=/=*--b--*=/=|_____|";
        ELMouvement1 = new List<MoveP>();
        ELMouvement1.Clear();
        ELMouvement1.Add(IMove.MoveP.Up);
        ELMouvement1.Add(IMove.MoveP.Up);
        Mouvement.Add(ELMouvement1);
        ELMouvement1 = new List<MoveP>();
        ELMouvement1.Clear();
        ELMouvement1.Add(IMove.MoveP.Down);
        ELMouvement1.Add(IMove.MoveP.Down);
        Mouvement.Add(ELMouvement1);
        ELMouvement1 = new List<MoveP>();
        ELMouvement1.Clear();
        ELMouvement1.Add(IMove.MoveP.Left);
        ELMouvement1.Add(IMove.MoveP.Left);
        Mouvement.Add(ELMouvement1);
        ELMouvement1 = new List<MoveP>();
        ELMouvement1.Clear();
        ELMouvement1.Add(IMove.MoveP.Right);
        ELMouvement1.Add(IMove.MoveP.Right);
        Mouvement.Add(ELMouvement1);
        for (int i = 0; i < 8; i++)
        {
            ElRangeAttack = new List<MoveP>();
            ElRangeAttack.Clear();
            ElRangeAttack.Add(IMove.MoveP.Left);
            ElRangeAttack.Add(IMove.MoveP.Up);
        }
    }
    public override void Attacks()
    {

    }
}

