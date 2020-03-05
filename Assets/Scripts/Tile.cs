using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite[] tileGraphics;
    public float hoverAmount;
    //public int sortingOrderNorm = 5;
    //public int sortingOrderPlus = 7;
    //private SpriteRenderer sprite;
    public LayerMask obstacleLayer;
    public Color highlightedColor;
    public bool isWalkable;
    GameMaster gm;
        

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        gm = FindObjectOfType<GameMaster>();
        //sprite = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        //sprite.sortingOrder = sortingOrderPlus;
        transform.localScale += Vector3.one * hoverAmount;
    }

    private void OnMouseExit()
    {
        //sprite.sortingOrder = sortingOrderNorm;
        transform.localScale -= Vector3.one * hoverAmount;
    }
    
    public bool IsClear()
    {
        Collider2D obstacle = Physics2D.OverlapCircle(transform.position, 0.2f, obstacleLayer);
        if (obstacle != null)
        {
            return false;
        } else
        {
            return true;
        }
            
       
    }

    public void Highlight()
    {
        rend.color = highlightedColor;
        isWalkable = true;
    }

    public void Reset()
    {
        rend.color = Color.white;
        isWalkable = false; 
    }

}
