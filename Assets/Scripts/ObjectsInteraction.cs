using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectsInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameManager gameManager;
    public int objectNumber;

    public bool doesFall;

    private bool isClicked;
    private bool isMouseObject;

    private SpriteRenderer spriteRend;
    public Sprite spriteBroken;

    public GameObject mouseObject;

    public GameObject damagedSFX;

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
            if(doesFall)
            {
                GetComponent<Rigidbody2D>().WakeUp();
            }
            else
            {
                spriteRend.sprite = spriteBroken;
                damagedSFX.GetComponent<AudioSource>().Play();
            }

            if (isMouseObject)
            {
                mouseObject.SetActive(true);
            }

            isClicked = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            spriteRend.sprite = spriteBroken;
            GetComponent<Rigidbody2D>().Sleep();
            GetComponent<BoxCollider2D>().enabled = false;
            damagedSFX.GetComponent<AudioSource>().Play();
        }
    }
}
