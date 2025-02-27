using UnityEngine;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
    public string types;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        types = Strt.options[Strt.numberinList];
        Strt.numberinList++;
        Debug.Log(types);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SceneManager.LoadSceneAsync(types);
    }
}
