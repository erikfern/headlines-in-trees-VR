using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shareButton : MonoBehaviour
{
    public GameObject tree;
    public GameObject treeHolder;

    private Vector3 pos;

    public static float indigenous;
    public static float environment;

    public static float economic;
    public static float depth;

    public static float balance;

    public static int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        counter++;

        if (other.tag == "hand")
        {

            foreach (Transform child in GameObject.Find("Treeholder").transform)
            {
                Destroy(child.gameObject);
            }

            //resets the tree
            //if (GameObject.Find("Treeholder").transform.childCount > 0) {
            //    Destroy(GameObject.Find("Treeholder"));
            //    Instantiate(treeHolder);
            //}

            //Destroy(GameObject.Find("Treeholder"));
            //Debug.Log("hand passed");
            //Debug.Log("i" + indigenous + "eco" + economic + "env" + environment);
            Debug.Log("counter: " + counter);

            if (gameObject.name == "button0")
            {
                int myInt = LoadArticles.articles[0].id;
                string myString = myInt.ToString();
                Debug.Log(myString);

                float ind = LoadArticles.articles[0].indigenous;
                indigenous = CalculateI(ind);
                

                float env = LoadArticles.articles[0].environmental;
                environment = CalculateEn(env);
               

                float eco = LoadArticles.articles[0].economic;
                economic = CalculateEc(eco);
                

                float dep = LoadArticles.articles[0].depth;
                depth = CalculateD(dep);
                

                float bal = LoadArticles.articles[0].balance;
                balance = CalculateB(bal);

                Debug.Log("i" + indigenous + "eco" + economic + "env" + environment);
                generateTree();

                this.transform.parent.gameObject.SetActive(false);
            }
            if (gameObject.name == "button1"){
                int myInt = LoadArticles.articles[1].id;
                string myString = myInt.ToString();
                Debug.Log(myString);

                float ind = LoadArticles.articles[1].indigenous;
                indigenous = CalculateI(ind);


                float env = LoadArticles.articles[1].environmental;
                environment = CalculateEn(env);


                float eco = LoadArticles.articles[1].economic;
                economic = CalculateEc(eco);


                float dep = LoadArticles.articles[1].depth;
                depth = CalculateD(dep);


                float bal = LoadArticles.articles[1].balance;
                balance = CalculateB(bal);

                Debug.Log("i" + indigenous + "eco" + economic + "env" + environment);
                generateTree();

                this.transform.parent.gameObject.SetActive(false);

               
            }
            if (gameObject.name == "button2")
            {
                int myInt = LoadArticles.articles[2].id;
                string myString = myInt.ToString();
                Debug.Log(myString);

                float ind = LoadArticles.articles[2].indigenous;
                indigenous = CalculateI(ind);


                float env = LoadArticles.articles[2].environmental;
                environment = CalculateEn(env);


                float eco = LoadArticles.articles[2].economic;
                economic = CalculateEc(eco);


                float dep = LoadArticles.articles[2].depth;
                depth = CalculateD(dep);


                float bal = LoadArticles.articles[2].balance;
                balance = CalculateB(bal);

                Debug.Log("i" + indigenous + "eco" + economic + "env" + environment);
                generateTree();

                this.transform.parent.gameObject.SetActive(false);
            }
            if (gameObject.name == "button3")
            {
                int myInt = LoadArticles.articles[3].id;
                string myString = myInt.ToString();
                Debug.Log(myString);

                float ind = LoadArticles.articles[3].indigenous;
                indigenous = CalculateI(ind);


                float env = LoadArticles.articles[3].environmental;
                environment = CalculateEn(env);


                float eco = LoadArticles.articles[3].economic;
                economic = CalculateEc(eco);


                float dep = LoadArticles.articles[3].depth;
                depth = CalculateD(dep);


                float bal = LoadArticles.articles[3].balance;
                balance = CalculateB(bal);

                Debug.Log("i" + indigenous + "eco" + economic + "env" + environment);
                generateTree();

                this.transform.parent.gameObject.SetActive(false);
            }
            if (gameObject.name == "button4")
            {
                int myInt = LoadArticles.articles[4].id;
                string myString = myInt.ToString();
                Debug.Log(myString);

                float ind = LoadArticles.articles[4].indigenous;
                indigenous = CalculateI(ind);


                float env = LoadArticles.articles[4].environmental;
                environment = CalculateEn(env);


                float eco = LoadArticles.articles[4].economic;
                economic = CalculateEc(eco);


                float dep = LoadArticles.articles[4].depth;
                depth = CalculateD(dep);


                float bal = LoadArticles.articles[4].balance;
                balance = CalculateB(bal);

                Debug.Log("i" + indigenous + "eco" + economic + "env" + environment);
                generateTree();

                this.transform.parent.gameObject.SetActive(false);
            }
            if (gameObject.name == "button5")
            {
                int myInt = LoadArticles.articles[5].id;
                string myString = myInt.ToString();
                Debug.Log(myString);

                float ind = LoadArticles.articles[5].indigenous;
                indigenous = CalculateI(ind);


                float env = LoadArticles.articles[5].environmental;
                environment = CalculateEn(env);


                float eco = LoadArticles.articles[5].economic;
                economic = CalculateEc(eco);


                float dep = LoadArticles.articles[5].depth;
                depth = CalculateD(dep);


                float bal = LoadArticles.articles[5].balance;
                balance = CalculateB(bal);

                Debug.Log("i" + indigenous + "eco" + economic + "env" + environment);
                generateTree();

                this.transform.parent.gameObject.SetActive(false);
            }
            if (gameObject.name == "button6")
            {
                int myInt = LoadArticles.articles[6].id;
                string myString = myInt.ToString();
                Debug.Log(myString);

                float ind = LoadArticles.articles[6].indigenous;
                indigenous = CalculateI(ind);


                float env = LoadArticles.articles[6].environmental;
                environment = CalculateEn(env);


                float eco = LoadArticles.articles[6].economic;
                economic = CalculateEc(eco);


                float dep = LoadArticles.articles[6].depth;
                depth = CalculateD(dep);


                float bal = LoadArticles.articles[6].balance;
                balance = CalculateB(bal);

                Debug.Log("i" + indigenous + "eco" + economic + "env" + environment);
                generateTree();

                this.transform.parent.gameObject.SetActive(false);
            }
            if (gameObject.name == "button7")
            {
                int myInt = LoadArticles.articles[7].id;
                string myString = myInt.ToString();
                Debug.Log(myString);

                float ind = LoadArticles.articles[7].indigenous;
                indigenous = CalculateI(ind);


                float env = LoadArticles.articles[7].environmental;
                environment = CalculateEn(env);


                float eco = LoadArticles.articles[7].economic;
                economic = CalculateEc(eco);


                float dep = LoadArticles.articles[7].depth;
                depth = CalculateD(dep);


                float bal = LoadArticles.articles[7].balance;
                balance = CalculateB(bal);

                Debug.Log("i" + indigenous + "eco" + economic + "env" + environment);
                generateTree();

                this.transform.parent.gameObject.SetActive(false);
            }

        }
    }

    public float scale(float OldMin, float OldMax, float NewMin, float NewMax, float OldValue)
    {
        float OldRange = (OldMax - OldMin);
        float NewRange = (NewMax - NewMin);
        float NewValue = (((OldValue - OldMin) * NewRange) / OldRange) + NewMin;

        return (NewValue);
    }

    public float CalculateI(float value)
    {
        if (counter < 2)
        {
            indigenous = indigenous + value;
        }
        else
        {
            indigenous = ((indigenous + value) / 200) * 100;
        }
        return indigenous;
    }

    public float CalculateEn(float value)
    {
        if (counter < 2)
        {
            environment = environment + value;
        }
        else
        {
            environment = ((environment + value) / 200) * 100;
        }
        return environment;
    }

    public float CalculateEc(float value)
    {
        if (counter < 2)
        {
            economic = economic + value;
        }
        else
        {
            economic = ((economic + value) / 200) * 100;
        }
        return economic;
    }

    public float CalculateD(float value)
    {
        if (counter < 2)
        {
            depth = depth + value;
        }
        else
        {
            depth = ((depth + value) / 200) * 100;
        }
        return depth;
    }

    public float CalculateB(float value)
    {
        if (counter < 2)
        {
            balance = balance + value;
        }
        else
        {
            balance = ((balance + value) / 200) * 100;
        }
        return balance;
    }

    void generateTree()
    {
        //Debug.Log("collider works");
        //pos = new Vector3(Random.Range(-2, 2), 4, Random.Range(-2, 2));

        pos = new Vector3(0, 0, 0);

        /*
        tree.GetComponent<RecursiveInstantiator>().recurse = 5; // int 2 - 20

        tree.GetComponent<RecursiveInstantiator>().numLeaves = 5; // int 1 - 10

        //float leafSize = Random.Range(0.1f, 1f);
        float leafSize = scale(0, 100, 0.1f, 1.0f, environment);
        tree.GetComponent<RecursiveInstantiator>().leafPrefabSizeX = leafSize; // float 0.1f - 1f
        tree.GetComponent<RecursiveInstantiator>().leafPrefabSizeY = leafSize; // float 0.1f - 1f
        tree.GetComponent<RecursiveInstantiator>().leafPrefabSizeZ = leafSize; // float 0.1f - 1f

        tree.GetComponent<RecursiveInstantiator>().relativeBranchSizeX = 1; // float 1.0f - 1.5f
        tree.GetComponent<RecursiveInstantiator>().relativeBranchSizeY = 1; // float 1.0f - 1.5f
        tree.GetComponent<RecursiveInstantiator>().relativeBranchSizeZ = 1; // float 1.0f - 1.5f

        tree.GetComponent<RecursiveInstantiator>().scale = 0.8f; // float 0.5 - 0.9 
        tree.GetComponent<RecursiveInstantiator>().angle = 30.0f; // float 20.0f - 45.0f
        */


        tree.GetComponent<RecursiveInstantiator>().recurse = (int) scale(0, 100, 6, 20, depth); // int 2 - 20

        tree.GetComponent<RecursiveInstantiator>().numLeaves = (int) scale(0, 100, 1, 10, economic); // int 1 - 10

        float leafSize = scale(0, 100, 0.1f, 1.0f, environment);
        tree.GetComponent<RecursiveInstantiator>().leafPrefabSizeX = leafSize; // float 0.1f - 1f 
        tree.GetComponent<RecursiveInstantiator>().leafPrefabSizeY = leafSize; // float 0.1f - 1f
        tree.GetComponent<RecursiveInstantiator>().leafPrefabSizeZ = leafSize; // float 0.1f - 1f

        tree.GetComponent<RecursiveInstantiator>().relativeBranchSizeX = 1; // float 1.0f - 1.5f
        tree.GetComponent<RecursiveInstantiator>().relativeBranchSizeY = 1; //scale(0, 100, 1.0f, 1.5f, indigenous); // float 1.0f - 1.5f 
        tree.GetComponent<RecursiveInstantiator>().relativeBranchSizeZ = 1; // float 1.0f - 1.5f

        tree.GetComponent<RecursiveInstantiator>().scale = scale(0, 100, 0.6f, 0.9f, indigenous); // float 0.5 - 0.9 
        tree.GetComponent<RecursiveInstantiator>().angle = scale(0, 100, 20.0f, 45.0f, balance); // float 20.0f - 45.0f
        

        Instantiate(tree, pos, Quaternion.identity);
    }
}
