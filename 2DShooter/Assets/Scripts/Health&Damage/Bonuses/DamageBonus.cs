using UnityEngine;

public class DamageBonus : Bonus
{
    public int DamageAmountBonus = 0;
    public override void UseBonus(GameObject player)
    {
        player.GetComponent<ShootingController>().projectilePrefab.GetComponent<Damage>().damageAmount+=DamageAmountBonus;
    }
}
