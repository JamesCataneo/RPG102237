using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThrowingTutorial : MonoBehaviour
{
    [Header("Reference")]
    public Transform cam;
    public Transform attackpoint;
    public GameObject objectToThrow;

    [Header("Settings")]
    public int totalThrows;
    public float ojectToThrow;

    [Header("Throwing")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float throwUpwardForce;

    bool readyToThrow;

    private void Start()
    {
        readyToThrow = true;
    }
    private void Update()
    {
        if(Input.GetKeyDown(throwKey) && readyToThrow && totalThrows > 0)
        {

        }
    }
}
