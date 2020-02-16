using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHolderMaker : MonoBehaviour
{
    public GameObject TreeHolder;
    public GameObject tree;
    private Vector3 pos;
    
    void Update()
    {
        //Creates a new tree via recursion
        if (Input.GetKeyDown("q"))
        {
            pos = new Vector3(Random.Range(-2, 2), 4, Random.Range(-2, 2));
            Instantiate(tree, pos, Quaternion.identity);
            Debug.Log("done");

            RecursiveInstantiator.setBooleanFlag(true);
        }

        //Creates a new TreeHolder with an EmptyTreeHolder tag to allow a tree to grow in it
        if (Input.GetKeyDown("t"))
        {
            pos = new Vector3(Random.Range(-2, 2), 4, Random.Range(-2, 2));

            TreeHolder.tag = "EmptyTreeHolder";
            Instantiate(TreeHolder, pos, Quaternion.identity);
        }

        //"Closes" the current TreeHolder by preventing any more trees to grow inside it
        //Enables the boolean flag that allows the tree to resize the prefab
        if (Input.GetKeyDown("r"))
        {
            GameObject.FindGameObjectWithTag("EmptyTreeHolder").tag = "FilledTreeHolder";
        }
    }
}
