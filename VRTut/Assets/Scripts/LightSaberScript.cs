using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaberScript : MonoBehaviour
{
    public Animator LightSaberAnimator;

    public void TurnOnLightSaber()
    {
        LightSaberAnimator.SetTrigger("Turn LightSaber On");
    }

}
