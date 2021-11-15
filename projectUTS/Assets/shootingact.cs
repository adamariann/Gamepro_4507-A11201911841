using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class shootingact : MonoBehaviour
{
	public UnityEvent action;
    // Start is called before the first frame update
    public void Action()
    {
        action?.Invoke();
    }
}
