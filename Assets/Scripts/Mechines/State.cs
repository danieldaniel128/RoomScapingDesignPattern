using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
   public Transform CurrentCamTransform,CamTransormLeft, CamTransormRight;

    public State Right, Left;

    public State(Transform camTransform)
    {
        CurrentCamTransform = camTransform;
    }



}
