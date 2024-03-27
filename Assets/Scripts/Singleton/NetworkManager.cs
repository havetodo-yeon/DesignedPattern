using UnityEngine;

class NetworkManager : TSingleton<NetworkManager>
{
    public void OnConnectedNetworkServer()
    {

    }
}

public class LoginSystem : MonoBehaviour
{
    private void Awake()
    {
        NetworkManager.Instance.OnConnectedNetworkServer();
    }
}
