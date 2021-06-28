using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roket : MonoBehaviour
{
    public float speed;
    public int Level = 0;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;

    void FixedUpdate()
    {
        if(Level == 1 && !((gameObject.transform.position.x - Star1.transform.position.x) < 4 && gameObject.transform.position.x - Star1.transform.position.x > -4))
        {
            Vector3 level1 = gameObject.transform.position - Star1.transform.position + new Vector3(0,50,0);
            level1.Normalize();
            gameObject.transform.Translate(level1.x*Time.deltaTime*-speed,level1.y*Time.deltaTime*-speed,0);
        }
        else if (Level == 2 && !((gameObject.transform.position.x - Star2.transform.position.x) < 4 && gameObject.transform.position.x - Star2.transform.position.x > -4))
        {
            Vector3 level2 = gameObject.transform.position - Star2.transform.position + new Vector3(0, 50, 0);
            level2.Normalize();
            gameObject.transform.Translate(level2.x * Time.deltaTime*-speed, level2.y * Time.deltaTime*-speed, 0);
        }
        else if(Level == 3 && !((gameObject.transform.position.x - Star3.transform.position.x) < 4 && gameObject.transform.position.x - Star3.transform.position.x > -4))
        {
            Vector3 level3 = gameObject.transform.position - Star3.transform.position + new Vector3(0, 50, 0);
            level3.Normalize();
            gameObject.transform.Translate(level3.x * Time.deltaTime*-speed, level3.y * Time.deltaTime*-speed, 0);
        }

    }

    public IEnumerator Level1()
    {
        yield return new WaitForSecondsRealtime(1f);
        Level = 1;
    }
}
