using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public TextChanger textChange;

    public int hp = 1000;
    private int dmg = 50;

    void TakeDamage()
    {
        hp = hp - dmg;
    }

    void OnMouseDown()
    {
        TakeDamage();
        textChange.Change();
    }
}
