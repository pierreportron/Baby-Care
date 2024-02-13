using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeImageSommeil : MonoBehaviour
{
    public Texture image1;
    public Texture image2;
    public TextMeshProUGUI text;
    public TextMeshProUGUI buttontext;
    public GameObject rawimage;
    public int state;
    // Start is called before the first frame update
    public void changeImage()
    {
        if (state==0)
        {
            rawimage.GetComponent<RawImage>().texture = image2;
            //text.GetComponent<TextMeshProUGUI>().text = "Tenez le bébé à deux mains"; 
            //buttontext.GetComponent<TextMeshProUGUI>().text ="Précédent"; 
            text.text = "Déposez le bébé dans son lit, sur le dos"; 
            buttontext.text ="Précédent"; 
            state=1;

        }
        else
        {
            rawimage.GetComponent<RawImage>().texture = image1; 
            //text.GetComponent<TextMeshProUGUI>().text ="Déposez le bébé dans son lit, sur le dos"; 
            //buttontext.GetComponent<TextMeshProUGUI>().text="Suivant"; 
            text.text ="Tenez le bébé à deux mains"; 
            buttontext.text="Suivant"; 
            state=0;

        }
    }
    void Start()
    {
        state=0;
    }

}
