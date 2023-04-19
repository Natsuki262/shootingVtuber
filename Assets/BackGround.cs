using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float scrollSpeed = 1f;
    private float resetPosition = -10f;


    private Material material;
    private float offsetY;

    Material[] mats;
    Material nM;
    void Start()
    {


        mats = gameObject.GetComponent<SpriteRenderer>().materials;
        nM = mats[0];
        Debug.Log(nM);


    }

    // Update is called once per frame
    void Update()
    {
        offsetY += scrollSpeed * Time.deltaTime;
        if (offsetY > 1f)
        {
            offsetY -= 1f;
        }
        if (nM == null) return;
        nM.mainTextureOffset = new Vector2(0f, offsetY);
    }
}
