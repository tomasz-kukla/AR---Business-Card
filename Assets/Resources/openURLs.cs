using UnityEngine;

public class openURLs : MonoBehaviour
{

    public void LinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/tomasz-kukla/");
    }

    public void Spotify()
    {
        Application.OpenURL("https://open.spotify.com/user/si0qbptihke29lo7zwkxsyj6q?si=4a9961d247724c76");
    }

    public void Github()
    {
        Application.OpenURL("https://github.com/tomasz-kukla");
    }


}
