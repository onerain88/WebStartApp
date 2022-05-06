using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using RegistryLib;

public class Sample : MonoBehaviour
{
    public Text exePathText;

    // Start is called before the first frame update
    async void Start()
    {
        string exePath = Process.GetCurrentProcess().MainModule.FileName;
        
        exePathText.text = exePath;
        RegistryUtils.Register("hn5RcJei2JxCYlS0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
