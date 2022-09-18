using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : MonoBehaviour
{
    // Miner specific fields
    public int goldNuggetsCarried;
    public int moneyInBank;
    public int fatigue;
    public int thirst;

    // States
    State currentState;
    public EnterMineAndDigForNugget digForNugget = new EnterMineAndDigForNugget();
    public VisitBankAndDepositGold depositGold = new VisitBankAndDepositGold();
    public GoHomeAndSleepTillRested rest = new GoHomeAndSleepTillRested();
    public QuenchThirst drink = new QuenchThirst();

    // Start is called before the first frame update
    void Start()
    {
        currentState = digForNugget;

        currentState.Enter(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Update(this);
    }

    public void SwitchState(State state) {
        currentState.Exit(this);
        currentState = state;
        currentState.Enter(this);
    }
}
