using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeImageSommeil : MonoBehaviour
{
    public Texture image1;
    public Texture image2;
    public GameObject text;
    public GameObject buttontext;
    public GameObject rawimage;
    public int state=0;
    // Start is called before the first frame update
    void changeImage()
    {
        if (state==0)
        {
            rawimage.GetComponent<RawImage>().texture = image2;
            text.GetComponent<TextMeshPro>().text = "Tenez le bébé à deux mains"; 
            buttontext.GetComponent<Text>().text = "Précédent"; 
            state=1;

        }
        else
        {
            rawimage.GetComponent<RawImage>().texture = image1; 
            state=0;
            text.GetComponent<TextMeshPro>().text = "Déposez le bébé dans son lit, sur le dos"; 
            buttontext.GetComponent<Text>().text = "Suivant"; 

        }
    }
}
