using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBonus : Bonus
{
    public int lifeBonus;

    public override void UseBonus(GameObject player)
    {
        player.GetComponent<Health>().currentLives += lifeBonus;
    }
}
