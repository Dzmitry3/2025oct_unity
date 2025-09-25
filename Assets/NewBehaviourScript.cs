using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int gold;
    public int addGold = 1;

    private void Start()
    {
        gold = 10;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("+" + addGold);
            gold += addGold;
        }
    }
}
