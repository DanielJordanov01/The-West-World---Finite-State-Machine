using UnityEngine;

public class VisitBankAndDepositGold : State
{
    public override void Enter(Miner miner) {
        Debug.Log("Miner Bob: Goin' to the bank. Yes siree");
    }

    public override void Update(Miner miner) {
        miner.moneyInBank += miner.goldNuggetsCarried;
        Debug.Log("Miner Bob: Depositin' gold. Total savings now: " + miner.moneyInBank);
        miner.goldNuggetsCarried = 0;
        miner.fatigue++;
        miner.thirst++;

        if (miner.fatigue > 10) {
            miner.SwitchState(miner.rest);
        } else if (miner.thirst > 5) {
            miner.SwitchState(miner.drink);
        } else {
            miner.SwitchState(miner.digForNugget);
        }
    }

    public override void Exit(Miner miner) {
        Debug.Log("Miner Bob: Leavin' the bank");
    }
}
