using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenBonus : Bonus
{
    public int regenBonus;
    public override void UseBonus(GameObject player)
    {
        player.GetComponent<RegenScript>().HealPower+=regenBonus;
    }
}
