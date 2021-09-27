using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCommand : MonoBehaviour
{
    PlayerShooting playerShooting;

    public ShootCommand(PlayerShooting _playerShooting)
    {
        playerShooting = _playerShooting;
    }

    public override void Execute()
    {
        //Player menembak
        playerShooting.Shoot();
    }

    public override void UnExecute()
    {

    }
}
