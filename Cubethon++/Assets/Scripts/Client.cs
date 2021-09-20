using UnityEngine;

public class Client : MonoBehaviour
{
    private PlayerController m_PlayerReciever;
    public PlayerMovement pm;

    // Start is called before the first frame update
    void Start()
    {
        m_PlayerReciever = new PlayerReciever(pm);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            Command playerCommand = new MoveSidewaysCommand(m_PlayerReciever, 0);
            Invoker invoker = new Invoker();

            invoker.SetCommand(playerCommand);
            invoker.ExecuteCommand();
        }
        if (Input.GetKey("d"))
        {
            Command playerCommand = new MoveSidewaysCommand(m_PlayerReciever, 1);
            Invoker invoker = new Invoker();

            invoker.SetCommand(playerCommand);
            invoker.ExecuteCommand();
        }
    }
}
