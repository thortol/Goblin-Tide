using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManager : MonoBehaviour
{
    private float startingX;
    private float startingWidth;
    private int startingHP;
    private float curX;
    private float curWidth;
    private float curHP;
    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startingWidth = rectTransform.rect.width;
        startingX = rectTransform.transform.position.x;
        startingHP = GameManager.instance.GetWallHp();
    }

    public void updateHP()
    {
        curHP = GameManager.instance.GetWallHp();
        curWidth = (curHP / startingHP) * startingWidth;
        curX = startingX + (-startingWidth + curWidth) / 2.0f;
        rectTransform.sizeDelta = new Vector2(curWidth, rectTransform.rect.height);
        rectTransform.transform.position = new Vector3(curX, rectTransform.transform.position.y, rectTransform.transform.position.z);
    }
}
