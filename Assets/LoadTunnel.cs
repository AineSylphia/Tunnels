using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTunnel : MonoBehaviour
{
    public Texture2D texture;
    const int tunnelMax = 16;
    [SerializeField] Sprite[] imgTunnel = new Sprite[tunnelMax];


    // Start is called before the first frame update
    void Start()
    {
        if (texture == null)
            texture = Resources.Load("./image/Null.png") as Texture2D;

    }

    // Update is called once per frame
    void Update()
    {
        GameObject images = GameObject.Find("Map");
        Sprite sprite = Sprite.Create(texture,new Rect(0,0,32,32),new Vector2(0.0f,0.0f));
        images.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
