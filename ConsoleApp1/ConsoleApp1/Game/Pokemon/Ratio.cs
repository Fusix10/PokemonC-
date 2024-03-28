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

    public Ratio(int Where, int x, int y) : base(Where, x ,y)
    {
        
 



        Icone = "=/=(|     |)=/= |_____|=/=|[]   []|=/=| * T  *|=/=| _____ |";
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

        /*===================================*/

        //Gauche droite
        ElRangeAttack = new List<MoveP>();
        ElRangeAttack.Clear();
        ElRangeAttack.Add(IMove.MoveP.Left);
        ElRangeAttack.Add(IMove.MoveP.Up);
        RangeAttack.Add(ElRangeAttack);

        ElRangeAttack = new List<MoveP>();
        ElRangeAttack.Clear();
        ElRangeAttack.Add(IMove.MoveP.Left);
        ElRangeAttack.Add(IMove.MoveP.Left);
        ElRangeAttack.Add(IMove.MoveP.Up);
        ElRangeAttack.Add(IMove.MoveP.Up);
        RangeAttack.Add(ElRangeAttack);

        //droit haut
        ElRangeAttack = new List<MoveP>();
        ElRangeAttack.Clear();
        ElRangeAttack.Add(IMove.MoveP.Right);
        ElRangeAttack.Add(IMove.MoveP.Up);
        RangeAttack.Add(ElRangeAttack);

        ElRangeAttack = new List<MoveP>();
        ElRangeAttack.Clear();
        ElRangeAttack.Add(IMove.MoveP.Right);
        ElRangeAttack.Add(IMove.MoveP.Right);
        ElRangeAttack.Add(IMove.MoveP.Up);
        ElRangeAttack.Add(IMove.MoveP.Up);
        RangeAttack.Add(ElRangeAttack);

        //Gauche bas
        ElRangeAttack = new List<MoveP>();
        ElRangeAttack.Clear();
        ElRangeAttack.Add(IMove.MoveP.Left);
        ElRangeAttack.Add(IMove.MoveP.Down);
        RangeAttack.Add(ElRangeAttack);

        ElRangeAttack = new List<MoveP>();
        ElRangeAttack.Clear();
        ElRangeAttack.Add(IMove.MoveP.Left);
        ElRangeAttack.Add(IMove.MoveP.Left);
        ElRangeAttack.Add(IMove.MoveP.Down);
        ElRangeAttack.Add(IMove.MoveP.Down);
        RangeAttack.Add(ElRangeAttack);

        //Droit bas
        ElRangeAttack = new List<MoveP>();
        ElRangeAttack.Clear();
        ElRangeAttack.Add(IMove.MoveP.Right);
        ElRangeAttack.Add(IMove.MoveP.Down);
        RangeAttack.Add(ElRangeAttack);

        ElRangeAttack = new List<MoveP>();
        ElRangeAttack.Clear();
        ElRangeAttack.Add(IMove.MoveP.Right);
        ElRangeAttack.Add(IMove.MoveP.Right);
        ElRangeAttack.Add(IMove.MoveP.Down);
        ElRangeAttack.Add(IMove.MoveP.Down);
        RangeAttack.Add(ElRangeAttack);

        _pv = 10;
        _dmg = 2;
    }
    public override void Attacks()
    {

    }
}

