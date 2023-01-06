using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : Chessman
{
    public AudioSource AS;
    public AudioClip AC;
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];
        Chessman c;

        if (isWhite)
        {
            //One Get
            if (CurrentY != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX, CurrentY + 1];
                if (c == null)
                    r[CurrentX, CurrentY + 1] = true;
            }

            //Geri Don
            if (CurrentY != 0)
            {
                c = BoardManager.Instance.Chessmans[CurrentX, CurrentY - 1];
                if (c == null)
                    r[CurrentX, CurrentY - 1] = true;
            }

            //One Sag
            if (CurrentY != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX + 1, CurrentY + 1];
                if (c == null)
                    r[CurrentX + 1, CurrentY + 1] = true;
            }

            //One sol
            if (CurrentY != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX - 1, CurrentY + 1];
                if (c == null)
                    r[CurrentX - 1, CurrentY + 1] = true;
            }

            //Geriye Sag
            if (CurrentY != 0)
            {
                c = BoardManager.Instance.Chessmans[CurrentX + 1, CurrentY - 1];
                if (c == null)
                    r[CurrentX + 1, CurrentY - 1] = true;
            }

            //Geriye sol
            if (CurrentY != 0)
            {
                c = BoardManager.Instance.Chessmans[CurrentX - 1, CurrentY - 1];
                if (c == null)
                    r[CurrentX - 1, CurrentY - 1] = true;
            }

            //Saga Get
            if (CurrentX != 0)
            {
                c = BoardManager.Instance.Chessmans[CurrentX + 1, CurrentY];
                if (c == null)
                    r[CurrentX + 1, CurrentY] = true;
            }

            //Sola Get
            if (CurrentX != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX - 1, CurrentY];
                if (c == null)
                    r[CurrentX - 1, CurrentY] = true;
            }
        }

        else
        {
            //One Get
            if (CurrentY != 0)
            {
                c = BoardManager.Instance.Chessmans[CurrentX, CurrentY - 1];
                if (c == null)
                    r[CurrentX, CurrentY - 1] = true;
            }

            //geri done
            if (CurrentY != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX, CurrentY + 1];
                if (c == null)
                    r[CurrentX, CurrentY + 1] = true;
            }

            //One Sag
            if (CurrentY != 0)
            {
                c = BoardManager.Instance.Chessmans[CurrentX + 1, CurrentY - 1];
                if (c == null)
                    r[CurrentX + 1, CurrentY - 1] = true;
            }

            //One sol
            if (CurrentY != 0)
            {
                c = BoardManager.Instance.Chessmans[CurrentX - 1, CurrentY - 1];
                if (c == null)
                    r[CurrentX - 1, CurrentY - 1] = true;
            }

            //Geriye Sag
            if (CurrentY != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX + 1, CurrentY + 1];
                if (c == null)
                    r[CurrentX + 1, CurrentY + 1] = true;
            }

            //Geriye sol
            if (CurrentY != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX - 1, CurrentY + 1];
                if (c == null)
                    r[CurrentX - 1, CurrentY + 1] = true;
            }

            //Saga Get
            if (CurrentX != 0)
            {
                c = BoardManager.Instance.Chessmans[CurrentX + 1, CurrentY];
                if (c == null)
                    r[CurrentX + 1, CurrentY] = true;
            }

            //Sola Get
            if (CurrentX != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX - 1, CurrentY];
                if (c == null)
                    r[CurrentX - 1, CurrentY] = true;
            }
        }
        AS.PlayOneShot(AC);
        return r;
    }
}
