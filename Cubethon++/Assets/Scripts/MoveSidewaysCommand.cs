using UnityEngine;

class MoveSidewaysCommand : Command
{
    private bool direction;
    private PlayerMovement pm;
    public MoveSidewaysCommand(PlayerController reciever, PlayerMovement pm, bool direction) : base(reciever)
    {
        this.pm = pm;
        this.direction = direction;
    }
    public override void Execute()
    {
        m_Reciever.MoveSideways(pm, direction);
    }
}
