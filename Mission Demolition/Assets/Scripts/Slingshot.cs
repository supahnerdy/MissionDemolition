using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{

    public GameObject launchPoint;
    public GameObject projectilePrefab;

    private GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        launchPoint.SetActive(true);
    }

    void OnMouseExit()
    {
        launchPoint.SetActive(false);
    }

    void OnMouseDown()
    {
        projectile = Instantiate(projectilePrefab);
        projectile.transform.position = launchPoint.transform.position;
    }
}
