using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombRules : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject Shields;
    public int numBaskets = 3;
    public float basketLeftX = -14f;
    public float basketSpacingX = 2f;
    public float basketHeight = 0f; // New variable to adjust the y-position
    public List<GameObject> basketList;

    void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(Shields);
            Vector3 pos = Vector3.zero;
            pos.x = basketLeftX + (basketSpacingX * i);
            pos.y = basketHeight; // Adjust y position
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    public void BombDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Bomb");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }

        int basketIndex = basketList.Count - 1;
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("Main-Prototype 1");
        }
    }
}
