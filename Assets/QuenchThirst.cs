using UnityEngine;

public class QuenchThirst : State
{
    public override void Enter(Miner miner) {
        Debug.Log("Miner Bob: Boy, ah sure is thursty! Walkin' to the saloon");
    }

    public override void Update(Miner miner) {
        Debug.Log("Miner Bob: That's mighty fine sippin liquor");
        miner.thirst = 0;
        miner.SwitchState(miner.digForNugget);
    }

    public override void Exit(Miner miner) {
        Debug.Log("Miner Bob: Leavin' the saloon, feelin' good");
    }
}
