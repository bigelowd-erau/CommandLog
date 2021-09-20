using UnityEngine;

public class PlayerReciever : PlayerController
{
    public override void MoveSideways(PlayerMovement pm, bool direction)
    {
        pm.MoveSideways(direction);
        Debug.Log("Move Sideways");
    }
}
