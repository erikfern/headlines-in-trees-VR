using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    // Start called before the first frame update
    void Start()
    {
        //takes in article title and replaces it
        Text myText0 = GameObject.Find("Text0").GetComponent<Text>();
        myText0.text = (LoadArticles.articles[0].title);

        Text myText1 = GameObject.Find("Text1").GetComponent<Text>();
        myText1.text = (LoadArticles.articles[1].title);

        Text myText2 = GameObject.Find("Text2").GetComponent<Text>();
        myText2.text = (LoadArticles.articles[2].title);

        Text myText3 = GameObject.Find("Text3").GetComponent<Text>();
        myText3.text = (LoadArticles.articles[3].title);

        Text myText4 = GameObject.Find("Text4").GetComponent<Text>();
        myText4.text = (LoadArticles.articles[4].title);

        Text myText5 = GameObject.Find("Text5").GetComponent<Text>();
        myText5.text = (LoadArticles.articles[5].title);

        //How to convert to string
        //int myInt = LoadArticles.articles[6].id;
        //string myString = myInt.ToString();
        
        Text myText6 = GameObject.Find("Text6").GetComponent<Text>();
        myText6.text = (LoadArticles.articles[6].title);

        Text myText7 = GameObject.Find("Text7").GetComponent<Text>();
        myText7.text = (LoadArticles.articles[7].title);
    }
}

