using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PartChecker : MonoBehaviour
{
    public Health bossHealth;
    void OnDestroy()
    {
        bossHealth.TakeDamage(gameObject.GetComponent<Health>().maximumHealth);
    }
}
