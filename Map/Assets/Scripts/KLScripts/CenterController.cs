using UnityEngine;
using System.Collections;

public class CenterController : MonoBehaviour {

    private static CenterController _instance;

    public static CenterController controller
    {
        get
        {
            //If _instance hasn't been set yet, we grab it from the scene!
            //This will only happen the first time this reference is used.
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<CenterController>();
            return _instance;
        }
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
    void Update()
    {

    }

}
