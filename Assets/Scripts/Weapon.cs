using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            GameObject gameObject = Instantiate(projectile, transform.position, Quaternion.identity);
            gameObject.GetComponent<Projectile>().Fire(ray.direction);
            //Destroy(projectile, 15);
        }
    }
}
