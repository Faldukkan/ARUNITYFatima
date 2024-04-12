using UnityEngine;
using UnityEngine.UI;

public class GlassesSelector : MonoBehaviour
{
    public GameObject glasses1;
    public GameObject glasses2;

    public void SelectGlasses1()
    {
        // Enable glasses1 and disable glasses2
        glasses1.SetActive(true);
        glasses2.SetActive(false);
    }

    public void SelectGlasses2()
    {
        // Enable glasses2 and disable glasses1
        glasses1.SetActive(false);
        glasses2.SetActive(true);
    }
}