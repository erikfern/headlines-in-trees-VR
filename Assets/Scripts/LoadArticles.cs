using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadArticles : MonoBehaviour
{
    public static List<Article> articles = new List<Article>();

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hi");
       
        //articleData is name of csv file
        TextAsset articleData = Resources.Load<TextAsset>("articleData3");

        string[] data = articleData.text.Split(new char[] { '\n' });

        for (int i = 1; i < data.Length; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });

            Article a = new Article();
            int.TryParse(row[0], out a.id);
            a.title = row[1];
            int.TryParse(row[2], out a.indigenous);
            int.TryParse(row[3], out a.environmental);
            int.TryParse(row[4], out a.economic);
            int.TryParse(row[5], out a.depth);
            int.TryParse(row[6], out a.balance);

             articles.Add(a);
        }

        /*
        foreach (Article a in articles)
        {
            //Debug.Log(a.name + "," + a.id);
            Debug.Log(a.name);
        }
        */
    }
}
