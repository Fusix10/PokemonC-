using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleApp1;


public class RoundManager
{
    List<Pokemon> EquipeJoueur;
    List<Pokemon> EquipeEnemy;
    public List<Pokemon> EquipeJoueur1 { get => EquipeJoueur;}
    public List<Pokemon> EquipeEnemy1 { get => EquipeEnemy;}
    public RoundManager()
    {
        EquipeJoueur = new List<Pokemon>();
        EquipeEnemy = new List<Pokemon>();
        for(int i = 0; i < Engine.instance.Player.Inventory.InvActuel1.Count(); i++)
        {
            Engine.instance.Player.Inventory.InvActuel1[i].DrawPokemon(Engine.instance.Window1);
            Engine.instance.Window1.Windowfigth1[Engine.instance.Player.Inventory.InvActuel1[i].P.X][Engine.instance.Player.Inventory.InvActuel1[i].P.Y].Pok = Engine.instance.Player.Inventory.InvActuel1[i];
        }
        AddPok(Engine.instance.Player.Inventory.InvActuel1,1);
    }
    public void AddPok(Pokemon ActuelPok, int Who)
    {
        if(Who == 1)
            EquipeJoueur.Add(ActuelPok);
        else if(Who == 2)
            EquipeEnemy.Add(ActuelPok);
    }
    public void AddPok(List<Pokemon> ActuelPok, int Who)
    {
        if (Who == 1)
        {
            foreach (Pokemon Pokemon in ActuelPok)
            {
                EquipeJoueur.Add(Pokemon);
            }
        }   
        else if (Who == 2)
        {
            foreach (Pokemon Pokemon in ActuelPok)
            {
                EquipeEnemy.Add(Pokemon);
            }
        }
    }
    public void Update()
    {
        if (Engine.instance.InputManager.Ivalue == 10)
        {
            Engine.instance.Ingame = false;
        }
        else if (Engine.instance.InputManager.Ivalue == 1)
        {
            if (Engine.instance.Window1.Elcursor1.Y > 0)
            {
                --Engine.instance.Window1.Elcursor1.Y;
                Engine.instance.Window1.DrawWindowFigth();
                DrawListPok();
            }
        }
        else if (Engine.instance.InputManager.Ivalue == 2)
        {
            if (Engine.instance.Window1.Elcursor1.Y < Engine.instance.Window1.Windowfigth1[0].Count() - 1)
            {
                ++Engine.instance.Window1.Elcursor1.Y;
                Engine.instance.Window1.DrawWindowFigth();
                DrawListPok();

            }
        }
        else if (Engine.instance.InputManager.Ivalue == 3)
        {
            if (Engine.instance.Window1.Elcursor1.X > 0)
            {
                --Engine.instance.Window1.Elcursor1.X;
                Engine.instance.Window1.DrawWindowFigth();
                DrawListPok();

            }
        }
        else if (Engine.instance.InputManager.Ivalue == 4)
        {
            if (Engine.instance.Window1.Elcursor1.X < Engine.instance.Window1.Windowfigth1.Count() - 1)
            {
                ++Engine.instance.Window1.Elcursor1.X;
                Engine.instance.Window1.DrawWindowFigth();
                DrawListPok();

            }
        }
        for (int i = 0; i < EquipeJoueur.Count(); i++)
        {
            if (Engine.instance.InputManager.Ivalue == 5 && Engine.instance.Window1.Elcursor1.X == EquipeJoueur[i].P.X && Engine.instance.Window1.Elcursor1.Y == EquipeJoueur[i].P.Y && EquipeJoueur[i].P.View1 == false)
            {
                ViewMovePok2(Engine.instance.Window1.Elcursor1.X, Engine.instance.Window1.Elcursor1.Y, true);
                ViewMovePok(Engine.instance.Window1.Elcursor1.X, Engine.instance.Window1.Elcursor1.Y);
            }
            else if (Engine.instance.InputManager.Ivalue == 5 && Engine.instance.Window1.Elcursor1.X == EquipeJoueur[i].P.X && Engine.instance.Window1.Elcursor1.Y == EquipeJoueur[i].P.Y && EquipeJoueur[i].P.View1 == true)
            {
                ViewMovePok2(Engine.instance.Window1.Elcursor1.X, Engine.instance.Window1.Elcursor1.Y, false);
                Engine.instance.Window1.DrawWindowFigth();
                EquipeJoueur[i].DrawPokemon(Engine.instance.Window1);
            }
            else if (Engine.instance.InputManager.Ivalue == 5 && EquipeJoueur[i].P.View1 == true)
            {

                if (VerifXYtoCursor(EquipeJoueur[i],0) == true)
                {
                    Engine.instance.Window1.Windowfigth1[EquipeJoueur[i].P.X][EquipeJoueur[i].P.Y].Pok = EquipeJoueur[i];
                    Engine.instance.Window1.DrawWindowFigth();
                    EquipeJoueur[i].DrawPokemon(Engine.instance.Window1);
                    ViewMovePok2(Engine.instance.Window1.Elcursor1.X, Engine.instance.Window1.Elcursor1.Y, false);
                    EquipeJoueur[i].ViewMoveResult1.Clear();
                    EquipeJoueur[i].ViewAttackResult.Clear();
                    break;
                }
                if (VerifXYtoCursor(EquipeJoueur[i], 1) == true)
                {
                    Engine.instance.Window1.Windowfigth1[Engine.instance.Window1.Elcursor1.X][Engine.instance.Window1.Elcursor1.Y].Pok.TakeDommage(EquipeJoueur[i].Dmg);
                    ViewMovePok2(EquipeJoueur[i].P.X, EquipeJoueur[i].P.Y, false);
                    Console.WriteLine("dans ta poire");
                    EquipeJoueur[i].ViewMoveResult1.Clear();
                    break;
                }  
            }
            if (EquipeJoueur[i].P.View1 == true)
            {
                ViewMovePok(Engine.instance.Window1.Elcursor1.X, Engine.instance.Window1.Elcursor1.Y);
            }
        }
        

    }
    private void DrawListPok()
    {
        for (int i = 0; i < EquipeJoueur.Count(); i++)
        {
            EquipeJoueur[i].DrawPokemon(Engine.instance.Window1);
        }
    }
    private void ViewMovePok(int x, int y)
    {
        foreach(Pokemon P in EquipeJoueur) 
        {

            if (P.P.View1 == true)
            {
                P.ViewMove(Engine.instance.Window1, P.Mouvement, 0);
                P.ViewMove(Engine.instance.Window1, P.RangeAttack, 1);
            }
            
        }
    }
    private void ViewMovePok2(int x, int y, bool t)
    {
        foreach (Pokemon P in EquipeJoueur)
        {
            if (P.P.X == x && P.P.Y == y)
            {
                P.P.View1 = t;
            }
        }
    }

    private bool VerifXYtoCursor(Pokemon pok, int Who)
    {
        if(Who == 0)
        {
            for (int i = 0; i < pok.ViewMoveResult1.Count(); i++)
            {
                if (Engine.instance.Window1.Elcursor1.X == pok.ViewMoveResult1[i][0] && Engine.instance.Window1.Elcursor1.Y == pok.ViewMoveResult1[i][1])
                {
                    Engine.instance.Window1.Windowfigth1[pok.P.X][pok.P.Y].Pok = null;
                    pok.P.X = pok.ViewMoveResult1[i][0];
                    pok.P.Y = pok.ViewMoveResult1[i][1];
                    return true;
                }
            }
            return false;
        }
        else
        {
            for (int i = 0; i < pok.ViewAttackResult.Count(); i++)
            {
                if (Engine.instance.Window1.Elcursor1.X == pok.ViewAttackResult[i][0] && Engine.instance.Window1.Elcursor1.Y == pok.ViewAttackResult[i][1])
                {

                    return true;
                }
            }
            return false;
        }

    }

}

