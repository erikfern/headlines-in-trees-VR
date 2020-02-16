/*tutorial: https://www.youtube.com/watch?v=VXegg-HGT0s*/

/*
 * HOW TO MAKE THIS WORK...
 * put this on an empty game object
 * add the branch under the game object. the "branch" prefab MUST be 0.5 units higher than the empty game object above
 * add the leaf prefab to the script
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecursiveInstantiator : MonoBehaviour
{
    //public GameObject treeHolder;

    public int recurse = 10;
    
    private static int totalRecurse;
    private static int totalRecurseCount;

    /*
        private static int totalRecurse;
        private static int totalRecurseCount;
    */

    public int splitNumber = 2;
    private static bool flag = true; //a STATIC boolean flag to disable multiplying branch size after the first recursive call
    
    public float scale = 0.8f; //determines the size in percentage of the next iteration of the branch
    public float mutationChance = 0.4f; //gives a small chance to not generate a branch at any point of the recursion

    public GameObject LeafPrefab;
    public int numLeaves = 3;

    //angle of branch -- anything above 45 degrees will start looking weird lmao
    public float angle = 30.0f;

    //leaf size
    public float leafPrefabSizeX = 0.5f;
    public float leafPrefabSizeY = 0.5f;
    public float leafPrefabSizeZ = 0.5f;

    //branch size - modifies the branch prefab's domensions
    public float relativeBranchSizeX = 1.0f;
    public float relativeBranchSizeY = 1.0f;
    public float relativeBranchSizeZ = 1.0f;

    void Start()
    {
        //initialize the relative size of your prefab. only called once throughout the recursive instance, enables again at the end of the recursion (found in the recursion method)
        if (flag == true) {
            this.gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * relativeBranchSizeX, gameObject.transform.localScale.y * relativeBranchSizeY, gameObject.transform.localScale.z * relativeBranchSizeZ);
            flag = false;
        }

        this.gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        recursion();
    }

    public void recursion()
    {
        recurse -= 1;

        gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("EmptyTreeHolder").transform, false);
        //LeafPrefab.transform.SetParent(GameObject.Find("Treeholder").transform, false);

        for (int i = 0; i < splitNumber; i++)
        {
            if (recurse > 0)
            {
                var copy = Instantiate(gameObject);
                var copy2 = Instantiate(gameObject);

                if (recurse > 1)
                { //you want to begin introducting the random mutation chance after the first branch
                    var recursiveInstance = copy.GetComponent<RecursiveInstantiator>();
                    
                    if (Random.Range(0.0f, 1.0f) > mutationChance)
                    {
                        recursiveInstance.Grow(i);
                        recursiveInstance.RotateOnXAxis(i);
                        recursiveInstance.Scale(i);
                    }
                    else {
                        //do nothing
                    }

                    if (Random.Range(0.0f, 1.0f) > mutationChance)
                    {
                        var recursiveInstance2 = copy2.GetComponent<RecursiveInstantiator>();
                        recursiveInstance2.Grow(i);
                        recursiveInstance2.RotateOnZAxis(i);
                        recursiveInstance2.Scale(i);
                    }
                    else
                    {
                        //do nothing
                    }
                }
                else {
                    var recursiveInstance = copy.GetComponent<RecursiveInstantiator>();
                    recursiveInstance.Grow(i);
                    recursiveInstance.RotateOnXAxis(i);
                    recursiveInstance.Scale(i);
                }

                if (recurse == 1)
                {
                    /*copy.SetActive(false);

                    for (int j = 0; j < numLeaves; j++)
                    {
                        Vector3 pos = gameObject.transform.position + new Vector3(Random.Range(-(leafPrefabSizeX * 0.5f), leafPrefabSizeX * 0.5f), Random.Range(-(leafPrefabSizeY * 0.1f), leafPrefabSizeY * 0.5f), Random.Range(-(leafPrefabSizeZ * 0.5f), leafPrefabSizeZ * 0.5f));
                        LeafPrefab.transform.localScale = new Vector3(leafPrefabSizeX, leafPrefabSizeY, leafPrefabSizeZ);
                        var leaf = Instantiate(LeafPrefab, pos, Quaternion.identity);
                        leaf.transform.parent = GameObject.Find("Treeholder").transform;
                    }*/
                }

                if (recurse == 0) {
                    GameObject.FindGameObjectWithTag("EmptyTreeHolder").tag = "FilledTreeHolder"; //FIX THIS
                }
            }
        }
    }

    

    //auxillary methods to help recusion happen
    private void Grow(int index)
    {
        this.transform.position += this.transform.up * this.transform.localScale.y;
        //this.transform.parent.position += this.transform.parent.up * this.transform.parent.localScale.y;
    }
    private void RotateOnXAxis(int index)
    {
        //ROTATE TOWARDS THE X-AXIS
        this.transform.rotation *= Quaternion.Euler(angle * ((index * 2) - 1), 0, 0);
    }
    private void RotateOnZAxis(int index)
    {
        //ROTATE TOWARDS THE Z-AXIS
        this.transform.rotation *= Quaternion.Euler(0, 0, angle * ((index * 2) - 1));
    }
    private void Scale(int index)
    {
        this.transform.localScale = new Vector3(gameObject.transform.localScale.x * scale, gameObject.transform.localScale.y * scale, gameObject.transform.localScale.z * scale);
    }

    private int factorial(int n) 
    {
        if (n == 1) {
            return 1;
        }
        
        return n * factorial(n - 1);
    }

    /*AT THE END OF THE RECURSION CALL THIS FUNCTION FROM ANOTHER CLASS TO RESCALE YOUR NEXT PREFAB FOR THE NEXT RECURSION*/
    public static void setBooleanFlag(bool theBool)
    {
        RecursiveInstantiator.flag = theBool;
    }
}
