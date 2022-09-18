using UnityEngine;

public abstract class State
{
    public abstract void Enter(Miner miner);

    public abstract void Update(Miner miner);

    public abstract void Exit(Miner miner);
}
