using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpinAction : BaseAction
{
    // public delegate void SpinCompleteDelegat();

    private float totalSpinAmount;

    private void Update()
    {
        if (!isActive)
        {
            return;
        }

        if (isActive)
        {
            float spinAddAmount = 360f * Time.deltaTime;
            transform.eulerAngles += new Vector3(0, spinAddAmount, 0);

            totalSpinAmount += spinAddAmount;
            if (totalSpinAmount >= 360f)
            {
                isActive = false;
                onActionComplete();
            }
        }
    }
    public void Spin(Action onActionComplete)
    {
        this.onActionComplete = onActionComplete;
        isActive = true;
        totalSpinAmount = 0f;
        Debug.Log("Spinning");
    }
}