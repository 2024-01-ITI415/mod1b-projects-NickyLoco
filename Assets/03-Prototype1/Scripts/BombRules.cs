using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using	UnityEngine.SceneManagement;

public class BombRules : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject Lives;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY	= 2f;
    public List<GameObject>	basketList;
    // Start is called before the first frame update
    void Start()
    {
    basketList = new List<GameObject>();
    for (int i=0; i<numBaskets; i++) {
    GameObject tBasketGO = Instantiate<GameObject>(Lives);
    Vector3	pos	= Vector3.zero;
    pos.y =	basketBottomY +	(basketSpacingY	* i);
    tBasketGO.transform.position = pos;
    basketList.Add(tBasketGO);
    }
    }  
    public void BombDestroyed(){
    //Destroyallof the falling apples
    GameObject[] tAppleArray=GameObject.FindGameObjectsWithTag("Bomb");
    foreach	(GameObject tGO in tAppleArray)	{
    Destroy(tGO);
        }
    //	Destroy	one	of the	baskets
    //	Get	the	index of the last Basket	in	basketList
    int	basketIndex	= basketList.Count-1;
    //	Get	a reference	to	that	Basket	GameObject
    GameObject tBasketGO = basketList[basketIndex];
    //	Remove	the	Basket	from the list and destroy the GameObject
    basketList.RemoveAt(basketIndex);
    Destroy(tBasketGO);

    if (basketList.Count ==	0) {
    SceneManager.LoadScene("Main-Prototype1");
    }
    }   
}
