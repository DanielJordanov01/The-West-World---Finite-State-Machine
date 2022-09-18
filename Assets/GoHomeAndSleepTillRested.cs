using UnityEngine;

public class GoHomeAndSleepTillRested : State
{
    public override void Enter(Miner miner) {
        Debug.Log("Woohoo! Rich enough for now. Back home");        
    }

    public override void Update(Miner miner) {
        Debug.Log("ZZZZZ");
        Debug.Log("ZZZZZ");
        Debug.Log("ZZZZZ");
        miner.fatigue = 0;
        miner.SwitchState(miner.digForNugget);
    }

    public override void Exit(Miner miner) {
        Debug.Log("What a God-darn fantastic nap! Time to find more gold");
    }
}
