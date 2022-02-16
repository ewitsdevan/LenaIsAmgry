using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectsInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameManager gameManager;
    public int objectNumber;

    private bool isClicked;
    private bool isMouseObject;

    private SpriteRenderer spriteRend;
    public Sprite spriteClicked;

    public GameObject mouseObject;

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        spriteRend = GetComponent<SpriteRenderer>();

        if(objectNumber == gameManager.mouseObject)
        {
            isMouseObject = true;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isClicked == false)
        {
            spriteRend.sprite = spriteClicked;

            if (isMouseObject)
            {
                mouseObject.SetActive(true);
            }

            isClicked = true;
        }
    }
}
