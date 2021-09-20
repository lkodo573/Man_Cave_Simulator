using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Markup : MonoBehaviour
{
    [SerializeField] Camera MainCamera;
    [SerializeField] GameObject Cue;
    [SerializeField] GameObject Cue1;

    private void Awake()
    {
        Cue.SetActive(false);

    }
    public void ToggleLinkedObject()
    {
        Cue.SetActive(!Cue.activeSelf);
        Cue1.SetActive(false);
    }
}
