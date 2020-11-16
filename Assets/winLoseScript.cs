using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winLoseScript : MonoBehaviour
{

	Text displaytext;
	public static bool lost = false;

    // Start is called before the first frame update
    void Start()
    {
        displaytext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lost) {
        	displaytext.text = "You lost!";
        }
        else if (scoreScript.scoreValue >= 3){
        	displaytext.text = "You won!";
        }
    }
}
