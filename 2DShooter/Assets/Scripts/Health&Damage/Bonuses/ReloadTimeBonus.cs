using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadTimeBonus : Bonus
{
    public float reloadTimeBonus;

    public override void UseBonus(GameObject player)
    {
        player.GetComponent<ShootingController>().fireRate -= reloadTimeBonus;
    }
}
