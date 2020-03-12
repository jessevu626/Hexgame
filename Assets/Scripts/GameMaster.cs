using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    public Unit selectedUnit;
    public int PlayerTurn = 1;

    public void ResetTiles()
    {
        foreach (Tile tile in FindObjectsOfType<Tile>())
        {
            tile.Reset();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            EndTurn();
        }
    }

    void EndTurn()
    {
        if (PlayerTurn == 1)
        {
            PlayerTurn = 2;
        } else if (PlayerTurn == 2)
        {
            PlayerTurn = 1;
        }

        if (selectedUnit != null)
        {
            selectedUnit.selected = false;
            selectedUnit = null;
        }

        ResetTiles();

        foreach (Unit unit in FindObjectsOfType<Unit>())
        {
            unit.hasMoved = false;
        }
    }

}
