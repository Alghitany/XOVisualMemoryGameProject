using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navvv : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void animals()
    {
        
        Application.LoadLevel("animals");
    }
    public void parts()
    {
        Application.LoadLevel("parts");
    }
    public void family()
    {
        Application.LoadLevel("familly");
    }
    public void clothes()
    {
        Application.LoadLevel("clothes");
    }
    public void fruits()
    {
        Application.LoadLevel("fruits");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
