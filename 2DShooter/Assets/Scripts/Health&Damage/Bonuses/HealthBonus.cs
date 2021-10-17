using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonus : Bonus
{
    public int healthBonus;

    public override void UseBonus(GameObject player)
    {
        var health= player.GetComponent<Health>();
        health.maximumHealth += healthBonus;
        health.currentHealth += healthBonus;
    }
}
