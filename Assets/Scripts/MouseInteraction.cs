using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInteraction : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject winCanvas;

    private bool isClicked;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && isClicked == false)
        {
            isClicked = true;
        }
    }
}
