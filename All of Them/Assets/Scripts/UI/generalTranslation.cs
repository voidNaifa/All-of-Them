using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class generalTranslation : MonoBehaviour
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
        // *Target the Text Component .2
        targetText = GetComponent<TMP_Text>();
        ChangeLanguage();
    }

    // *Change the Language
    private void ChangeLanguage()
    {
        if(generalVariables.GameLanguage == 0)
        {
            targetText.text = PortugueseText;
        } else
            {
                targetText.text = EnglishText;
            } 
    }
}
