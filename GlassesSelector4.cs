using UnityEngine;

public class GlassesSelector4 : MonoBehaviour
{
    public string tag1 = "frame1";
    public string tag2 = "frame2";

    private GameObject[] glassesArray1;
    private GameObject[] glassesArray2;

    void Start()
    {
        // Populate glassesArray1 and glassesArray2 using FindGameObjectsWithTag
        glassesArray1 = GameObject.FindGameObjectsWithTag(tag1);
        glassesArray2 = GameObject.FindGameObjectsWithTag(tag2);

        // Initially disable all glasses
        SetGlassesActive(glassesArray1, false);
        SetGlassesActive(glassesArray2, false);
    }

    public void SelectGlasses1()
    {
        SetGlassesActive(glassesArray1, true);
        SetGlassesActive(glassesArray2, false);
    }

    public void SelectGlasses2()
    {
        SetGlassesActive(glassesArray1, false);
        SetGlassesActive(glassesArray2, true);
    }

    private void SetGlassesActive(GameObject[] glassesArray, bool active)
    {
        foreach (GameObject glasses in glassesArray)
        {
            MeshRenderer meshRenderer = glasses.GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                meshRenderer.enabled = active;
            }
            else
            {
                Debug.LogError("MeshRenderer component not found on glasses object: " + glasses.name);
            }
        }
    }
}
