using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class menuTranslation : MonoBehaviour
{   
    // *Target the Text Component .1
    TMP_Text targetText;

    // *Increases the Text Area
    [TextArea(3,10)]
    public string PortugueseText;
    [TextArea(3,10)]
    public string EnglishText;

    private void Start()
    {
        //Variables.GameLanguage = Application.systemLanguage;
        // *Target the Text Component .2
        targetText = GetComponent<TMP_Text>();
        ChangeLanguage();
    }

    void Update()
    {
        ChangeLanguage();
    }

    // *Sets the Portuguese Language
    public void PortugueseChange()
    {   
        generalVariables.GameLanguage = 0;
        
    }

    // *Sets the English Language
    public void EnglishChange()
    {
       generalVariables.GameLanguage = 1; 
       
    }

    // *Change the Language
    private void ChangeLanguage()
    {
        if(generalVariables.GameLanguage == 0)//SystemLanguage.Portuguese)
        {
            targetText.text = PortugueseText;
        } else
            {
                targetText.text = EnglishText;
            } 
    }
}
