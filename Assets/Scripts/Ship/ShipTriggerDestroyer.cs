using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTriggerDestroyer : MonoBehaviour
{
    public GameObject btnsObject;
    public GameObject miniexObject;
    private void OnTriggerEnter2D(Collider2D col)
    {
        var enemy = GameCore.GetEnemy(col.gameObject);

        if (enemy == null) return;
        
        GameCore.EndGame("Вы проиграли!");

        Destroy(gameObject);
        if (btnsObject != null)
        {
            btnsObject.SetActive(true);
            miniexObject.SetActive(false);
        }

    }
}
