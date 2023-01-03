using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMechine : MonoBehaviour
{

    public State CurrentState;
    public List<Transform> TransformList;
    public List<State> States;

    private void Start()
    {
        States=new List<State>();
        for (int i = 0; i < TransformList.Count; i++)
        {
            States.Add(new State(TransformList[i]));
            
            
        }
        for (int i = 0; i < States.Count; i++)
        {
            if (i == 0)
            {
                States[i].Left = States[States.Count - 1];
            }
            else
            {
                States[i].Left = States[i - 1];
            }

            if (i == States.Count - 1) 
            {
                States[i].Right = States[0];
            }
            else
                States[i].Right = States[i+1];
        }

        SetState(States[0]);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
            SetState(CurrentState.Left);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            SetState(CurrentState.Right);

    }


    public void SetState(State state)
    {
        CurrentState = state;
        Camera.main.transform.position = state.CurrentCamTransform.position;
        Camera.main.transform.rotation = state.CurrentCamTransform.rotation;
    }





}
