using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenScript : MonoBehaviour
{
    public int HealPower = 1;
    private Health _health;

    public float HealTime;

    private float HealTimer;
    // Start is called before the first frame update
    void Start()
    {
        _health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HealTimer <= 0)
        {
            _health.ReceiveHealing(1);
            HealTimer = HealTime;
        }
        HealTimer-=Time.deltaTime;
    }
}
