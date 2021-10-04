using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingPlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        Debug.Log("Entering Standing State");
        player._currentState = this;
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown("w"))
        {
            JumpingPlayerState jumpingPlayerState = new JumpingPlayerState();
            jumpingPlayerState.Enter(player);
        }
    }
}
