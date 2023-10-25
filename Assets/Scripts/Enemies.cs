using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float bulletSpeed;
    public Transform parent;
    public GameObject ennemiBullet;
    public GameObject ennemi;
    private int chanceTir = 1;
    private int Tir = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Tir = Random.Range(0, 999);
        if (Tir == chanceTir)
        {
            Instantiate(ennemiBullet, parent.position + Vector3.down, parent.rotation);

        }
    }

  
}
//*private void OnTriggerEnter2D(Collider2D collision)
//  {
//      Destroy(collision.gameObject);
//      Destroy(ennemiBullet);
 // }