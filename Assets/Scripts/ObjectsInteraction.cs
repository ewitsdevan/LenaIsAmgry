using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectsInteraction : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && isClicked == false)
        {
            spriteRend.sprite = spriteClicked;

            if(isMouseObject)
            {
                mouseObject.SetActive(true);
            }

            isClicked = true;
        }
    }
}
