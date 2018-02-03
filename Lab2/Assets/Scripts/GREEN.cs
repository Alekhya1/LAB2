using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GREEN : MonoBehaviour {

    public GameObject Main;
    public Sprite firstImage;
    public Sprite secondImage;

    private Rigidbody2D rBody;
    private SpriteRenderer sRend;

    void Start()
    {
        // Initialization of component references
        rBody = Main.GetComponent<Rigidbody2D>();
        sRend = Main.GetComponent<SpriteRenderer>();

        rBody.velocity = new Vector2(5, 0);
    }
    // Executes when a mouse down event occurs on an object with this script.
    void OnMouseDown()
    {
        if (sRend.sprite == firstImage)
        {
            sRend.sprite = secondImage;
        }
        else
        {
            sRend.sprite = firstImage;
        }

        rBody.velocity *= -1;
    }
}
