using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void OnLoad()
    {
        StatsSaver.BonusList=new List<Bonus>();
    }
}
