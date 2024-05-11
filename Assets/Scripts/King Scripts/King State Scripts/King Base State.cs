using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class KingBaseState : MonoBehaviour
{
    public abstract KingBaseState RunCurrentState();
}
