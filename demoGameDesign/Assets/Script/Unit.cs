using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPosition;
    private void Update()
    {
        float stoppingDistance = .1f;
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float moveSpeed = 4;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(1))
        {
            Move(MouseWorld.GetPosition());
        }
    }
    private void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
}
