using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gate : MonoBehaviour
{
    public string neededKeyID;
    public string sceneToGoTo;



    void OnTriggerEnter2D(Collider2D other)
    {
        Inventory i = GameObject.Find("Alien").GetComponent<Inventory>();
        
        if (i.hasKey(neededKeyID))
        {
            SceneManager.LoadScene(sceneToGoTo);
        }


    }






        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
