using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEventReceiver : MonoBehaviour
{
    public CharacterCombat combat;

    public void AttackHitEvent()
    {
        combat.AttackHitAnimationEvent();
    }
}
