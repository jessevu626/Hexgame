using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public float hoverAmount;
    //public int sortingOrderNorm = 5;
    //public int sortingOrderPlus = 7;
    //private SpriteRenderer sprite;
    public LayerMask obstacleLayer;

    void Start()
    {
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

}
