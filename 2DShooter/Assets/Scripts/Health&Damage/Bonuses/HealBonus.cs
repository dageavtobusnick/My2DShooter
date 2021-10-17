using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBonus : Bonus
{
    public int healBonus;
    public override void UseBonus(GameObject player)
    {
        player.GetComponent<Health>().ReceiveHealing(healBonus);
    }
}
