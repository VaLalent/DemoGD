using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class BaseAction : MonoBehaviour
{
    protected Unit unit;
    protected bool isActive;
    protected Action onActionComplete;

    protected virtual void Awake()
    {
        unit = GetComponent<Unit>();
    }

    public abstract string GetActionName();

    public abstract void TakeAction(GridPosition gridPosition, Action onActionComplete);

    public virtual bool isValidActionGridPosition(GridPosition gridPosition)
    {
        List<GridPosition> validGridPosition = GetValidActionGridPositionList();
        return validGridPosition.Contains(gridPosition);
    }

    public abstract List<GridPosition> GetValidActionGridPositionList();

    public virtual int GetActionPointsCost()
    {
        return 1;
    }

    protected void ActionStart(Action onActioncomplete)
    {
        isActive = true;
        this.onActionComplete = onActioncomplete;
    }

    protected void ActionComplete()
    {
        isActive = false;
        onActionComplete();
    }
}
