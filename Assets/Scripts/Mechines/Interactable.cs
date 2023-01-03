using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public event Action<bool> OnClick;
    public string id;

    private void OnMouseDown()
    {
        OnClick?.Invoke(true);
        Debug.Log("You found a " + id);
        gameObject.SetActive(false);
    }
}
