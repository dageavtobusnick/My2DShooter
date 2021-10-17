using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BonusManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(StatsSaver.BonusList.Count>0)
            foreach(var b in StatsSaver.BonusList)
                b.UseBonus(gameObject);
    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        var bonus =collider.gameObject.GetComponent<Bonus>();
        if (bonus)
        {
            bonus.UseBonus(gameObject);
            StatsSaver.BonusList.Add(bonus);
            Destroy(collider.gameObject);
        }
    }
}
