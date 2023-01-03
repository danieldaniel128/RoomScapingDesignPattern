using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Graph : MonoBehaviour
{
    [SerializeField]List<Interactable> interactables = new List<Interactable>();
    Node root;
    

    private void Start()
    {
        BuidTree();
    }

    public bool GetValue()
    {
        return root.GetValue();
    }




    void BuidTree() 
    {
        root = new Node();
        foreach (var interactable in interactables)
        {
            var child = root.CreateChild();
            interactable.OnClick += child.SetValue;
        }
    }

    private void OnMouseDown()
    {
        if (GetValue())
        {
            Debug.Log($"{gameObject.name} unlocked");
        }
        else
        {
            Debug.Log($"{gameObject.name} is locked");
        }
    }




}
