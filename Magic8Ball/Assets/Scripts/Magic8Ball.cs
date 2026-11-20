using UnityEngine;

public class Magic8Ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string[] answers;
        }
    }

    private string[] answers =
        {
        "Yes",
        "No",
        "Ask again later",
        "Outlook uncertain"
    };
}

}
