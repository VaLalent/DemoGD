using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyAI : MonoBehaviour
{

    private float timer;

    private void Start()
    {
        TurnSystem.instance.OnTurnChange += TurnSystem_OnTurnChange;
    }
    private void Update()
    {
        if (TurnSystem.instance.IsPlayerTurn())
        {
            return;
        }

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            TurnSystem.instance.NextTurn();
        }
    }

    private void TurnSystem_OnTurnChange(object sender, EventArgs e)
    {
        timer = 2f;
    }
}
