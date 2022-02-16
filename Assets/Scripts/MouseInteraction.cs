using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameManager gameManager;
    private bool isClicked;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isClicked == false)
        {
            gameManager.WinGame();
            isClicked = true;
        }
    }
}
