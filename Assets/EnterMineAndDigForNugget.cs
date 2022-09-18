using UnityEngine;

public class EnterMineAndDigForNugget : State
{
    public override void Enter(Miner miner) {
        Debug.Log("Miner Bob: Walkin to the gold mine");
    }

    public override void Update(Miner miner) {
        if (miner.goldNuggetsCarried < 2) {
            Debug.Log("Miner Bob: Pickin' up a nugget");
            miner.goldNuggetsCarried++;
            miner.fatigue++;
            miner.thirst++;
        } else {
            miner.SwitchState(miner.depositGold);
        }
    }

    public override void Exit(Miner miner) {
        Debug.Log("Ah'm leavin' the gold mine with mah pockets full o' sweet gold");
    }
}
