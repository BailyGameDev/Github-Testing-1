using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingStateManager : MonoBehaviour
{

    public KingBaseState currentState;

    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        KingBaseState nextstate = currentState?.RunCurrentState();

        if (nextstate != null)
        {
            SwitchToNextState(nextstate);
        }
    }

    private void SwitchToNextState(KingBaseState nextstate)
    {
        currentState = nextstate;
    }
}
