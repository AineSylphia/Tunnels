using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameValue : MonoBehaviour
{
    [SerializeField] int widthNum = 5;
    [SerializeField] int heightNum = 6;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getWidth()
    {
        return widthNum;
    }
    public int getHeight()
    {
        return heightNum;
    }
}

