using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossChecker : MonoBehaviour
{
    public GameManager gm;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    void OnDestroy()
    {
        gm.LevelCleared();
    }
}
